using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.lemmy;

public partial class CommunityFollower
{
    public int Id { get; set; }

    public int CommunityId { get; set; }

    public int PersonId { get; set; }

    public DateTime Published { get; set; }

    public bool Pending { get; set; }

    public virtual Community Community { get; set; }

    public virtual Person Person { get; set; }
}
