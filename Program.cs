global using System;
global using System.Collections.Generic;

namespace hexbear_migration_tool
{
    internal class Program
    {
        public static string _hexbearConnectionString = "Host=localhost:5432;Database=hexbear;Username=postgres;Password=admin";
        public static string _lemmyConnectionString = "Host=localhost;Database=hexbear-clone;Username=postgres;Password=admin";
        //public static string _lemmyConnectionString = "Host=localhost;Database=lemmy-for-hexbear;Username=lemmy;Password=password";

        public static PostgresDatabase _hexbearDatabase = new PostgresDatabase();
        public static PostgresDatabase _lemmyDatabase = new PostgresDatabase();
        public static string _pictrs_url = "http://localhost:8080";

        private static async Task Main(string[] args)
        {
            _hexbearDatabase = new PostgresDatabase()
            {
                Database = "hexbear",
                User = "postgres",
                Password = "admin"
            };
            _lemmyDatabase = new PostgresDatabase()
            {
                Database = "hexbear-clone",
                User = "postgres",
                Password = "admin"
            };
            var migration = new Migration();
            await migration.Start();
        }
    }

    public class PostgresDatabase
    {
        public string Host { get; set; } = "localhost";
        public string Port { get; set; } = "5432";
        public string Database { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
    }
}