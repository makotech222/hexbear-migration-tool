using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.hexbear
{
    public partial class PrivateMessage
    {
        public int Id { get; set; }
        public int CreatorId { get; set; }
        public int RecipientId { get; set; }
        public string Content { get; set; } = null;
        public bool Deleted { get; set; }
        public bool Read { get; set; }
        public DateTime Published { get; set; }
        public DateTime? Updated { get; set; }
        public string ApId { get; set; } = null;
        public bool? Local { get; set; }

        public virtual User Creator { get; set; } = null;
        public virtual User Recipient { get; set; } = null;
    }
}
