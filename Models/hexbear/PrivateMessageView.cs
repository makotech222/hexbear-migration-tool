using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.hexbear
{
    public partial class PrivateMessageView
    {
        public int? Id { get; set; }
        public int? CreatorId { get; set; }
        public int? RecipientId { get; set; }
        public string Content { get; set; }
        public bool? Deleted { get; set; }
        public bool? Read { get; set; }
        public DateTime? Published { get; set; }
        public DateTime? Updated { get; set; }
        public string ApId { get; set; }
        public bool? Local { get; set; }
        public string CreatorName { get; set; }
        public string CreatorPreferredUsername { get; set; }
        public string CreatorAvatar { get; set; }
        public string CreatorActorId { get; set; }
        public bool? CreatorLocal { get; set; }
        public string RecipientName { get; set; }
        public string RecipientPreferredUsername { get; set; }
        public string RecipientAvatar { get; set; }
        public string RecipientActorId { get; set; }
        public bool? RecipientLocal { get; set; }
    }
}
