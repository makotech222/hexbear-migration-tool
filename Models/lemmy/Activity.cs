using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.lemmy;

public partial class Activity
{
    public int Id { get; set; }

    public string Data { get; set; }

    public bool? Local { get; set; }

    public DateTime Published { get; set; }

    public DateTime? Updated { get; set; }

    public string ApId { get; set; }

    public bool? Sensitive { get; set; }
}
