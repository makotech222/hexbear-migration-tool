using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.hexbear
{
    public partial class User
    {
        public User()
        {
            Activities = new HashSet<Activity>();
            CommentLikes = new HashSet<CommentLike>();
            CommentReports = new HashSet<CommentReport>();
            CommentSaveds = new HashSet<CommentSaved>();
            Comments = new HashSet<Comment>();
            Communities = new HashSet<Community>();
            CommunityFollowers = new HashSet<CommunityFollower>();
            CommunityModerators = new HashSet<CommunityModerator>();
            CommunityUserBans = new HashSet<CommunityUserBan>();
            ModAddCommunityModUsers = new HashSet<ModAddCommunity>();
            ModAddCommunityOtherUsers = new HashSet<ModAddCommunity>();
            ModAddModUsers = new HashSet<ModAdd>();
            ModAddOtherUsers = new HashSet<ModAdd>();
            ModBanFromCommunityModUsers = new HashSet<ModBanFromCommunity>();
            ModBanFromCommunityOtherUsers = new HashSet<ModBanFromCommunity>();
            ModBanModUsers = new HashSet<ModBan>();
            ModBanOtherUsers = new HashSet<ModBan>();
            ModLockPosts = new HashSet<ModLockPost>();
            ModRemoveComments = new HashSet<ModRemoveComment>();
            ModRemoveCommunities = new HashSet<ModRemoveCommunity>();
            ModRemovePosts = new HashSet<ModRemovePost>();
            ModStickyPosts = new HashSet<ModStickyPost>();
            PasswordResetRequests = new HashSet<PasswordResetRequest>();
            PostLikes = new HashSet<PostLike>();
            PostReads = new HashSet<PostRead>();
            PostReports = new HashSet<PostReport>();
            PostSaveds = new HashSet<PostSaved>();
            Posts = new HashSet<Post>();
            PrivateMessageCreators = new HashSet<PrivateMessage>();
            PrivateMessageRecipients = new HashSet<PrivateMessage>();
            Sites = new HashSet<Site>();
            UserMentions = new HashSet<UserMention>();
            UserTokens = new HashSet<UserToken>();
            Bids = new HashSet<BanId>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null;
        public string PreferredUsername { get; set; }
        public string PasswordEncrypted { get; set; } = null;
        public string Email { get; set; }
        public string Avatar { get; set; }
        public bool Admin { get; set; }
        public bool Banned { get; set; }
        public DateTime Published { get; set; }
        public DateTime? Updated { get; set; }
        public bool ShowNsfw { get; set; }
        public string Theme { get; set; } = null;
        public short DefaultSortType { get; set; }
        public short DefaultListingType { get; set; }
        public string Lang { get; set; } = null;
        public bool? ShowAvatars { get; set; }
        public bool SendNotificationsToEmail { get; set; }
        public string MatrixUserId { get; set; }
        public string ActorId { get; set; } = null;
        public string Bio { get; set; }
        public bool? Local { get; set; }
        public string PrivateKey { get; set; }
        public string PublicKey { get; set; }
        public DateTime LastRefreshedAt { get; set; }
        public bool Sitemod { get; set; }
        public string Banner { get; set; }
        public bool Has2fa { get; set; }
        public bool InboxDisabled { get; set; }

        public virtual CommunityUserTag CommunityUserTag { get; set; }
        public virtual UserBan UserBan { get; set; }
        public virtual UserStat UserStat { get; set; }
        public virtual UserTag UserTag { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
        public virtual ICollection<CommentLike> CommentLikes { get; set; }
        public virtual ICollection<CommentReport> CommentReports { get; set; }
        public virtual ICollection<CommentSaved> CommentSaveds { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Community> Communities { get; set; }
        public virtual ICollection<CommunityFollower> CommunityFollowers { get; set; }
        public virtual ICollection<CommunityModerator> CommunityModerators { get; set; }
        public virtual ICollection<CommunityUserBan> CommunityUserBans { get; set; }
        public virtual ICollection<ModAddCommunity> ModAddCommunityModUsers { get; set; }
        public virtual ICollection<ModAddCommunity> ModAddCommunityOtherUsers { get; set; }
        public virtual ICollection<ModAdd> ModAddModUsers { get; set; }
        public virtual ICollection<ModAdd> ModAddOtherUsers { get; set; }
        public virtual ICollection<ModBanFromCommunity> ModBanFromCommunityModUsers { get; set; }
        public virtual ICollection<ModBanFromCommunity> ModBanFromCommunityOtherUsers { get; set; }
        public virtual ICollection<ModBan> ModBanModUsers { get; set; }
        public virtual ICollection<ModBan> ModBanOtherUsers { get; set; }
        public virtual ICollection<ModLockPost> ModLockPosts { get; set; }
        public virtual ICollection<ModRemoveComment> ModRemoveComments { get; set; }
        public virtual ICollection<ModRemoveCommunity> ModRemoveCommunities { get; set; }
        public virtual ICollection<ModRemovePost> ModRemovePosts { get; set; }
        public virtual ICollection<ModStickyPost> ModStickyPosts { get; set; }
        public virtual ICollection<PasswordResetRequest> PasswordResetRequests { get; set; }
        public virtual ICollection<PostLike> PostLikes { get; set; }
        public virtual ICollection<PostRead> PostReads { get; set; }
        public virtual ICollection<PostReport> PostReports { get; set; }
        public virtual ICollection<PostSaved> PostSaveds { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<PrivateMessage> PrivateMessageCreators { get; set; }
        public virtual ICollection<PrivateMessage> PrivateMessageRecipients { get; set; }
        public virtual ICollection<Site> Sites { get; set; }
        public virtual ICollection<UserMention> UserMentions { get; set; }
        public virtual ICollection<UserToken> UserTokens { get; set; }

        public virtual ICollection<BanId> Bids { get; set; }
    }
}
