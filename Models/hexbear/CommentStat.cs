using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.hexbear
{
    public partial class CommentStat
    {
        public int CommentId { get; set; }
        public int Score { get; set; }
        public int Upvotes { get; set; }
        public int Downvotes { get; set; }
        public int? HotRank { get; set; }
        public int? HotRankActive { get; set; }

        public virtual Comment Comment { get; set; } = null;
    }
}
