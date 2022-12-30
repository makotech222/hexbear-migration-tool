using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.hexbear
{
    public partial class PostFastView
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Body { get; set; }
        public int? CreatorId { get; set; }
        public int? CommunityId { get; set; }
        public bool? Removed { get; set; }
        public bool? Locked { get; set; }
        public DateTime? Published { get; set; }
        public DateTime? Updated { get; set; }
        public bool? Deleted { get; set; }
        public bool? Nsfw { get; set; }
        public bool? Stickied { get; set; }
        public bool? Featured { get; set; }
        public string EmbedTitle { get; set; }
        public string EmbedDescription { get; set; }
        public string EmbedHtml { get; set; }
        public string ThumbnailUrl { get; set; }
        public string ApId { get; set; }
        public bool? Local { get; set; }
        public string CreatorActorId { get; set; }
        public bool? CreatorLocal { get; set; }
        public string CreatorName { get; set; }
        public string CreatorPreferredUsername { get; set; }
        public DateTime? CreatorPublished { get; set; }
        public string CreatorAvatar { get; set; }
        public string CreatorTags { get; set; }
        public string CreatorCommunityTags { get; set; }
        public bool? Banned { get; set; }
        public bool? BannedFromCommunity { get; set; }
        public string CommunityActorId { get; set; }
        public bool? CommunityLocal { get; set; }
        public string CommunityName { get; set; }
        public string CommunityIcon { get; set; }
        public bool? CommunityRemoved { get; set; }
        public bool? CommunityDeleted { get; set; }
        public bool? CommunityNsfw { get; set; }
        public bool? CommunityHideFromAll { get; set; }
        public long? NumberOfComments { get; set; }
        public long? Score { get; set; }
        public long? Upvotes { get; set; }
        public long? Downvotes { get; set; }
        public int? HotRank { get; set; }
        public int? HotRankActive { get; set; }
        public DateTime? NewestActivityTime { get; set; }
        public int? UserId { get; set; }
        public int? MyVote { get; set; }
        public bool? Subscribed { get; set; }
        public bool? Read { get; set; }
        public bool? Saved { get; set; }
    }
}
