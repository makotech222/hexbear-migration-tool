using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.lemmy;

public partial class ModAddCommunity
{
    public int Id { get; set; }

    public int ModPersonId { get; set; }

    public int OtherPersonId { get; set; }

    public int CommunityId { get; set; }

    public bool? Removed { get; set; }

    public DateTime When { get; set; }

    public virtual Community Community { get; set; }

    public virtual Person ModPerson { get; set; }

    public virtual Person OtherPerson { get; set; }
}
