using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.lemmy;

public partial class Community
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public bool Removed { get; set; }

    public DateTime Published { get; set; }

    public DateTime? Updated { get; set; }

    public bool Deleted { get; set; }

    public bool Nsfw { get; set; }

    public string ActorId { get; set; }

    public bool? Local { get; set; }

    public string PrivateKey { get; set; }

    public string PublicKey { get; set; }

    public DateTime LastRefreshedAt { get; set; }

    public string Icon { get; set; }

    public string Banner { get; set; }

    public string FollowersUrl { get; set; }

    public string InboxUrl { get; set; }

    public string SharedInboxUrl { get; set; }

    public bool? Hidden { get; set; }

    public bool? PostingRestrictedToMods { get; set; }

    public int InstanceId { get; set; }

    public virtual ICollection<AdminPurgePost> AdminPurgePosts { get; } = new List<AdminPurgePost>();

    public virtual CommunityAggregate CommunityAggregate { get; set; }

    public virtual ICollection<CommunityBlock> CommunityBlocks { get; } = new List<CommunityBlock>();

    public virtual ICollection<CommunityFollower> CommunityFollowers { get; } = new List<CommunityFollower>();

    public virtual ICollection<CommunityLanguage> CommunityLanguages { get; } = new List<CommunityLanguage>();

    public virtual ICollection<CommunityModerator> CommunityModerators { get; } = new List<CommunityModerator>();

    public virtual ICollection<CommunityPersonBan> CommunityPersonBans { get; } = new List<CommunityPersonBan>();

    public virtual Instance Instance { get; set; }

    public virtual ICollection<ModAddCommunity> ModAddCommunities { get; } = new List<ModAddCommunity>();

    public virtual ICollection<ModBanFromCommunity> ModBanFromCommunities { get; } = new List<ModBanFromCommunity>();

    public virtual ICollection<ModHideCommunity> ModHideCommunities { get; } = new List<ModHideCommunity>();

    public virtual ICollection<ModRemoveCommunity> ModRemoveCommunities { get; } = new List<ModRemoveCommunity>();

    public virtual ICollection<ModTransferCommunity> ModTransferCommunities { get; } = new List<ModTransferCommunity>();

    public virtual ICollection<Post> Posts { get; } = new List<Post>();
}
