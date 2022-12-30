using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.hexbear
{
    public partial class PostStat
    {
        public int PostId { get; set; }
        public int NumberOfComments { get; set; }
        public int Score { get; set; }
        public int Upvotes { get; set; }
        public int Downvotes { get; set; }
        public int? HotRank { get; set; }
        public int? HotRankActive { get; set; }
        public DateTime NewestActivityTime { get; set; }

        public virtual Post Post { get; set; } = null;
    }
}
