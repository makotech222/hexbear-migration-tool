using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.hexbear
{
    public partial class CommunityFollowerView
    {
        public int? Id { get; set; }
        public int? CommunityId { get; set; }
        public int? UserId { get; set; }
        public DateTime? Published { get; set; }
        public string UserActorId { get; set; }
        public bool? UserLocal { get; set; }
        public string UserName { get; set; }
        public string UserPreferredUsername { get; set; }
        public string Avatar { get; set; }
        public string CommunityActorId { get; set; }
        public bool? CommunityLocal { get; set; }
        public string CommunityName { get; set; }
        public string CommunityIcon { get; set; }
    }
}
