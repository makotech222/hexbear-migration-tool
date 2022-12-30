using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.lemmy;

public partial class Tagline
{
    public int Id { get; set; }

    public int LocalSiteId { get; set; }

    public string Content { get; set; }

    public DateTime Published { get; set; }

    public DateTime? Updated { get; set; }

    public virtual LocalSite LocalSite { get; set; }
}
