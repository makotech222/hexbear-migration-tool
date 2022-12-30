using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.hexbear
{
    public partial class CommunityAggregatesFast
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public string Banner { get; set; }
        public string Description { get; set; }
        public int? CategoryId { get; set; }
        public int? CreatorId { get; set; }
        public bool? Removed { get; set; }
        public DateTime? Published { get; set; }
        public DateTime? Updated { get; set; }
        public bool? Deleted { get; set; }
        public bool? Nsfw { get; set; }
        public string ActorId { get; set; }
        public bool? Local { get; set; }
        public DateTime? LastRefreshedAt { get; set; }
        public string CreatorActorId { get; set; }
        public bool? CreatorLocal { get; set; }
        public string CreatorName { get; set; }
        public string CreatorPreferredUsername { get; set; }
        public string CreatorAvatar { get; set; }
        public string CategoryName { get; set; }
        public long? NumberOfSubscribers { get; set; }
        public long? NumberOfPosts { get; set; }
        public long? NumberOfComments { get; set; }
        public int? HotRank { get; set; }
    }
}
