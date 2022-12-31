using hexbear_migration_tool.hexbear;
using hexbear_migration_tool.lemmy;
using hexbear_migration_tool.Models.lemmy;
using Microsoft.EntityFrameworkCore;
using Svg;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Text.Json;

namespace hexbear_migration_tool
{
    internal class Migration
    {
        public Migration()
        { }

        public async Task Start()
        {
            var hexbearDb = new HexbearContext();
            var lemmyDb = new LemmyContext();
            var trans = lemmyDb.Database.BeginTransaction();
            this.ApplySchema();
            await Taglines(lemmyDb);
            await Emojis(lemmyDb);
            await CommunitySettings(lemmyDb, hexbearDb);
            trans.Commit();
        }

        public async Task Taglines(LemmyContext lemmyDb)
        {
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Migrate Taglines: Begin");
            await lemmyDb.Taglines.ExecuteDeleteAsync();
            var taglines = JsonSerializer.Deserialize<List<string>>(File.ReadAllText("taglines.json"));
            var localSiteId = (await lemmyDb.LocalSites.FirstAsync()).Id;
            var lemmyTaglines = taglines.Select(x => new Models.lemmy.Tagline()
            {
                LocalSiteId = localSiteId,
                Content = x,
            }).ToList();
            await lemmyDb.Taglines.AddRangeAsync(lemmyTaglines);
            await lemmyDb.SaveChangesAsync();
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Migrate Taglines: End");
        }

        public async Task Emojis(LemmyContext lemmyDb)
        {
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Migrate Emojis: Begin");
            await lemmyDb.CustomEmojis.ExecuteDeleteAsync();
            await lemmyDb.CustomEmojiKeywords.ExecuteDeleteAsync();

            var blacklistedGifs = new List<string>() { "lea-bounce.gif", "congratulations.gif", "wall-talk.gif", "spongebob-party.gif", "blob-on-fire.gif" };
            var httpClient = new HttpClient();
            var localSiteId = (await lemmyDb.LocalSites.FirstAsync()).Id;
            var emojiCategories = JsonSerializer.Deserialize<List<EmojiCategory>>(File.ReadAllText("emojis.json"));
            var alreadySeens = new HashSet<string>();
            foreach (var category in emojiCategories)
            {
                foreach (var emoji in category.emojis)
                {
                    if (alreadySeens.Contains(emoji))
                        continue;
                    alreadySeens.Add(emoji);
                    string name = emoji.Split(".")[0];
                    string path = emoji;
                    if (emoji.EndsWith("svg"))
                    {
                        ConvertSvg(name);
                        path = name + ".png";
                    }
                    if (blacklistedGifs.Contains(emoji))
                    {
                        path = "blank.png";
                    }
                    using var stream = System.IO.File.OpenRead($"emojis/{path}");
                    using var content = new MultipartFormDataContent
                    {
                        { new StreamContent(stream), "images[]", path }
                    };
                    var res = await httpClient.PostAsync($"{Program._pictrs_url}/image", content);
                    string response = await res.Content.ReadAsStringAsync();
                    try
                    {
                        var link = JsonSerializer.Deserialize<PictRsResponse>(response)?.files.First().file;
                        var customEmoji = new CustomEmoji()
                        {
                            LocalSiteId = localSiteId,
                            Category = category.name,
                            AltText = name,
                            ImageUrl = $"/pictrs/image/{link}",
                            Shortcode = name,
                        };
                        lemmyDb.CustomEmojis.Add(customEmoji);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(emoji);
                    }
                }
            }
            await lemmyDb.SaveChangesAsync();
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Migrate Emojis: End");
        }

        public async Task CommunitySettings(LemmyContext lemmyDb, HexbearContext hexbearDb)
        {
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Migrate Community Settings: Begin");
            var communitySettings = hexbearDb.CommunitySettings.ToList();
            foreach (var setting in communitySettings)
            {
                var lemmyCommunity = await lemmyDb.Communities.FindAsync(setting.Id);
                lemmyCommunity.Hidden = setting.HideFromAll;
                lemmyCommunity.PostingRestrictedToMods = setting.ReadOnly;
            }

            await lemmyDb.SaveChangesAsync();
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Migrate Community Settings: End");
        }

        public async Task Pronouns(LemmyContext lemmyDb, HexbearContext hexbearDb)
        {
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Migrate Pronouns: Begin");
            var usertags = hexbearDb.UserTags.ToList();
            foreach (var tag in usertags)
            {
                var pronouns = JsonSerializer.Deserialize<UserTagJSON>(tag.Tags)?.pronouns?.Split(",");
                
            }
            await lemmyDb.SaveChangesAsync();
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Migrate Pronouns: End");
        }

        private void ApplySchema()
        {
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Migrate Schema: Begin");
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.RedirectStandardError = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.OutputDataReceived += (sender, e) => { Console.WriteLine(e.Data); };
            cmd.ErrorDataReceived += (sender, e) => { Console.WriteLine(e.Data); };
            cmd.BeginOutputReadLine();
            cmd.BeginErrorReadLine();

            cmd.StandardInput.WriteLine($"cd {Environment.CurrentDirectory}\\diesel\\hexbear");
            cmd.StandardInput.Flush();
            for (int i = 0; i < 31; i++) // Undo 31 migrations, get us back to where we forked
            {
                cmd.StandardInput.WriteLine($"diesel migration revert --database-url postgres://{Program._hexbearDatabase.User}:{Program._hexbearDatabase.Password}@{Program._hexbearDatabase.Host}:{Program._hexbearDatabase.Port}/{Program._hexbearDatabase.Database}");
                cmd.StandardInput.Flush();
                Thread.Sleep(500);
            }

            cmd.StandardInput.WriteLine($"cd {Environment.CurrentDirectory}\\diesel\\lemmy");
            cmd.StandardInput.Flush();
            cmd.StandardInput.WriteLine($"diesel migration run --database-url postgres://{Program._hexbearDatabase.User}:{Program._hexbearDatabase.Password}@{Program._hexbearDatabase.Host}:{Program._hexbearDatabase.Port}/{Program._hexbearDatabase.Database}");
            cmd.StandardInput.Flush();

            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Migrate Schema: End");
        }

        private void ConvertSvg(string fileName)
        {
            var svgDocument = SvgDocument.Open($"emojis/{fileName}.svg");
            var bitmap = svgDocument.Draw();
            bitmap.Save($"emojis/{fileName}.png", ImageFormat.Png);
        }
    }

    public class EmojiCategory
    {
        public string key { get; set; }
        public string name { get; set; }
        public List<string> emojis { get; set; }
    }

    public class PictRsResponse
    {
        public List<File> files { get; set; }

        public class File
        {
            public string file { get; set; }
        }
    }

    public class UserTagJSON
    {
        public string pronouns { get; set; }
    }
}