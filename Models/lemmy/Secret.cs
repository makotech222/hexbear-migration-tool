using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.lemmy;

public partial class Secret
{
    public int Id { get; set; }

    public string JwtSecret { get; set; }
}
