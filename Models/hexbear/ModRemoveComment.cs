using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.hexbear
{
    public partial class ModRemoveComment
    {
        public int Id { get; set; }
        public int ModUserId { get; set; }
        public int CommentId { get; set; }
        public string Reason { get; set; }
        public bool? Removed { get; set; }
        public DateTime When { get; set; }

        public virtual Comment Comment { get; set; } = null;
        public virtual User ModUser { get; set; } = null;
    }
}
