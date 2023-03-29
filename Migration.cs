using hexbear_migration_tool.hexbear;
using hexbear_migration_tool.Models.hexbear;
using hexbear_migration_tool.Models.lemmy;
using Microsoft.EntityFrameworkCore;
using Svg;
using System;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Text.Json;

namespace hexbear_migration_tool {

    internal class Migration {
        private bool _migrate_finished;

        public Migration() { }

        public async Task Start() {
            var hexbearDb = new HexbearContext();
            var lemmyDb = new LemmyContext();
            var trans = lemmyDb.Database.BeginTransaction();
            //this.ApplySchema();
            await Taglines(lemmyDb);
            await Emojis(lemmyDb);
            await CommunitySettings(lemmyDb, hexbearDb);
            await Pronouns(lemmyDb, hexbearDb);
            await Site(lemmyDb, hexbearDb);
            await Language(lemmyDb, hexbearDb);
            await Theme(lemmyDb, hexbearDb);
            await BanId(lemmyDb, hexbearDb);
            await SiteMods(lemmyDb, hexbearDb);
            await FeaturedPosts(lemmyDb, hexbearDb);
            await DataFixes(lemmyDb, hexbearDb);
            trans.Commit();
        }

        public async Task Taglines(LemmyContext lemmyDb) {
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Migrate Taglines: Begin");
            await lemmyDb.Taglines.ExecuteDeleteAsync();
            var taglines = JsonSerializer.Deserialize<List<string>>(File.ReadAllText("taglines.json"));
            var localSiteId = (await lemmyDb.LocalSites.FirstAsync()).Id;
            var lemmyTaglines = taglines.Select(x => new Models.lemmy.Tagline() {
                LocalSiteId = localSiteId,
                Content = x,
            }).ToList();
            await lemmyDb.Taglines.AddRangeAsync(lemmyTaglines);
            await lemmyDb.SaveChangesAsync();
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Migrate Taglines: End");
        }

        public async Task Emojis(LemmyContext lemmyDb) {
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Migrate Emojis: Begin");
            await lemmyDb.CustomEmojis.ExecuteDeleteAsync();
            await lemmyDb.CustomEmojiKeywords.ExecuteDeleteAsync();

            var httpClient = new HttpClient();
            var localSiteId = (await lemmyDb.LocalSites.FirstAsync()).Id;
            var emojiCategories = JsonSerializer.Deserialize<List<EmojiCategory>>(File.ReadAllText("emojis.json"));
            var alreadySeens = new HashSet<string>();
            foreach (var category in emojiCategories) {
                foreach (var emoji in category.emojis) {
                    if (alreadySeens.Contains(emoji))
                        continue;
                    alreadySeens.Add(emoji);
                    string name = emoji.Split(".")[0];
                    string path = emoji;
                    if (emoji.EndsWith("svg")) {
                        ConvertSvg(name);
                        path = name + ".png";
                    }
                    using var stream = System.IO.File.OpenRead($"emojis/{path}");
                    using var content = new MultipartFormDataContent
                    {
                        { new StreamContent(stream), "images[]", path }
                    };
                    var res = await httpClient.PostAsync($"{Program._appSettings.PictrsExternalUrl}/image", content);
                    string response = await res.Content.ReadAsStringAsync();
                    try {
                        var link = JsonSerializer.Deserialize<PictRsResponse>(response)?.files.First().file;
                        var customEmoji = new CustomEmoji() {
                            LocalSiteId = localSiteId,
                            Category = category.name,
                            AltText = name,
                            ImageUrl = $"{Program._appSettings.PictrsInternalUrl}/pictrs/image/{link}",
                            Shortcode = name,
                        };
                        lemmyDb.CustomEmojis.Add(customEmoji);
                    }
                    catch (Exception) {
                        Console.WriteLine(emoji);
                    }
                }
            }
            await lemmyDb.SaveChangesAsync();
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Migrate Emojis: End");
        }

        public async Task CommunitySettings(LemmyContext lemmyDb, HexbearContext hexbearDb) {
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Migrate Community Settings: Begin");
            var communitySettings = hexbearDb.CommunitySettings.ToList();
            foreach (var setting in communitySettings) {
                var lemmyCommunity = await lemmyDb.Communities.FindAsync(setting.Id);
                lemmyCommunity.Hidden = setting.HideFromAll;
                lemmyCommunity.PostingRestrictedToMods = setting.ReadOnly;
            }

            await lemmyDb.SaveChangesAsync();
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Migrate Community Settings: End");
        }

        public async Task Site(LemmyContext lemmyDb, HexbearContext hexbearDb) {
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Migrate Site Settings: Begin");
            var localSite = lemmyDb.LocalSites.First();
            localSite.FederationEnabled = false;
            localSite.ActorNameMaxLength = 80;
            await lemmyDb.SaveChangesAsync();
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Migrate Site Settings: End");
        }

        public async Task Theme(LemmyContext lemmyDb, HexbearContext hexbearDb) {
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Migrate Theme: Begin");
            var people = lemmyDb.LocalUsers.ToList();
            foreach (var person in people) {
                person.Theme = "darkly";
            }
            await lemmyDb.SaveChangesAsync();
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Migrate Theme: End");
        }

        public async Task Language(LemmyContext lemmyDb, HexbearContext hexbearDb) {
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Migrate Language: Begin");
            await lemmyDb.Database.ExecuteSqlRawAsync("UPDATE public.post SET language_id = 37");
            await lemmyDb.Database.ExecuteSqlRawAsync("UPDATE public.comment SET language_id = 37");
            await lemmyDb.Database.ExecuteSqlRawAsync("Delete from public.local_user_language where language_id <> 37");
            await lemmyDb.Database.ExecuteSqlRawAsync("Delete from public.site_language where language_id <> 37");
            await lemmyDb.Database.ExecuteSqlRawAsync(@"
SET session_replication_role = replica;
Delete from public.language
where id <> 37;
SET session_replication_role = DEFAULT;");
            var people = lemmyDb.LocalUsers.ToList();
            foreach (var person in people) {
                person.InterfaceLanguage = "en";
            }
            await lemmyDb.SaveChangesAsync();
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Migrate Language: End");
        }

        public async Task Pronouns(LemmyContext lemmyDb, HexbearContext hexbearDb) {
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Migrate Pronouns: Begin");
            var people = lemmyDb.People.ToList();
            var usertags = hexbearDb.UserTags.ToDictionary(x => x.UserId, x => x);
            foreach (var person in people) {
                var tag = usertags.ContainsKey(person.Id) ? usertags[person.Id] : null;
                string[] pronouns = new string[] { "none/use name" };
                if (tag != null) {
                    pronouns = JsonSerializer.Deserialize<UserTagJSON>(tag.Tags)?.pronouns?.Split(",") ?? new string[] { "none/use name" };
                }
                person.DisplayName = $"{person.Name} [{String.Join(",", pronouns)}]";
            }
            await lemmyDb.SaveChangesAsync();
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Migrate Pronouns: End");
        }

        public async Task BanId(LemmyContext lemmyDb, HexbearContext hexbearDb) {
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Migrate BanId: Begin");
            await lemmyDb.BanIds.ExecuteDeleteAsync();

            var banIds = hexbearDb.BanIds.ToList();
            await lemmyDb.Database.ExecuteSqlRawAsync($"SET session_replication_role = replica;");

            foreach (var banId in banIds) {
                await lemmyDb.Database.ExecuteSqlRawAsync($"Insert into hexbear.ban_id values ('{banId.Id}','{banId.Created}',{(banId.AliasedTo.HasValue ? $"'{banId.AliasedTo}'" : "NULL")});");
                foreach (var person in banId.Uids) {
                    await lemmyDb.Database.ExecuteSqlRawAsync($"Insert into hexbear.user_ban_id values ('{banId.Id}',{person.Id});");
                }
            }
            await lemmyDb.Database.ExecuteSqlRawAsync($"SET session_replication_role = DEFAULT;");

            await lemmyDb.SaveChangesAsync();
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Migrate BanId: End");
        }

        public async Task SiteMods(LemmyContext lemmyDb, HexbearContext hexbearDb)
        {
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Migrate Sitemods: Begin");
            var sitemods = hexbearDb.Users.Where(x => x.Sitemod).ToList();
            foreach (var mod in sitemods)
            {
                var person = lemmyDb.People.First(x => x.Id == mod.Id);
                person.Admin = true;
            }

            await lemmyDb.SaveChangesAsync();
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Migrate Sitemods: End");
        }

        public async Task FeaturedPosts(LemmyContext lemmyDb, HexbearContext hexbearDb)
        {
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Migrate Featured Posts: Begin");
            await lemmyDb.Database.ExecuteSqlRawAsync($"Update public.Post set featured_community = false");
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Migrate Featured Posts: End");
        }

        public async Task DataFixes(LemmyContext lemmyDb, HexbearContext hexbearDb)
        {
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Migrate DataFixes: Begin");
            await lemmyDb.Database.ExecuteSqlRawAsync($"Update public.post set ap_id = 'https://www.hexbear.net/post/154476' where id = 154476");
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Migrate DataFixes: End");
        }

        private void ApplySchema() {
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Migrate Schema: Begin");
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.RedirectStandardError = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.OutputDataReceived += (sender, e) => {
                Console.WriteLine(e.Data);
                if (e?.Data == null)
                    return;
                if (e.Data.Contains("Rolling back"))
                    _migrate_finished = true;
            };
            cmd.ErrorDataReceived += (sender, e) => { Console.WriteLine(e.Data); };
            cmd.BeginOutputReadLine();
            cmd.BeginErrorReadLine();

            cmd.StandardInput.WriteLine($"cd {Environment.CurrentDirectory}\\diesel\\hexbear");
            cmd.StandardInput.Flush();
            for (int i = 0; i < 31; i++) // Undo 31 migrations, get us back to where we forked (add_post_title_to_comments_view)
            {
                cmd.StandardInput.WriteLine($"diesel migration revert --database-url postgres://{Program._appSettings.LemmyUsername}:{Program._appSettings.LemmyPassword}@{Program._appSettings.LemmyHost}:{Program._appSettings.LemmyPort}/{Program._appSettings.LemmyDatabaseName}");
                cmd.StandardInput.Flush();
                while (!_migrate_finished) {
                    Thread.Sleep(500);
                    cmd.StandardInput.Flush();
                }
                _migrate_finished = false;
            }

            cmd.StandardInput.WriteLine($"cd {Environment.CurrentDirectory}\\diesel\\lemmy");
            cmd.StandardInput.Flush();
            cmd.StandardInput.WriteLine($"diesel migration run --database-url postgres://{Program._appSettings.LemmyUsername}:{Program._appSettings.LemmyPassword}@{Program._appSettings.LemmyHost}:{Program._appSettings.LemmyPort}/{Program._appSettings.LemmyDatabaseName}");
            cmd.StandardInput.Flush();

            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Migrate Schema: End");
        }

        private void ConvertSvg(string fileName) {
            var svgDocument = SvgDocument.Open($"emojis/{fileName}.svg");
            var bitmap = svgDocument.Draw();
            bitmap.Save($"emojis/{fileName}.png", ImageFormat.Png);
        }
    }

    public class EmojiCategory {
        public string key { get; set; }
        public string name { get; set; }
        public List<string> emojis { get; set; }
    }

    public class PictRsResponse {
        public List<File> files { get; set; }

        public class File {
            public string file { get; set; }
        }
    }

    public class UserTagJSON {
        public string pronouns { get; set; }
    }
}