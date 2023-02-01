using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.lemmy;

public partial class Person
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string DisplayName { get; set; }

    public string Avatar { get; set; }

    public bool Banned { get; set; }

    public DateTime Published { get; set; }

    public DateTime? Updated { get; set; }

    public string ActorId { get; set; }

    public string Bio { get; set; }

    public bool? Local { get; set; }

    public string PrivateKey { get; set; }

    public string PublicKey { get; set; }

    public DateTime LastRefreshedAt { get; set; }

    public string Banner { get; set; }

    public bool Deleted { get; set; }

    public string InboxUrl { get; set; }

    public string SharedInboxUrl { get; set; }

    public string MatrixUserId { get; set; }

    public bool Admin { get; set; }

    public bool BotAccount { get; set; }

    public DateTime? BanExpires { get; set; }

    public int InstanceId { get; set; }

    public virtual ICollection<AdminPurgeComment> AdminPurgeComments { get; } = new List<AdminPurgeComment>();

    public virtual ICollection<AdminPurgeCommunity> AdminPurgeCommunities { get; } = new List<AdminPurgeCommunity>();

    public virtual ICollection<AdminPurgePerson> AdminPurgePeople { get; } = new List<AdminPurgePerson>();

    public virtual ICollection<AdminPurgePost> AdminPurgePosts { get; } = new List<AdminPurgePost>();

    public virtual ICollection<CommentLike> CommentLikes { get; } = new List<CommentLike>();

    public virtual ICollection<CommentReply> CommentReplies { get; } = new List<CommentReply>();

    public virtual ICollection<CommentReport> CommentReportCreators { get; } = new List<CommentReport>();

    public virtual ICollection<CommentReport> CommentReportResolvers { get; } = new List<CommentReport>();

    public virtual ICollection<CommentSaved> CommentSaveds { get; } = new List<CommentSaved>();

    public virtual ICollection<CommunityBlock> CommunityBlocks { get; } = new List<CommunityBlock>();

    public virtual ICollection<CommunityFollower> CommunityFollowers { get; } = new List<CommunityFollower>();

    public virtual ICollection<CommunityModerator> CommunityModerators { get; } = new List<CommunityModerator>();

    public virtual ICollection<CommunityPersonBan> CommunityPersonBans { get; } = new List<CommunityPersonBan>();

    public virtual Instance Instance { get; set; }

    public virtual LocalUser LocalUser { get; set; }

    public virtual ICollection<ModAddCommunity> ModAddCommunityModPeople { get; } = new List<ModAddCommunity>();

    public virtual ICollection<ModAddCommunity> ModAddCommunityOtherPeople { get; } = new List<ModAddCommunity>();

    public virtual ICollection<ModAdd> ModAddModPeople { get; } = new List<ModAdd>();

    public virtual ICollection<ModAdd> ModAddOtherPeople { get; } = new List<ModAdd>();

    public virtual ICollection<ModBanFromCommunity> ModBanFromCommunityModPeople { get; } = new List<ModBanFromCommunity>();

    public virtual ICollection<ModBanFromCommunity> ModBanFromCommunityOtherPeople { get; } = new List<ModBanFromCommunity>();

    public virtual ICollection<ModBan> ModBanModPeople { get; } = new List<ModBan>();

    public virtual ICollection<ModBan> ModBanOtherPeople { get; } = new List<ModBan>();

    public virtual ICollection<ModFeaturePost> ModFeaturePosts { get; } = new List<ModFeaturePost>();

    public virtual ICollection<ModHideCommunity> ModHideCommunities { get; } = new List<ModHideCommunity>();

    public virtual ICollection<ModLockPost> ModLockPosts { get; } = new List<ModLockPost>();

    public virtual ICollection<ModRemoveComment> ModRemoveComments { get; } = new List<ModRemoveComment>();

    public virtual ICollection<ModRemoveCommunity> ModRemoveCommunities { get; } = new List<ModRemoveCommunity>();

    public virtual ICollection<ModRemovePost> ModRemovePosts { get; } = new List<ModRemovePost>();

    public virtual ICollection<ModTransferCommunity> ModTransferCommunityModPeople { get; } = new List<ModTransferCommunity>();

    public virtual ICollection<ModTransferCommunity> ModTransferCommunityOtherPeople { get; } = new List<ModTransferCommunity>();

    public virtual PersonAggregate PersonAggregate { get; set; }

    public virtual PersonBan PersonBan { get; set; }

    public virtual ICollection<PersonBlock> PersonBlockPeople { get; } = new List<PersonBlock>();

    public virtual ICollection<PersonBlock> PersonBlockTargets { get; } = new List<PersonBlock>();

    public virtual ICollection<PersonFollower> PersonFollowerFollowers { get; } = new List<PersonFollower>();

    public virtual ICollection<PersonFollower> PersonFollowerPeople { get; } = new List<PersonFollower>();

    public virtual ICollection<PersonMention> PersonMentions { get; } = new List<PersonMention>();

    public virtual ICollection<PersonPostAggregate> PersonPostAggregates { get; } = new List<PersonPostAggregate>();

    public virtual ICollection<PostLike> PostLikes { get; } = new List<PostLike>();

    public virtual ICollection<PostRead> PostReads { get; } = new List<PostRead>();

    public virtual ICollection<PostReport> PostReportCreators { get; } = new List<PostReport>();

    public virtual ICollection<PostReport> PostReportResolvers { get; } = new List<PostReport>();

    public virtual ICollection<PostSaved> PostSaveds { get; } = new List<PostSaved>();

    public virtual ICollection<Post> Posts { get; } = new List<Post>();

    public virtual ICollection<PrivateMessage> PrivateMessageCreators { get; } = new List<PrivateMessage>();

    public virtual ICollection<PrivateMessage> PrivateMessageRecipients { get; } = new List<PrivateMessage>();

    public virtual ICollection<PrivateMessageReport> PrivateMessageReportCreators { get; } = new List<PrivateMessageReport>();

    public virtual ICollection<PrivateMessageReport> PrivateMessageReportResolvers { get; } = new List<PrivateMessageReport>();

    public virtual ICollection<RegistrationApplication> RegistrationApplications { get; } = new List<RegistrationApplication>();
}
