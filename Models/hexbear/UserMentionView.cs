using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.hexbear
{
    public partial class UserMentionView
    {
        public int? Id { get; set; }
        public int? UserMentionId { get; set; }
        public int? CreatorId { get; set; }
        public string CreatorActorId { get; set; }
        public bool? CreatorLocal { get; set; }
        public int? PostId { get; set; }
        public string PostName { get; set; }
        public int? ParentId { get; set; }
        public string Content { get; set; }
        public bool? Removed { get; set; }
        public bool? Read { get; set; }
        public DateTime? Published { get; set; }
        public DateTime? Updated { get; set; }
        public bool? Deleted { get; set; }
        public int? CommunityId { get; set; }
        public string CommunityActorId { get; set; }
        public bool? CommunityLocal { get; set; }
        public string CommunityName { get; set; }
        public string CommunityIcon { get; set; }
        public bool? Banned { get; set; }
        public bool? BannedFromCommunity { get; set; }
        public string CreatorName { get; set; }
        public string CreatorPreferredUsername { get; set; }
        public string CreatorAvatar { get; set; }
        public long? Score { get; set; }
        public long? Upvotes { get; set; }
        public long? Downvotes { get; set; }
        public int? HotRank { get; set; }
        public int? HotRankActive { get; set; }
        public int? UserId { get; set; }
        public int? MyVote { get; set; }
        public bool? Saved { get; set; }
        public int? RecipientId { get; set; }
        public string RecipientActorId { get; set; }
        public bool? RecipientLocal { get; set; }
    }
}
