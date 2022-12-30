using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.hexbear
{
    public partial class CommunityUserTag
    {
        public int UserId { get; set; }
        public int? CommunityId { get; set; }
        public string Tags { get; set; } = null;

        public virtual Community Community { get; set; }
        public virtual User User { get; set; } = null;
    }
}
