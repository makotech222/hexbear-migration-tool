using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.hexbear
{
    public partial class CommunityModerator
    {
        public int Id { get; set; }
        public int CommunityId { get; set; }
        public int UserId { get; set; }
        public DateTime Published { get; set; }

        public virtual Community Community { get; set; } = null;
        public virtual User User { get; set; } = null;
    }
}
