using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.hexbear
{
    public partial class ModBanFromCommunity
    {
        public int Id { get; set; }
        public int ModUserId { get; set; }
        public int OtherUserId { get; set; }
        public int CommunityId { get; set; }
        public string Reason { get; set; }
        public bool? Banned { get; set; }
        public DateTime? Expires { get; set; }
        public DateTime When { get; set; }

        public virtual Community Community { get; set; } = null;
        public virtual User ModUser { get; set; } = null;
        public virtual User OtherUser { get; set; } = null;
    }
}
