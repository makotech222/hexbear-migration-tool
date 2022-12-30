using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.lemmy;

public partial class DepsSavedDdl
{
    public int Id { get; set; }

    public string ViewSchema { get; set; }

    public string ViewName { get; set; }

    public string DdlToRun { get; set; }
}
