global using System;
global using System.Collections.Generic;
using System.Text.Json;

namespace hexbear_migration_tool
{
    internal class Program
    {
        public static string _hexbearConnectionString;
        public static string _lemmyConnectionString;

        public static AppSettings _appSettings;

        private static async Task Main(string[] args)
        {
            _appSettings = JsonSerializer.Deserialize<AppSettings>(File.ReadAllText("appsettings.json"));
            _hexbearConnectionString = $"Host={_appSettings.HexbearHost}:{_appSettings.HexbearPort};Database={_appSettings.HexbearDatabaseName};Username={_appSettings.HexbearUsername};Password={_appSettings.HexbearPassword}";
            _lemmyConnectionString = $"Host={_appSettings.LemmyHost}:{_appSettings.LemmyPort};Database={_appSettings.LemmyDatabaseName};Username={_appSettings.LemmyUsername};Password={_appSettings.LemmyPassword}";
            var migration = new Migration();
            await migration.Start();
        }
    }

    public class AppSettings
    {
        public string HexbearHost { get; set; }
        public string HexbearPort { get; set; }
        public string HexbearDatabaseName { get; set; }
        public string HexbearUsername { get; set; }
        public string HexbearPassword { get; set; }
        public string LemmyHost { get; set; }
        public string LemmyPort { get; set; }
        public string LemmyDatabaseName { get; set; }
        public string LemmyUsername { get; set; }
        public string LemmyPassword { get; set; }
        public string PictrsUrl { get; set; }
    }
}