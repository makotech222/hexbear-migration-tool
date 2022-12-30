using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.hexbear
{
    public partial class DieselSchemaMigration
    {
        public string Version { get; set; } = null;
        public DateTime RunOn { get; set; }
    }
}
