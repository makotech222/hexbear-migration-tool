using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.hexbear
{
    public partial class CommentLike
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CommentId { get; set; }
        public int PostId { get; set; }
        public short Score { get; set; }
        public DateTime Published { get; set; }

        public virtual Comment Comment { get; set; } = null;
        public virtual Post Post { get; set; } = null;
        public virtual User User { get; set; } = null;
    }
}
