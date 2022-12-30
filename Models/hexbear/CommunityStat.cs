using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.hexbear
{
    public partial class CommunityStat
    {
        public int CommunityId { get; set; }
        public int NumberOfSubscribers { get; set; }
        public int NumberOfPosts { get; set; }
        public int NumberOfComments { get; set; }
        public int? HotRank { get; set; }

        public virtual Community Community { get; set; } = null;
    }
}
