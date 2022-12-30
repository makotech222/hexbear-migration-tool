using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.hexbear
{
    public partial class CommunitySetting
    {
        public int Id { get; set; }
        public bool ReadOnly { get; set; }
        public bool Private { get; set; }
        public bool PostLinks { get; set; }
        public int CommentImages { get; set; }
        public DateTime Published { get; set; }
        public bool? AllowAsDefault { get; set; }
        public bool HideFromAll { get; set; }

        public virtual Community IdNavigation { get; set; } = null;
    }
}
