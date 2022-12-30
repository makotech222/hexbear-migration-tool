using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.hexbear
{
    public partial class CommentReport
    {
        public Guid Id { get; set; }
        public DateTime Time { get; set; }
        public string Reason { get; set; }
        public bool Resolved { get; set; }
        public int UserId { get; set; }
        public int CommentId { get; set; }
        public string CommentText { get; set; } = null;
        public DateTime CommentTime { get; set; }

        public virtual Comment Comment { get; set; } = null;
        public virtual User User { get; set; } = null;
    }
}
