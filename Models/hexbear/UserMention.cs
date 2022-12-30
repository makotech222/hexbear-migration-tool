using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.hexbear
{
    public partial class UserMention
    {
        public int Id { get; set; }
        public int RecipientId { get; set; }
        public int CommentId { get; set; }
        public bool Read { get; set; }
        public DateTime Published { get; set; }

        public virtual Comment Comment { get; set; } = null;
        public virtual User Recipient { get; set; } = null;
    }
}
