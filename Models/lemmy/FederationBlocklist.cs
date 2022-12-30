using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.lemmy;

public partial class FederationBlocklist
{
    public int Id { get; set; }

    public int InstanceId { get; set; }

    public DateTime Published { get; set; }

    public DateTime? Updated { get; set; }

    public virtual Instance Instance { get; set; }
}
