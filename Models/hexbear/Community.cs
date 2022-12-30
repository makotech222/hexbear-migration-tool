using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.hexbear
{
    public partial class Community
    {
        public Community()
        {
            CommunityFollowers = new HashSet<CommunityFollower>();
            CommunityModerators = new HashSet<CommunityModerator>();
            CommunityUserBans = new HashSet<CommunityUserBan>();
            CommunityUserTags = new HashSet<CommunityUserTag>();
            ModAddCommunities = new HashSet<ModAddCommunity>();
            ModBanFromCommunities = new HashSet<ModBanFromCommunity>();
            ModRemoveCommunities = new HashSet<ModRemoveCommunity>();
            Posts = new HashSet<Post>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null;
        public string Title { get; set; } = null;
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int CreatorId { get; set; }
        public bool Removed { get; set; }
        public DateTime Published { get; set; }
        public DateTime? Updated { get; set; }
        public bool Deleted { get; set; }
        public bool Nsfw { get; set; }
        public string ActorId { get; set; } = null;
        public bool? Local { get; set; }
        public string PrivateKey { get; set; }
        public string PublicKey { get; set; }
        public DateTime LastRefreshedAt { get; set; }
        public string Icon { get; set; }
        public string Banner { get; set; }

        public virtual Category Category { get; set; } = null;
        public virtual User Creator { get; set; } = null;
        public virtual CommunitySetting CommunitySetting { get; set; }
        public virtual CommunityStat CommunityStat { get; set; }
        public virtual ICollection<CommunityFollower> CommunityFollowers { get; set; }
        public virtual ICollection<CommunityModerator> CommunityModerators { get; set; }
        public virtual ICollection<CommunityUserBan> CommunityUserBans { get; set; }
        public virtual ICollection<CommunityUserTag> CommunityUserTags { get; set; }
        public virtual ICollection<ModAddCommunity> ModAddCommunities { get; set; }
        public virtual ICollection<ModBanFromCommunity> ModBanFromCommunities { get; set; }
        public virtual ICollection<ModRemoveCommunity> ModRemoveCommunities { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
