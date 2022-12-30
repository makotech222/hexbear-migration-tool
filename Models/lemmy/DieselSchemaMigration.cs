using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.lemmy;

public partial class DieselSchemaMigration
{
    public string Version { get; set; }

    public DateTime RunOn { get; set; }
}
