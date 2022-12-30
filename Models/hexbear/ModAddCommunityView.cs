using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.hexbear
{
    public partial class ModAddCommunityView
    {
        public int? Id { get; set; }
        public int? ModUserId { get; set; }
        public int? OtherUserId { get; set; }
        public int? CommunityId { get; set; }
        public bool? Removed { get; set; }
        public DateTime? When { get; set; }
        public string ModUserName { get; set; }
        public string OtherUserName { get; set; }
        public string CommunityName { get; set; }
    }
}
