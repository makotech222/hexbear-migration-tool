using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.hexbear
{
    public partial class ModRemoveCommunity
    {
        public int Id { get; set; }
        public int ModUserId { get; set; }
        public int CommunityId { get; set; }
        public string Reason { get; set; }
        public bool? Removed { get; set; }
        public DateTime? Expires { get; set; }
        public DateTime When { get; set; }

        public virtual Community Community { get; set; } = null;
        public virtual User ModUser { get; set; } = null;
    }
}
