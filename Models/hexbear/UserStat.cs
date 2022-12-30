using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.hexbear
{
    public partial class UserStat
    {
        public int UserId { get; set; }
        public int NumberOfComments { get; set; }
        public int NumberOfPosts { get; set; }
        public int PostScore { get; set; }
        public int CommentScore { get; set; }

        public virtual User User { get; set; } = null;
    }
}
