using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using hexbear_migration_tool.Models.hexbear;

namespace hexbear_migration_tool.hexbear
{
    public partial class HexbearContext : DbContext
    {
        public HexbearContext()
        {
        }

        public HexbearContext(DbContextOptions<HexbearContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Activity> Activities { get; set; } = null;
        public virtual DbSet<BanId> BanIds { get; set; } = null;
        public virtual DbSet<Category> Categories { get; set; } = null;
        public virtual DbSet<Comment> Comments { get; set; } = null;
        public virtual DbSet<CommentAggregatesFast> CommentAggregatesFasts { get; set; } = null;
        public virtual DbSet<CommentAggregatesView> CommentAggregatesViews { get; set; } = null;
        public virtual DbSet<CommentFastView> CommentFastViews { get; set; } = null;
        public virtual DbSet<CommentFastView1> CommentFastViews1 { get; set; } = null;
        public virtual DbSet<CommentLike> CommentLikes { get; set; } = null;
        public virtual DbSet<CommentReport> CommentReports { get; set; } = null;
        public virtual DbSet<CommentReportView> CommentReportViews { get; set; } = null;
        public virtual DbSet<CommentSaved> CommentSaveds { get; set; } = null;
        public virtual DbSet<CommentStat> CommentStats { get; set; } = null;
        public virtual DbSet<CommentView> CommentViews { get; set; } = null;
        public virtual DbSet<Community> Communities { get; set; } = null;
        public virtual DbSet<CommunityAggregatesFast> CommunityAggregatesFasts { get; set; } = null;
        public virtual DbSet<CommunityAggregatesView> CommunityAggregatesViews { get; set; } = null;
        public virtual DbSet<CommunityFastView> CommunityFastViews { get; set; } = null;
        public virtual DbSet<CommunityFastView1> CommunityFastViews1 { get; set; } = null;
        public virtual DbSet<CommunityFollower> CommunityFollowers { get; set; } = null;
        public virtual DbSet<CommunityFollowerView> CommunityFollowerViews { get; set; } = null;
        public virtual DbSet<CommunityModerator> CommunityModerators { get; set; } = null;
        public virtual DbSet<CommunityModeratorView> CommunityModeratorViews { get; set; } = null;
        public virtual DbSet<CommunitySetting> CommunitySettings { get; set; } = null;
        public virtual DbSet<CommunityStat> CommunityStats { get; set; } = null;
        public virtual DbSet<CommunityUserBan> CommunityUserBans { get; set; } = null;
        public virtual DbSet<CommunityUserBanView> CommunityUserBanViews { get; set; } = null;
        public virtual DbSet<CommunityUserTag> CommunityUserTags { get; set; } = null;
        public virtual DbSet<CommunityView> CommunityViews { get; set; } = null;
        public virtual DbSet<DepsSavedDdl> DepsSavedDdls { get; set; } = null;
        public virtual DbSet<DieselSchemaMigration> DieselSchemaMigrations { get; set; } = null;
        public virtual DbSet<ModAdd> ModAdds { get; set; } = null;
        public virtual DbSet<ModAddCommunity> ModAddCommunities { get; set; } = null;
        public virtual DbSet<ModAddCommunityView> ModAddCommunityViews { get; set; } = null;
        public virtual DbSet<ModAddView> ModAddViews { get; set; } = null;
        public virtual DbSet<ModBan> ModBans { get; set; } = null;
        public virtual DbSet<ModBanFromCommunity> ModBanFromCommunities { get; set; } = null;
        public virtual DbSet<ModBanFromCommunityView> ModBanFromCommunityViews { get; set; } = null;
        public virtual DbSet<ModBanView> ModBanViews { get; set; } = null;
        public virtual DbSet<ModLockPost> ModLockPosts { get; set; } = null;
        public virtual DbSet<ModLockPostView> ModLockPostViews { get; set; } = null;
        public virtual DbSet<ModLockPostView1> ModLockPostViews1 { get; set; } = null;
        public virtual DbSet<ModRemoveComment> ModRemoveComments { get; set; } = null;
        public virtual DbSet<ModRemoveCommentView> ModRemoveCommentViews { get; set; } = null;
        public virtual DbSet<ModRemoveCommunity> ModRemoveCommunities { get; set; } = null;
        public virtual DbSet<ModRemoveCommunityView> ModRemoveCommunityViews { get; set; } = null;
        public virtual DbSet<ModRemovePost> ModRemovePosts { get; set; } = null;
        public virtual DbSet<ModRemovePostView> ModRemovePostViews { get; set; } = null;
        public virtual DbSet<ModRemovePostView1> ModRemovePostViews1 { get; set; } = null;
        public virtual DbSet<ModStickyPost> ModStickyPosts { get; set; } = null;
        public virtual DbSet<ModStickyPostView> ModStickyPostViews { get; set; } = null;
        public virtual DbSet<ModStickyPostView1> ModStickyPostViews1 { get; set; } = null;
        public virtual DbSet<PasswordResetRequest> PasswordResetRequests { get; set; } = null;
        public virtual DbSet<Post> Posts { get; set; } = null;
        public virtual DbSet<PostAggregatesFast> PostAggregatesFasts { get; set; } = null;
        public virtual DbSet<PostAggregatesView> PostAggregatesViews { get; set; } = null;
        public virtual DbSet<PostFastView> PostFastViews { get; set; } = null;
        public virtual DbSet<PostFastView1> PostFastViews1 { get; set; } = null;
        public virtual DbSet<PostLike> PostLikes { get; set; } = null;
        public virtual DbSet<PostRead> PostReads { get; set; } = null;
        public virtual DbSet<PostReport> PostReports { get; set; } = null;
        public virtual DbSet<PostReportView> PostReportViews { get; set; } = null;
        public virtual DbSet<PostSaved> PostSaveds { get; set; } = null;
        public virtual DbSet<PostStat> PostStats { get; set; } = null;
        public virtual DbSet<PostView> PostViews { get; set; } = null;
        public virtual DbSet<PrivateMessage> PrivateMessages { get; set; } = null;
        public virtual DbSet<PrivateMessageView> PrivateMessageViews { get; set; } = null;
        public virtual DbSet<ReplyFastView> ReplyFastViews { get; set; } = null;
        public virtual DbSet<ReplyFastView1> ReplyFastViews1 { get; set; } = null;
        public virtual DbSet<Site> Sites { get; set; } = null;
        public virtual DbSet<SiteView> SiteViews { get; set; } = null;
        public virtual DbSet<User> Users { get; set; } = null;
        public virtual DbSet<UserBan> UserBans { get; set; } = null;
        public virtual DbSet<UserFast> UserFasts { get; set; } = null;
        public virtual DbSet<UserMention> UserMentions { get; set; } = null;
        public virtual DbSet<UserMentionFastView> UserMentionFastViews { get; set; } = null;
        public virtual DbSet<UserMentionFastView1> UserMentionFastViews1 { get; set; } = null;
        public virtual DbSet<UserMentionView> UserMentionViews { get; set; } = null;
        public virtual DbSet<UserStat> UserStats { get; set; } = null;
        public virtual DbSet<UserTag> UserTags { get; set; } = null;
        public virtual DbSet<UserToken> UserTokens { get; set; } = null;
        public virtual DbSet<UserView> UserViews { get; set; } = null;
        public virtual DbSet<UserView1> UserViews1 { get; set; } = null;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseLazyLoadingProxies();
                optionsBuilder.UseNpgsql(Program._hexbearConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("uuid-ossp");

            modelBuilder.Entity<Activity>(entity =>
            {
                entity.ToTable("activity");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data)
                    .HasColumnType("jsonb")
                    .HasColumnName("data");

                entity.Property(e => e.Local)
                    .IsRequired()
                    .HasColumnName("local")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Updated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("activity_user_id_fkey");
            });

            modelBuilder.Entity<BanId>(entity =>
            {
                entity.ToTable("ban_id", "hexbear");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.AliasedTo).HasColumnName("aliased_to");

                entity.Property(e => e.Created)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created")
                    .HasDefaultValueSql("now()");

                entity.HasOne(d => d.AliasedToNavigation)
                    .WithMany(p => p.InverseAliasedToNavigation)
                    .HasForeignKey(d => d.AliasedTo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("ban_id_aliased_to_fkey");

                entity.HasMany(d => d.Uids)
                    .WithMany(p => p.Bids)
                    .UsingEntity<Dictionary<string, object>>(
                        "UserBanId",
                        l => l.HasOne<User>().WithMany().HasForeignKey("Uid").HasConstraintName("user_ban_id_uid_fkey"),
                        r => r.HasOne<BanId>().WithMany().HasForeignKey("Bid").HasConstraintName("user_ban_id_bid_fkey"),
                        j =>
                        {
                            j.HasKey("Bid", "Uid").HasName("user_ban_id_pkey");

                            j.ToTable("user_ban_id", "hexbear");

                            j.IndexerProperty<Guid>("Bid").HasColumnName("bid");

                            j.IndexerProperty<int>("Uid").HasColumnName("uid");
                        });
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("category");

                entity.HasIndex(e => e.Name, "category_name_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.ToTable("comment");

                entity.HasIndex(e => e.ApId, "idx_comment_ap_id")
                    .IsUnique();

                entity.HasIndex(e => e.CreatorId, "idx_comment_creator");

                entity.HasIndex(e => e.ParentId, "idx_comment_parent");

                entity.HasIndex(e => e.PostId, "idx_comment_post");

                entity.HasIndex(e => e.Published, "idx_comment_published")
                    .IsDescending(true);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApId)
                    .HasMaxLength(255)
                    .HasColumnName("ap_id")
                    .HasDefaultValueSql("generate_unique_changeme()");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Local)
                    .IsRequired()
                    .HasColumnName("local")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Read).HasColumnName("read");

                entity.Property(e => e.Removed).HasColumnName("removed");

                entity.Property(e => e.Updated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated");

                entity.HasOne(d => d.Creator)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.CreatorId)
                    .HasConstraintName("comment_creator_id_fkey");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("comment_parent_id_fkey");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("comment_post_id_fkey");
            });

            modelBuilder.Entity<CommentAggregatesFast>(entity =>
            {
                entity.ToTable("comment_aggregates_fast");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ApId)
                    .HasMaxLength(255)
                    .HasColumnName("ap_id");

                entity.Property(e => e.Banned).HasColumnName("banned");

                entity.Property(e => e.BannedFromCommunity).HasColumnName("banned_from_community");

                entity.Property(e => e.CommunityActorId)
                    .HasMaxLength(255)
                    .HasColumnName("community_actor_id");

                entity.Property(e => e.CommunityIcon).HasColumnName("community_icon");

                entity.Property(e => e.CommunityId).HasColumnName("community_id");

                entity.Property(e => e.CommunityLocal).HasColumnName("community_local");

                entity.Property(e => e.CommunityName)
                    .HasMaxLength(20)
                    .HasColumnName("community_name");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.CreatorActorId)
                    .HasMaxLength(255)
                    .HasColumnName("creator_actor_id");

                entity.Property(e => e.CreatorAvatar).HasColumnName("creator_avatar");

                entity.Property(e => e.CreatorCommunityTags)
                    .HasColumnType("jsonb")
                    .HasColumnName("creator_community_tags");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.CreatorLocal).HasColumnName("creator_local");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(20)
                    .HasColumnName("creator_name");

                entity.Property(e => e.CreatorPreferredUsername)
                    .HasMaxLength(20)
                    .HasColumnName("creator_preferred_username");

                entity.Property(e => e.CreatorPublished)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("creator_published");

                entity.Property(e => e.CreatorTags)
                    .HasColumnType("jsonb")
                    .HasColumnName("creator_tags");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Downvotes).HasColumnName("downvotes");

                entity.Property(e => e.HotRank).HasColumnName("hot_rank");

                entity.Property(e => e.HotRankActive).HasColumnName("hot_rank_active");

                entity.Property(e => e.Local).HasColumnName("local");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.PostName)
                    .HasMaxLength(200)
                    .HasColumnName("post_name");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published");

                entity.Property(e => e.Read).HasColumnName("read");

                entity.Property(e => e.Removed).HasColumnName("removed");

                entity.Property(e => e.Score).HasColumnName("score");

                entity.Property(e => e.Updated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated");

                entity.Property(e => e.Upvotes).HasColumnName("upvotes");
            });

            modelBuilder.Entity<CommentAggregatesView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("comment_aggregates_view");

                entity.Property(e => e.ApId)
                    .HasMaxLength(255)
                    .HasColumnName("ap_id");

                entity.Property(e => e.Banned).HasColumnName("banned");

                entity.Property(e => e.BannedFromCommunity).HasColumnName("banned_from_community");

                entity.Property(e => e.CommunityActorId)
                    .HasMaxLength(255)
                    .HasColumnName("community_actor_id");

                entity.Property(e => e.CommunityIcon).HasColumnName("community_icon");

                entity.Property(e => e.CommunityId).HasColumnName("community_id");

                entity.Property(e => e.CommunityLocal).HasColumnName("community_local");

                entity.Property(e => e.CommunityName)
                    .HasMaxLength(20)
                    .HasColumnName("community_name");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.CreatorActorId)
                    .HasMaxLength(255)
                    .HasColumnName("creator_actor_id");

                entity.Property(e => e.CreatorAvatar).HasColumnName("creator_avatar");

                entity.Property(e => e.CreatorCommunityTags)
                    .HasColumnType("jsonb")
                    .HasColumnName("creator_community_tags");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.CreatorLocal).HasColumnName("creator_local");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(20)
                    .HasColumnName("creator_name");

                entity.Property(e => e.CreatorPreferredUsername)
                    .HasMaxLength(20)
                    .HasColumnName("creator_preferred_username");

                entity.Property(e => e.CreatorPublished)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("creator_published");

                entity.Property(e => e.CreatorTags)
                    .HasColumnType("jsonb")
                    .HasColumnName("creator_tags");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Downvotes).HasColumnName("downvotes");

                entity.Property(e => e.HotRank).HasColumnName("hot_rank");

                entity.Property(e => e.HotRankActive).HasColumnName("hot_rank_active");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Local).HasColumnName("local");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.PostName)
                    .HasMaxLength(200)
                    .HasColumnName("post_name");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published");

                entity.Property(e => e.Read).HasColumnName("read");

                entity.Property(e => e.Removed).HasColumnName("removed");

                entity.Property(e => e.Score).HasColumnName("score");

                entity.Property(e => e.Updated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated");

                entity.Property(e => e.Upvotes).HasColumnName("upvotes");
            });

            modelBuilder.Entity<CommentFastView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("comment_fast_view", "hexbear");

                entity.Property(e => e.ApId)
                    .HasMaxLength(255)
                    .HasColumnName("ap_id");

                entity.Property(e => e.Banned).HasColumnName("banned");

                entity.Property(e => e.BannedFromCommunity).HasColumnName("banned_from_community");

                entity.Property(e => e.CommunityActorId)
                    .HasMaxLength(255)
                    .HasColumnName("community_actor_id");

                entity.Property(e => e.CommunityHideFromAll).HasColumnName("community_hide_from_all");

                entity.Property(e => e.CommunityIcon).HasColumnName("community_icon");

                entity.Property(e => e.CommunityId).HasColumnName("community_id");

                entity.Property(e => e.CommunityLocal).HasColumnName("community_local");

                entity.Property(e => e.CommunityName)
                    .HasMaxLength(20)
                    .HasColumnName("community_name");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.CreatorActorId)
                    .HasMaxLength(255)
                    .HasColumnName("creator_actor_id");

                entity.Property(e => e.CreatorAvatar).HasColumnName("creator_avatar");

                entity.Property(e => e.CreatorCommunityTags)
                    .HasColumnType("jsonb")
                    .HasColumnName("creator_community_tags");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.CreatorLocal).HasColumnName("creator_local");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(20)
                    .HasColumnName("creator_name");

                entity.Property(e => e.CreatorPreferredUsername)
                    .HasMaxLength(20)
                    .HasColumnName("creator_preferred_username");

                entity.Property(e => e.CreatorPublished)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("creator_published");

                entity.Property(e => e.CreatorTags)
                    .HasColumnType("jsonb")
                    .HasColumnName("creator_tags");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Downvotes).HasColumnName("downvotes");

                entity.Property(e => e.HotRank).HasColumnName("hot_rank");

                entity.Property(e => e.HotRankActive).HasColumnName("hot_rank_active");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Local).HasColumnName("local");

                entity.Property(e => e.MyVote).HasColumnName("my_vote");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.PostName)
                    .HasMaxLength(200)
                    .HasColumnName("post_name");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published");

                entity.Property(e => e.Read).HasColumnName("read");

                entity.Property(e => e.Removed).HasColumnName("removed");

                entity.Property(e => e.Saved).HasColumnName("saved");

                entity.Property(e => e.Score).HasColumnName("score");

                entity.Property(e => e.Subscribed).HasColumnName("subscribed");

                entity.Property(e => e.Updated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated");

                entity.Property(e => e.Upvotes).HasColumnName("upvotes");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<CommentFastView1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("comment_fast_view");

                entity.Property(e => e.ApId)
                    .HasMaxLength(255)
                    .HasColumnName("ap_id");

                entity.Property(e => e.Banned).HasColumnName("banned");

                entity.Property(e => e.BannedFromCommunity).HasColumnName("banned_from_community");

                entity.Property(e => e.CommunityActorId)
                    .HasMaxLength(255)
                    .HasColumnName("community_actor_id");

                entity.Property(e => e.CommunityIcon).HasColumnName("community_icon");

                entity.Property(e => e.CommunityId).HasColumnName("community_id");

                entity.Property(e => e.CommunityLocal).HasColumnName("community_local");

                entity.Property(e => e.CommunityName)
                    .HasMaxLength(20)
                    .HasColumnName("community_name");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.CreatorActorId)
                    .HasMaxLength(255)
                    .HasColumnName("creator_actor_id");

                entity.Property(e => e.CreatorAvatar).HasColumnName("creator_avatar");

                entity.Property(e => e.CreatorCommunityTags)
                    .HasColumnType("jsonb")
                    .HasColumnName("creator_community_tags");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.CreatorLocal).HasColumnName("creator_local");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(20)
                    .HasColumnName("creator_name");

                entity.Property(e => e.CreatorPreferredUsername)
                    .HasMaxLength(20)
                    .HasColumnName("creator_preferred_username");

                entity.Property(e => e.CreatorPublished)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("creator_published");

                entity.Property(e => e.CreatorTags)
                    .HasColumnType("jsonb")
                    .HasColumnName("creator_tags");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Downvotes).HasColumnName("downvotes");

                entity.Property(e => e.HotRank).HasColumnName("hot_rank");

                entity.Property(e => e.HotRankActive).HasColumnName("hot_rank_active");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Local).HasColumnName("local");

                entity.Property(e => e.MyVote).HasColumnName("my_vote");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.PostName)
                    .HasMaxLength(200)
                    .HasColumnName("post_name");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published");

                entity.Property(e => e.Read).HasColumnName("read");

                entity.Property(e => e.Removed).HasColumnName("removed");

                entity.Property(e => e.Saved).HasColumnName("saved");

                entity.Property(e => e.Score).HasColumnName("score");

                entity.Property(e => e.Subscribed).HasColumnName("subscribed");

                entity.Property(e => e.Updated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated");

                entity.Property(e => e.Upvotes).HasColumnName("upvotes");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<CommentLike>(entity =>
            {
                entity.ToTable("comment_like");

                entity.HasIndex(e => new { e.CommentId, e.UserId }, "comment_like_comment_id_user_id_key")
                    .IsUnique();

                entity.HasIndex(e => e.CommentId, "idx_comment_like_comment");

                entity.HasIndex(e => e.PostId, "idx_comment_like_post");

                entity.HasIndex(e => e.UserId, "idx_comment_like_user");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CommentId).HasColumnName("comment_id");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Score).HasColumnName("score");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.CommentLikes)
                    .HasForeignKey(d => d.CommentId)
                    .HasConstraintName("comment_like_comment_id_fkey");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.CommentLikes)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("comment_like_post_id_fkey");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CommentLikes)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("comment_like_user_id_fkey");
            });

            modelBuilder.Entity<CommentReport>(entity =>
            {
                entity.ToTable("comment_report");

                entity.HasIndex(e => new { e.CommentId, e.UserId }, "comment_report_comment_id_user_id_key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CommentId).HasColumnName("comment_id");

                entity.Property(e => e.CommentText).HasColumnName("comment_text");

                entity.Property(e => e.CommentTime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("comment_time");

                entity.Property(e => e.Reason).HasColumnName("reason");

                entity.Property(e => e.Resolved).HasColumnName("resolved");

                entity.Property(e => e.Time)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("time")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.CommentReports)
                    .HasForeignKey(d => d.CommentId)
                    .HasConstraintName("comment_report_comment_id_fkey");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CommentReports)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("comment_report_user_id_fkey");
            });

            modelBuilder.Entity<CommentReportView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("comment_report_view");

                entity.Property(e => e.CommentId).HasColumnName("comment_id");

                entity.Property(e => e.CommentText).HasColumnName("comment_text");

                entity.Property(e => e.CommentTime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("comment_time");

                entity.Property(e => e.CommunityId).HasColumnName("community_id");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(20)
                    .HasColumnName("creator_name");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.Reason).HasColumnName("reason");

                entity.Property(e => e.Resolved).HasColumnName("resolved");

                entity.Property(e => e.Time)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("time");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .HasColumnName("user_name");
            });

            modelBuilder.Entity<CommentSaved>(entity =>
            {
                entity.ToTable("comment_saved");

                entity.HasIndex(e => new { e.CommentId, e.UserId }, "comment_saved_comment_id_user_id_key")
                    .IsUnique();

                entity.HasIndex(e => e.UserId, "idx_comment_saved_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CommentId).HasColumnName("comment_id");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.CommentSaveds)
                    .HasForeignKey(d => d.CommentId)
                    .HasConstraintName("comment_saved_comment_id_fkey");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CommentSaveds)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("comment_saved_user_id_fkey");
            });

            modelBuilder.Entity<CommentStat>(entity =>
            {
                entity.HasKey(e => e.CommentId)
                    .HasName("comment_stat_pkey");

                entity.ToTable("comment_stat", "hexbear");

                entity.Property(e => e.CommentId)
                    .ValueGeneratedNever()
                    .HasColumnName("comment_id");

                entity.Property(e => e.Downvotes).HasColumnName("downvotes");

                entity.Property(e => e.HotRank).HasColumnName("hot_rank");

                entity.Property(e => e.HotRankActive).HasColumnName("hot_rank_active");

                entity.Property(e => e.Score).HasColumnName("score");

                entity.Property(e => e.Upvotes).HasColumnName("upvotes");

                entity.HasOne(d => d.Comment)
                    .WithOne(p => p.CommentStat)
                    .HasForeignKey<CommentStat>(d => d.CommentId)
                    .HasConstraintName("comment_stat_comment_id_fkey");
            });

            modelBuilder.Entity<CommentView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("comment_view");

                entity.Property(e => e.ApId)
                    .HasMaxLength(255)
                    .HasColumnName("ap_id");

                entity.Property(e => e.Banned).HasColumnName("banned");

                entity.Property(e => e.BannedFromCommunity).HasColumnName("banned_from_community");

                entity.Property(e => e.CommunityActorId)
                    .HasMaxLength(255)
                    .HasColumnName("community_actor_id");

                entity.Property(e => e.CommunityIcon).HasColumnName("community_icon");

                entity.Property(e => e.CommunityId).HasColumnName("community_id");

                entity.Property(e => e.CommunityLocal).HasColumnName("community_local");

                entity.Property(e => e.CommunityName)
                    .HasMaxLength(20)
                    .HasColumnName("community_name");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.CreatorActorId)
                    .HasMaxLength(255)
                    .HasColumnName("creator_actor_id");

                entity.Property(e => e.CreatorAvatar).HasColumnName("creator_avatar");

                entity.Property(e => e.CreatorCommunityTags)
                    .HasColumnType("jsonb")
                    .HasColumnName("creator_community_tags");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.CreatorLocal).HasColumnName("creator_local");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(20)
                    .HasColumnName("creator_name");

                entity.Property(e => e.CreatorPreferredUsername)
                    .HasMaxLength(20)
                    .HasColumnName("creator_preferred_username");

                entity.Property(e => e.CreatorPublished)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("creator_published");

                entity.Property(e => e.CreatorTags)
                    .HasColumnType("jsonb")
                    .HasColumnName("creator_tags");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Downvotes).HasColumnName("downvotes");

                entity.Property(e => e.HotRank).HasColumnName("hot_rank");

                entity.Property(e => e.HotRankActive).HasColumnName("hot_rank_active");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Local).HasColumnName("local");

                entity.Property(e => e.MyVote).HasColumnName("my_vote");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.PostName)
                    .HasMaxLength(200)
                    .HasColumnName("post_name");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published");

                entity.Property(e => e.Read).HasColumnName("read");

                entity.Property(e => e.Removed).HasColumnName("removed");

                entity.Property(e => e.Saved).HasColumnName("saved");

                entity.Property(e => e.Score).HasColumnName("score");

                entity.Property(e => e.Subscribed).HasColumnName("subscribed");

                entity.Property(e => e.Updated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated");

                entity.Property(e => e.Upvotes).HasColumnName("upvotes");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<Community>(entity =>
            {
                entity.ToTable("community");

                entity.HasIndex(e => e.ActorId, "idx_community_actor_id")
                    .IsUnique();

                entity.HasIndex(e => e.CategoryId, "idx_community_category");

                entity.HasIndex(e => e.CreatorId, "idx_community_creator");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActorId)
                    .HasMaxLength(255)
                    .HasColumnName("actor_id")
                    .HasDefaultValueSql("generate_unique_changeme()");

                entity.Property(e => e.Banner).HasColumnName("banner");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Icon).HasColumnName("icon");

                entity.Property(e => e.LastRefreshedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_refreshed_at")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Local)
                    .IsRequired()
                    .HasColumnName("local")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .HasColumnName("name");

                entity.Property(e => e.Nsfw).HasColumnName("nsfw");

                entity.Property(e => e.PrivateKey).HasColumnName("private_key");

                entity.Property(e => e.PublicKey).HasColumnName("public_key");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Removed).HasColumnName("removed");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .HasColumnName("title");

                entity.Property(e => e.Updated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Communities)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("community_category_id_fkey");

                entity.HasOne(d => d.Creator)
                    .WithMany(p => p.Communities)
                    .HasForeignKey(d => d.CreatorId)
                    .HasConstraintName("community_creator_id_fkey");
            });

            modelBuilder.Entity<CommunityAggregatesFast>(entity =>
            {
                entity.ToTable("community_aggregates_fast");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ActorId)
                    .HasMaxLength(255)
                    .HasColumnName("actor_id");

                entity.Property(e => e.Banner).HasColumnName("banner");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(100)
                    .HasColumnName("category_name");

                entity.Property(e => e.CreatorActorId)
                    .HasMaxLength(255)
                    .HasColumnName("creator_actor_id");

                entity.Property(e => e.CreatorAvatar).HasColumnName("creator_avatar");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.CreatorLocal).HasColumnName("creator_local");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(20)
                    .HasColumnName("creator_name");

                entity.Property(e => e.CreatorPreferredUsername)
                    .HasMaxLength(20)
                    .HasColumnName("creator_preferred_username");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.HotRank).HasColumnName("hot_rank");

                entity.Property(e => e.Icon).HasColumnName("icon");

                entity.Property(e => e.LastRefreshedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_refreshed_at");

                entity.Property(e => e.Local).HasColumnName("local");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .HasColumnName("name");

                entity.Property(e => e.Nsfw).HasColumnName("nsfw");

                entity.Property(e => e.NumberOfComments).HasColumnName("number_of_comments");

                entity.Property(e => e.NumberOfPosts).HasColumnName("number_of_posts");

                entity.Property(e => e.NumberOfSubscribers).HasColumnName("number_of_subscribers");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published");

                entity.Property(e => e.Removed).HasColumnName("removed");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .HasColumnName("title");

                entity.Property(e => e.Updated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated");
            });

            modelBuilder.Entity<CommunityAggregatesView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("community_aggregates_view");

                entity.Property(e => e.ActorId)
                    .HasMaxLength(255)
                    .HasColumnName("actor_id");

                entity.Property(e => e.Banner).HasColumnName("banner");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(100)
                    .HasColumnName("category_name");

                entity.Property(e => e.CreatorActorId)
                    .HasMaxLength(255)
                    .HasColumnName("creator_actor_id");

                entity.Property(e => e.CreatorAvatar).HasColumnName("creator_avatar");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.CreatorLocal).HasColumnName("creator_local");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(20)
                    .HasColumnName("creator_name");

                entity.Property(e => e.CreatorPreferredUsername)
                    .HasMaxLength(20)
                    .HasColumnName("creator_preferred_username");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.HotRank).HasColumnName("hot_rank");

                entity.Property(e => e.Icon).HasColumnName("icon");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LastRefreshedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_refreshed_at");

                entity.Property(e => e.Local).HasColumnName("local");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .HasColumnName("name");

                entity.Property(e => e.Nsfw).HasColumnName("nsfw");

                entity.Property(e => e.NumberOfComments).HasColumnName("number_of_comments");

                entity.Property(e => e.NumberOfPosts).HasColumnName("number_of_posts");

                entity.Property(e => e.NumberOfSubscribers).HasColumnName("number_of_subscribers");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published");

                entity.Property(e => e.Removed).HasColumnName("removed");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .HasColumnName("title");

                entity.Property(e => e.Updated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated");
            });

            modelBuilder.Entity<CommunityFastView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("community_fast_view", "hexbear");

                entity.Property(e => e.ActorId)
                    .HasMaxLength(255)
                    .HasColumnName("actor_id");

                entity.Property(e => e.Banner).HasColumnName("banner");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(100)
                    .HasColumnName("category_name");

                entity.Property(e => e.CreatorActorId)
                    .HasMaxLength(255)
                    .HasColumnName("creator_actor_id");

                entity.Property(e => e.CreatorAvatar).HasColumnName("creator_avatar");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.CreatorLocal).HasColumnName("creator_local");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(20)
                    .HasColumnName("creator_name");

                entity.Property(e => e.CreatorPreferredUsername)
                    .HasMaxLength(20)
                    .HasColumnName("creator_preferred_username");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.HotRank).HasColumnName("hot_rank");

                entity.Property(e => e.Icon).HasColumnName("icon");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LastRefreshedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_refreshed_at");

                entity.Property(e => e.Local).HasColumnName("local");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .HasColumnName("name");

                entity.Property(e => e.Nsfw).HasColumnName("nsfw");

                entity.Property(e => e.NumberOfComments).HasColumnName("number_of_comments");

                entity.Property(e => e.NumberOfPosts).HasColumnName("number_of_posts");

                entity.Property(e => e.NumberOfSubscribers).HasColumnName("number_of_subscribers");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published");

                entity.Property(e => e.Removed).HasColumnName("removed");

                entity.Property(e => e.Subscribed).HasColumnName("subscribed");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .HasColumnName("title");

                entity.Property(e => e.Updated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<CommunityFastView1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("community_fast_view");

                entity.Property(e => e.ActorId)
                    .HasMaxLength(255)
                    .HasColumnName("actor_id");

                entity.Property(e => e.Banner).HasColumnName("banner");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(100)
                    .HasColumnName("category_name");

                entity.Property(e => e.CreatorActorId)
                    .HasMaxLength(255)
                    .HasColumnName("creator_actor_id");

                entity.Property(e => e.CreatorAvatar).HasColumnName("creator_avatar");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.CreatorLocal).HasColumnName("creator_local");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(20)
                    .HasColumnName("creator_name");

                entity.Property(e => e.CreatorPreferredUsername)
                    .HasMaxLength(20)
                    .HasColumnName("creator_preferred_username");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.HotRank).HasColumnName("hot_rank");

                entity.Property(e => e.Icon).HasColumnName("icon");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LastRefreshedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_refreshed_at");

                entity.Property(e => e.Local).HasColumnName("local");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .HasColumnName("name");

                entity.Property(e => e.Nsfw).HasColumnName("nsfw");

                entity.Property(e => e.NumberOfComments).HasColumnName("number_of_comments");

                entity.Property(e => e.NumberOfPosts).HasColumnName("number_of_posts");

                entity.Property(e => e.NumberOfSubscribers).HasColumnName("number_of_subscribers");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published");

                entity.Property(e => e.Removed).HasColumnName("removed");

                entity.Property(e => e.Subscribed).HasColumnName("subscribed");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .HasColumnName("title");

                entity.Property(e => e.Updated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<CommunityFollower>(entity =>
            {
                entity.ToTable("community_follower");

                entity.HasIndex(e => new { e.CommunityId, e.UserId }, "community_follower_community_id_user_id_key")
                    .IsUnique();

                entity.HasIndex(e => e.UserId, "idx_community_follower_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CommunityId).HasColumnName("community_id");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Community)
                    .WithMany(p => p.CommunityFollowers)
                    .HasForeignKey(d => d.CommunityId)
                    .HasConstraintName("community_follower_community_id_fkey");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CommunityFollowers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("community_follower_user_id_fkey");
            });

            modelBuilder.Entity<CommunityFollowerView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("community_follower_view");

                entity.Property(e => e.Avatar).HasColumnName("avatar");

                entity.Property(e => e.CommunityActorId)
                    .HasMaxLength(255)
                    .HasColumnName("community_actor_id");

                entity.Property(e => e.CommunityIcon).HasColumnName("community_icon");

                entity.Property(e => e.CommunityId).HasColumnName("community_id");

                entity.Property(e => e.CommunityLocal).HasColumnName("community_local");

                entity.Property(e => e.CommunityName)
                    .HasMaxLength(20)
                    .HasColumnName("community_name");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published");

                entity.Property(e => e.UserActorId)
                    .HasMaxLength(255)
                    .HasColumnName("user_actor_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserLocal).HasColumnName("user_local");

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .HasColumnName("user_name");

                entity.Property(e => e.UserPreferredUsername)
                    .HasMaxLength(20)
                    .HasColumnName("user_preferred_username");
            });

            modelBuilder.Entity<CommunityModerator>(entity =>
            {
                entity.ToTable("community_moderator");

                entity.HasIndex(e => new { e.CommunityId, e.UserId }, "community_moderator_community_id_user_id_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CommunityId).HasColumnName("community_id");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Community)
                    .WithMany(p => p.CommunityModerators)
                    .HasForeignKey(d => d.CommunityId)
                    .HasConstraintName("community_moderator_community_id_fkey");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CommunityModerators)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("community_moderator_user_id_fkey");
            });

            modelBuilder.Entity<CommunityModeratorView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("community_moderator_view");

                entity.Property(e => e.Avatar).HasColumnName("avatar");

                entity.Property(e => e.CommunityActorId)
                    .HasMaxLength(255)
                    .HasColumnName("community_actor_id");

                entity.Property(e => e.CommunityIcon).HasColumnName("community_icon");

                entity.Property(e => e.CommunityId).HasColumnName("community_id");

                entity.Property(e => e.CommunityLocal).HasColumnName("community_local");

                entity.Property(e => e.CommunityName)
                    .HasMaxLength(20)
                    .HasColumnName("community_name");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published");

                entity.Property(e => e.UserActorId)
                    .HasMaxLength(255)
                    .HasColumnName("user_actor_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserLocal).HasColumnName("user_local");

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .HasColumnName("user_name");

                entity.Property(e => e.UserPreferredUsername)
                    .HasMaxLength(20)
                    .HasColumnName("user_preferred_username");
            });

            modelBuilder.Entity<CommunitySetting>(entity =>
            {
                entity.ToTable("community_settings");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AllowAsDefault)
                    .IsRequired()
                    .HasColumnName("allow_as_default")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.CommentImages).HasColumnName("comment_images");

                entity.Property(e => e.HideFromAll).HasColumnName("hide_from_all");

                entity.Property(e => e.PostLinks).HasColumnName("post_links");

                entity.Property(e => e.Private).HasColumnName("private");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ReadOnly).HasColumnName("read_only");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.CommunitySetting)
                    .HasForeignKey<CommunitySetting>(d => d.Id)
                    .HasConstraintName("community_settings_id_fkey");
            });

            modelBuilder.Entity<CommunityStat>(entity =>
            {
                entity.HasKey(e => e.CommunityId)
                    .HasName("community_stat_pkey");

                entity.ToTable("community_stat", "hexbear");

                entity.Property(e => e.CommunityId)
                    .ValueGeneratedNever()
                    .HasColumnName("community_id");

                entity.Property(e => e.HotRank).HasColumnName("hot_rank");

                entity.Property(e => e.NumberOfComments).HasColumnName("number_of_comments");

                entity.Property(e => e.NumberOfPosts).HasColumnName("number_of_posts");

                entity.Property(e => e.NumberOfSubscribers).HasColumnName("number_of_subscribers");

                entity.HasOne(d => d.Community)
                    .WithOne(p => p.CommunityStat)
                    .HasForeignKey<CommunityStat>(d => d.CommunityId)
                    .HasConstraintName("community_stat_community_id_fkey");
            });

            modelBuilder.Entity<CommunityUserBan>(entity =>
            {
                entity.ToTable("community_user_ban");

                entity.HasIndex(e => new { e.CommunityId, e.UserId }, "community_user_ban_community_id_user_id_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CommunityId).HasColumnName("community_id");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Community)
                    .WithMany(p => p.CommunityUserBans)
                    .HasForeignKey(d => d.CommunityId)
                    .HasConstraintName("community_user_ban_community_id_fkey");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CommunityUserBans)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("community_user_ban_user_id_fkey");
            });

            modelBuilder.Entity<CommunityUserBanView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("community_user_ban_view");

                entity.Property(e => e.Avatar).HasColumnName("avatar");

                entity.Property(e => e.CommunityActorId)
                    .HasMaxLength(255)
                    .HasColumnName("community_actor_id");

                entity.Property(e => e.CommunityIcon).HasColumnName("community_icon");

                entity.Property(e => e.CommunityId).HasColumnName("community_id");

                entity.Property(e => e.CommunityLocal).HasColumnName("community_local");

                entity.Property(e => e.CommunityName)
                    .HasMaxLength(20)
                    .HasColumnName("community_name");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published");

                entity.Property(e => e.UserActorId)
                    .HasMaxLength(255)
                    .HasColumnName("user_actor_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserLocal).HasColumnName("user_local");

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .HasColumnName("user_name");

                entity.Property(e => e.UserPreferredUsername)
                    .HasMaxLength(20)
                    .HasColumnName("user_preferred_username");
            });

            modelBuilder.Entity<CommunityUserTag>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("community_user_tag_pkey");

                entity.ToTable("community_user_tag");

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("user_id");

                entity.Property(e => e.CommunityId).HasColumnName("community_id");

                entity.Property(e => e.Tags)
                    .HasColumnType("jsonb")
                    .HasColumnName("tags");

                entity.HasOne(d => d.Community)
                    .WithMany(p => p.CommunityUserTags)
                    .HasForeignKey(d => d.CommunityId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("community_user_tag_community_id_fkey");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.CommunityUserTag)
                    .HasForeignKey<CommunityUserTag>(d => d.UserId)
                    .HasConstraintName("community_user_tag_user_id_fkey");
            });

            modelBuilder.Entity<CommunityView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("community_view");

                entity.Property(e => e.ActorId)
                    .HasMaxLength(255)
                    .HasColumnName("actor_id");

                entity.Property(e => e.Banner).HasColumnName("banner");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(100)
                    .HasColumnName("category_name");

                entity.Property(e => e.CreatorActorId)
                    .HasMaxLength(255)
                    .HasColumnName("creator_actor_id");

                entity.Property(e => e.CreatorAvatar).HasColumnName("creator_avatar");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.CreatorLocal).HasColumnName("creator_local");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(20)
                    .HasColumnName("creator_name");

                entity.Property(e => e.CreatorPreferredUsername)
                    .HasMaxLength(20)
                    .HasColumnName("creator_preferred_username");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.HotRank).HasColumnName("hot_rank");

                entity.Property(e => e.Icon).HasColumnName("icon");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LastRefreshedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_refreshed_at");

                entity.Property(e => e.Local).HasColumnName("local");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .HasColumnName("name");

                entity.Property(e => e.Nsfw).HasColumnName("nsfw");

                entity.Property(e => e.NumberOfComments).HasColumnName("number_of_comments");

                entity.Property(e => e.NumberOfPosts).HasColumnName("number_of_posts");

                entity.Property(e => e.NumberOfSubscribers).HasColumnName("number_of_subscribers");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published");

                entity.Property(e => e.Removed).HasColumnName("removed");

                entity.Property(e => e.Subscribed).HasColumnName("subscribed");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .HasColumnName("title");

                entity.Property(e => e.Updated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<DepsSavedDdl>(entity =>
            {
                entity.ToTable("deps_saved_ddl", "utils");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DdlToRun).HasColumnName("ddl_to_run");

                entity.Property(e => e.ViewName)
                    .HasMaxLength(255)
                    .HasColumnName("view_name");

                entity.Property(e => e.ViewSchema)
                    .HasMaxLength(255)
                    .HasColumnName("view_schema");
            });

            modelBuilder.Entity<DieselSchemaMigration>(entity =>
            {
                entity.HasKey(e => e.Version)
                    .HasName("__diesel_schema_migrations_pkey");

                entity.ToTable("__diesel_schema_migrations");

                entity.Property(e => e.Version)
                    .HasMaxLength(50)
                    .HasColumnName("version");

                entity.Property(e => e.RunOn)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("run_on")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<ModAdd>(entity =>
            {
                entity.ToTable("mod_add");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ModUserId).HasColumnName("mod_user_id");

                entity.Property(e => e.OtherUserId).HasColumnName("other_user_id");

                entity.Property(e => e.Removed)
                    .HasColumnName("removed")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.When)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("when_")
                    .HasDefaultValueSql("now()");

                entity.HasOne(d => d.ModUser)
                    .WithMany(p => p.ModAddModUsers)
                    .HasForeignKey(d => d.ModUserId)
                    .HasConstraintName("mod_add_mod_user_id_fkey");

                entity.HasOne(d => d.OtherUser)
                    .WithMany(p => p.ModAddOtherUsers)
                    .HasForeignKey(d => d.OtherUserId)
                    .HasConstraintName("mod_add_other_user_id_fkey");
            });

            modelBuilder.Entity<ModAddCommunity>(entity =>
            {
                entity.ToTable("mod_add_community");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CommunityId).HasColumnName("community_id");

                entity.Property(e => e.ModUserId).HasColumnName("mod_user_id");

                entity.Property(e => e.OtherUserId).HasColumnName("other_user_id");

                entity.Property(e => e.Removed)
                    .HasColumnName("removed")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.When)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("when_")
                    .HasDefaultValueSql("now()");

                entity.HasOne(d => d.Community)
                    .WithMany(p => p.ModAddCommunities)
                    .HasForeignKey(d => d.CommunityId)
                    .HasConstraintName("mod_add_community_community_id_fkey");

                entity.HasOne(d => d.ModUser)
                    .WithMany(p => p.ModAddCommunityModUsers)
                    .HasForeignKey(d => d.ModUserId)
                    .HasConstraintName("mod_add_community_mod_user_id_fkey");

                entity.HasOne(d => d.OtherUser)
                    .WithMany(p => p.ModAddCommunityOtherUsers)
                    .HasForeignKey(d => d.OtherUserId)
                    .HasConstraintName("mod_add_community_other_user_id_fkey");
            });

            modelBuilder.Entity<ModAddCommunityView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("mod_add_community_view");

                entity.Property(e => e.CommunityId).HasColumnName("community_id");

                entity.Property(e => e.CommunityName)
                    .HasMaxLength(20)
                    .HasColumnName("community_name");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ModUserId).HasColumnName("mod_user_id");

                entity.Property(e => e.ModUserName)
                    .HasMaxLength(20)
                    .HasColumnName("mod_user_name");

                entity.Property(e => e.OtherUserId).HasColumnName("other_user_id");

                entity.Property(e => e.OtherUserName)
                    .HasMaxLength(20)
                    .HasColumnName("other_user_name");

                entity.Property(e => e.Removed).HasColumnName("removed");

                entity.Property(e => e.When)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("when_");
            });

            modelBuilder.Entity<ModAddView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("mod_add_view");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ModUserId).HasColumnName("mod_user_id");

                entity.Property(e => e.ModUserName)
                    .HasMaxLength(20)
                    .HasColumnName("mod_user_name");

                entity.Property(e => e.OtherUserId).HasColumnName("other_user_id");

                entity.Property(e => e.OtherUserName)
                    .HasMaxLength(20)
                    .HasColumnName("other_user_name");

                entity.Property(e => e.Removed).HasColumnName("removed");

                entity.Property(e => e.When)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("when_");
            });

            modelBuilder.Entity<ModBan>(entity =>
            {
                entity.ToTable("mod_ban");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Banned)
                    .HasColumnName("banned")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Expires)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("expires");

                entity.Property(e => e.ModUserId).HasColumnName("mod_user_id");

                entity.Property(e => e.OtherUserId).HasColumnName("other_user_id");

                entity.Property(e => e.Reason).HasColumnName("reason");

                entity.Property(e => e.When)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("when_")
                    .HasDefaultValueSql("now()");

                entity.HasOne(d => d.ModUser)
                    .WithMany(p => p.ModBanModUsers)
                    .HasForeignKey(d => d.ModUserId)
                    .HasConstraintName("mod_ban_mod_user_id_fkey");

                entity.HasOne(d => d.OtherUser)
                    .WithMany(p => p.ModBanOtherUsers)
                    .HasForeignKey(d => d.OtherUserId)
                    .HasConstraintName("mod_ban_other_user_id_fkey");
            });

            modelBuilder.Entity<ModBanFromCommunity>(entity =>
            {
                entity.ToTable("mod_ban_from_community");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Banned)
                    .HasColumnName("banned")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.CommunityId).HasColumnName("community_id");

                entity.Property(e => e.Expires)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("expires");

                entity.Property(e => e.ModUserId).HasColumnName("mod_user_id");

                entity.Property(e => e.OtherUserId).HasColumnName("other_user_id");

                entity.Property(e => e.Reason).HasColumnName("reason");

                entity.Property(e => e.When)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("when_")
                    .HasDefaultValueSql("now()");

                entity.HasOne(d => d.Community)
                    .WithMany(p => p.ModBanFromCommunities)
                    .HasForeignKey(d => d.CommunityId)
                    .HasConstraintName("mod_ban_from_community_community_id_fkey");

                entity.HasOne(d => d.ModUser)
                    .WithMany(p => p.ModBanFromCommunityModUsers)
                    .HasForeignKey(d => d.ModUserId)
                    .HasConstraintName("mod_ban_from_community_mod_user_id_fkey");

                entity.HasOne(d => d.OtherUser)
                    .WithMany(p => p.ModBanFromCommunityOtherUsers)
                    .HasForeignKey(d => d.OtherUserId)
                    .HasConstraintName("mod_ban_from_community_other_user_id_fkey");
            });

            modelBuilder.Entity<ModBanFromCommunityView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("mod_ban_from_community_view");

                entity.Property(e => e.Banned).HasColumnName("banned");

                entity.Property(e => e.CommunityId).HasColumnName("community_id");

                entity.Property(e => e.CommunityName)
                    .HasMaxLength(20)
                    .HasColumnName("community_name");

                entity.Property(e => e.Expires)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("expires");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ModUserId).HasColumnName("mod_user_id");

                entity.Property(e => e.ModUserName)
                    .HasMaxLength(20)
                    .HasColumnName("mod_user_name");

                entity.Property(e => e.OtherUserId).HasColumnName("other_user_id");

                entity.Property(e => e.OtherUserName)
                    .HasMaxLength(20)
                    .HasColumnName("other_user_name");

                entity.Property(e => e.Reason).HasColumnName("reason");

                entity.Property(e => e.When)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("when_");
            });

            modelBuilder.Entity<ModBanView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("mod_ban_view");

                entity.Property(e => e.Banned).HasColumnName("banned");

                entity.Property(e => e.Expires)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("expires");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ModUserId).HasColumnName("mod_user_id");

                entity.Property(e => e.ModUserName)
                    .HasMaxLength(20)
                    .HasColumnName("mod_user_name");

                entity.Property(e => e.OtherUserId).HasColumnName("other_user_id");

                entity.Property(e => e.OtherUserName)
                    .HasMaxLength(20)
                    .HasColumnName("other_user_name");

                entity.Property(e => e.Reason).HasColumnName("reason");

                entity.Property(e => e.When)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("when_");
            });

            modelBuilder.Entity<ModLockPost>(entity =>
            {
                entity.ToTable("mod_lock_post");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Locked)
                    .HasColumnName("locked")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ModUserId).HasColumnName("mod_user_id");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.When)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("when_")
                    .HasDefaultValueSql("now()");

                entity.HasOne(d => d.ModUser)
                    .WithMany(p => p.ModLockPosts)
                    .HasForeignKey(d => d.ModUserId)
                    .HasConstraintName("mod_lock_post_mod_user_id_fkey");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.ModLockPosts)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("mod_lock_post_post_id_fkey");
            });

            modelBuilder.Entity<ModLockPostView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("mod_lock_post_view", "hexbear");

                entity.Property(e => e.CommunityId).HasColumnName("community_id");

                entity.Property(e => e.CommunityName)
                    .HasMaxLength(20)
                    .HasColumnName("community_name");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Locked).HasColumnName("locked");

                entity.Property(e => e.ModUserId).HasColumnName("mod_user_id");

                entity.Property(e => e.ModUserName)
                    .HasMaxLength(20)
                    .HasColumnName("mod_user_name");

                entity.Property(e => e.OtherUserId).HasColumnName("other_user_id");

                entity.Property(e => e.OtherUserName)
                    .HasMaxLength(20)
                    .HasColumnName("other_user_name");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.PostName)
                    .HasMaxLength(200)
                    .HasColumnName("post_name");

                entity.Property(e => e.When)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("when_");
            });

            modelBuilder.Entity<ModLockPostView1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("mod_lock_post_view");

                entity.Property(e => e.CommunityId).HasColumnName("community_id");

                entity.Property(e => e.CommunityName)
                    .HasMaxLength(20)
                    .HasColumnName("community_name");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Locked).HasColumnName("locked");

                entity.Property(e => e.ModUserId).HasColumnName("mod_user_id");

                entity.Property(e => e.ModUserName)
                    .HasMaxLength(20)
                    .HasColumnName("mod_user_name");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.PostName)
                    .HasMaxLength(200)
                    .HasColumnName("post_name");

                entity.Property(e => e.When)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("when_");
            });

            modelBuilder.Entity<ModRemoveComment>(entity =>
            {
                entity.ToTable("mod_remove_comment");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CommentId).HasColumnName("comment_id");

                entity.Property(e => e.ModUserId).HasColumnName("mod_user_id");

                entity.Property(e => e.Reason).HasColumnName("reason");

                entity.Property(e => e.Removed)
                    .HasColumnName("removed")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.When)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("when_")
                    .HasDefaultValueSql("now()");

                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.ModRemoveComments)
                    .HasForeignKey(d => d.CommentId)
                    .HasConstraintName("mod_remove_comment_comment_id_fkey");

                entity.HasOne(d => d.ModUser)
                    .WithMany(p => p.ModRemoveComments)
                    .HasForeignKey(d => d.ModUserId)
                    .HasConstraintName("mod_remove_comment_mod_user_id_fkey");
            });

            modelBuilder.Entity<ModRemoveCommentView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("mod_remove_comment_view");

                entity.Property(e => e.CommentContent).HasColumnName("comment_content");

                entity.Property(e => e.CommentId).HasColumnName("comment_id");

                entity.Property(e => e.CommentUserId).HasColumnName("comment_user_id");

                entity.Property(e => e.CommentUserName)
                    .HasMaxLength(20)
                    .HasColumnName("comment_user_name");

                entity.Property(e => e.CommunityId).HasColumnName("community_id");

                entity.Property(e => e.CommunityName)
                    .HasMaxLength(20)
                    .HasColumnName("community_name");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ModUserId).HasColumnName("mod_user_id");

                entity.Property(e => e.ModUserName)
                    .HasMaxLength(20)
                    .HasColumnName("mod_user_name");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.PostName)
                    .HasMaxLength(200)
                    .HasColumnName("post_name");

                entity.Property(e => e.Reason).HasColumnName("reason");

                entity.Property(e => e.Removed).HasColumnName("removed");

                entity.Property(e => e.When)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("when_");
            });

            modelBuilder.Entity<ModRemoveCommunity>(entity =>
            {
                entity.ToTable("mod_remove_community");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CommunityId).HasColumnName("community_id");

                entity.Property(e => e.Expires)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("expires");

                entity.Property(e => e.ModUserId).HasColumnName("mod_user_id");

                entity.Property(e => e.Reason).HasColumnName("reason");

                entity.Property(e => e.Removed)
                    .HasColumnName("removed")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.When)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("when_")
                    .HasDefaultValueSql("now()");

                entity.HasOne(d => d.Community)
                    .WithMany(p => p.ModRemoveCommunities)
                    .HasForeignKey(d => d.CommunityId)
                    .HasConstraintName("mod_remove_community_community_id_fkey");

                entity.HasOne(d => d.ModUser)
                    .WithMany(p => p.ModRemoveCommunities)
                    .HasForeignKey(d => d.ModUserId)
                    .HasConstraintName("mod_remove_community_mod_user_id_fkey");
            });

            modelBuilder.Entity<ModRemoveCommunityView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("mod_remove_community_view");

                entity.Property(e => e.CommunityId).HasColumnName("community_id");

                entity.Property(e => e.CommunityName)
                    .HasMaxLength(20)
                    .HasColumnName("community_name");

                entity.Property(e => e.Expires)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("expires");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ModUserId).HasColumnName("mod_user_id");

                entity.Property(e => e.ModUserName)
                    .HasMaxLength(20)
                    .HasColumnName("mod_user_name");

                entity.Property(e => e.Reason).HasColumnName("reason");

                entity.Property(e => e.Removed).HasColumnName("removed");

                entity.Property(e => e.When)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("when_");
            });

            modelBuilder.Entity<ModRemovePost>(entity =>
            {
                entity.ToTable("mod_remove_post");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ModUserId).HasColumnName("mod_user_id");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.Reason).HasColumnName("reason");

                entity.Property(e => e.Removed)
                    .HasColumnName("removed")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.When)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("when_")
                    .HasDefaultValueSql("now()");

                entity.HasOne(d => d.ModUser)
                    .WithMany(p => p.ModRemovePosts)
                    .HasForeignKey(d => d.ModUserId)
                    .HasConstraintName("mod_remove_post_mod_user_id_fkey");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.ModRemovePosts)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("mod_remove_post_post_id_fkey");
            });

            modelBuilder.Entity<ModRemovePostView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("mod_remove_post_view", "hexbear");

                entity.Property(e => e.CommunityId).HasColumnName("community_id");

                entity.Property(e => e.CommunityName)
                    .HasMaxLength(20)
                    .HasColumnName("community_name");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ModUserId).HasColumnName("mod_user_id");

                entity.Property(e => e.ModUserName)
                    .HasMaxLength(20)
                    .HasColumnName("mod_user_name");

                entity.Property(e => e.OtherUserId).HasColumnName("other_user_id");

                entity.Property(e => e.OtherUserName)
                    .HasMaxLength(20)
                    .HasColumnName("other_user_name");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.PostName)
                    .HasMaxLength(200)
                    .HasColumnName("post_name");

                entity.Property(e => e.Reason).HasColumnName("reason");

                entity.Property(e => e.Removed).HasColumnName("removed");

                entity.Property(e => e.When)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("when_");
            });

            modelBuilder.Entity<ModRemovePostView1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("mod_remove_post_view");

                entity.Property(e => e.CommunityId).HasColumnName("community_id");

                entity.Property(e => e.CommunityName)
                    .HasMaxLength(20)
                    .HasColumnName("community_name");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ModUserId).HasColumnName("mod_user_id");

                entity.Property(e => e.ModUserName)
                    .HasMaxLength(20)
                    .HasColumnName("mod_user_name");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.PostName)
                    .HasMaxLength(200)
                    .HasColumnName("post_name");

                entity.Property(e => e.Reason).HasColumnName("reason");

                entity.Property(e => e.Removed).HasColumnName("removed");

                entity.Property(e => e.When)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("when_");
            });

            modelBuilder.Entity<ModStickyPost>(entity =>
            {
                entity.ToTable("mod_sticky_post");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ModUserId).HasColumnName("mod_user_id");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.Stickied)
                    .HasColumnName("stickied")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.When)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("when_")
                    .HasDefaultValueSql("now()");

                entity.HasOne(d => d.ModUser)
                    .WithMany(p => p.ModStickyPosts)
                    .HasForeignKey(d => d.ModUserId)
                    .HasConstraintName("mod_sticky_post_mod_user_id_fkey");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.ModStickyPosts)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("mod_sticky_post_post_id_fkey");
            });

            modelBuilder.Entity<ModStickyPostView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("mod_sticky_post_view", "hexbear");

                entity.Property(e => e.CommunityId).HasColumnName("community_id");

                entity.Property(e => e.CommunityName)
                    .HasMaxLength(20)
                    .HasColumnName("community_name");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ModUserId).HasColumnName("mod_user_id");

                entity.Property(e => e.ModUserName)
                    .HasMaxLength(20)
                    .HasColumnName("mod_user_name");

                entity.Property(e => e.OtherUserId).HasColumnName("other_user_id");

                entity.Property(e => e.OtherUserName)
                    .HasMaxLength(20)
                    .HasColumnName("other_user_name");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.PostName)
                    .HasMaxLength(200)
                    .HasColumnName("post_name");

                entity.Property(e => e.Stickied).HasColumnName("stickied");

                entity.Property(e => e.When)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("when_");
            });

            modelBuilder.Entity<ModStickyPostView1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("mod_sticky_post_view");

                entity.Property(e => e.CommunityId).HasColumnName("community_id");

                entity.Property(e => e.CommunityName)
                    .HasMaxLength(20)
                    .HasColumnName("community_name");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ModUserId).HasColumnName("mod_user_id");

                entity.Property(e => e.ModUserName)
                    .HasMaxLength(20)
                    .HasColumnName("mod_user_name");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.PostName)
                    .HasMaxLength(200)
                    .HasColumnName("post_name");

                entity.Property(e => e.Stickied).HasColumnName("stickied");

                entity.Property(e => e.When)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("when_");
            });

            modelBuilder.Entity<PasswordResetRequest>(entity =>
            {
                entity.ToTable("password_reset_request");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.TokenEncrypted).HasColumnName("token_encrypted");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PasswordResetRequests)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("password_reset_request_user_id_fkey");
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.ToTable("post");

                entity.HasIndex(e => e.ApId, "idx_post_ap_id")
                    .IsUnique();

                entity.HasIndex(e => e.CommunityId, "idx_post_community");

                entity.HasIndex(e => e.CreatorId, "idx_post_creator");

                entity.HasIndex(e => e.Published, "idx_post_published")
                    .IsDescending(true);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApId)
                    .HasMaxLength(255)
                    .HasColumnName("ap_id")
                    .HasDefaultValueSql("generate_unique_changeme()");

                entity.Property(e => e.Body).HasColumnName("body");

                entity.Property(e => e.CommunityId).HasColumnName("community_id");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.EmbedDescription).HasColumnName("embed_description");

                entity.Property(e => e.EmbedHtml).HasColumnName("embed_html");

                entity.Property(e => e.EmbedTitle).HasColumnName("embed_title");

                entity.Property(e => e.Featured).HasColumnName("featured");

                entity.Property(e => e.Local)
                    .IsRequired()
                    .HasColumnName("local")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Locked).HasColumnName("locked");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.Property(e => e.Nsfw).HasColumnName("nsfw");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Removed).HasColumnName("removed");

                entity.Property(e => e.Stickied).HasColumnName("stickied");

                entity.Property(e => e.ThumbnailUrl).HasColumnName("thumbnail_url");

                entity.Property(e => e.Updated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated");

                entity.Property(e => e.Url).HasColumnName("url");

                entity.HasOne(d => d.Community)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.CommunityId)
                    .HasConstraintName("post_community_id_fkey");

                entity.HasOne(d => d.Creator)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.CreatorId)
                    .HasConstraintName("post_creator_id_fkey");
            });

            modelBuilder.Entity<PostAggregatesFast>(entity =>
            {
                entity.ToTable("post_aggregates_fast");

                entity.HasIndex(e => new { e.HotRankActive, e.Published }, "idx_post_aggregates_fast_hot_rank_active_published")
                    .IsDescending(true, true);

                entity.HasIndex(e => new { e.HotRank, e.Published }, "idx_post_aggregates_fast_hot_rank_published")
                    .IsDescending(true, true);

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ApId)
                    .HasMaxLength(255)
                    .HasColumnName("ap_id");

                entity.Property(e => e.Banned).HasColumnName("banned");

                entity.Property(e => e.BannedFromCommunity).HasColumnName("banned_from_community");

                entity.Property(e => e.Body).HasColumnName("body");

                entity.Property(e => e.CommunityActorId)
                    .HasMaxLength(255)
                    .HasColumnName("community_actor_id");

                entity.Property(e => e.CommunityDeleted).HasColumnName("community_deleted");

                entity.Property(e => e.CommunityIcon).HasColumnName("community_icon");

                entity.Property(e => e.CommunityId).HasColumnName("community_id");

                entity.Property(e => e.CommunityLocal).HasColumnName("community_local");

                entity.Property(e => e.CommunityName)
                    .HasMaxLength(20)
                    .HasColumnName("community_name");

                entity.Property(e => e.CommunityNsfw).HasColumnName("community_nsfw");

                entity.Property(e => e.CommunityRemoved).HasColumnName("community_removed");

                entity.Property(e => e.CreatorActorId)
                    .HasMaxLength(255)
                    .HasColumnName("creator_actor_id");

                entity.Property(e => e.CreatorAvatar).HasColumnName("creator_avatar");

                entity.Property(e => e.CreatorCommunityTags)
                    .HasColumnType("jsonb")
                    .HasColumnName("creator_community_tags");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.CreatorLocal).HasColumnName("creator_local");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(20)
                    .HasColumnName("creator_name");

                entity.Property(e => e.CreatorPreferredUsername)
                    .HasMaxLength(20)
                    .HasColumnName("creator_preferred_username");

                entity.Property(e => e.CreatorPublished)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("creator_published");

                entity.Property(e => e.CreatorTags)
                    .HasColumnType("jsonb")
                    .HasColumnName("creator_tags");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Downvotes).HasColumnName("downvotes");

                entity.Property(e => e.EmbedDescription).HasColumnName("embed_description");

                entity.Property(e => e.EmbedHtml).HasColumnName("embed_html");

                entity.Property(e => e.EmbedTitle).HasColumnName("embed_title");

                entity.Property(e => e.HotRank).HasColumnName("hot_rank");

                entity.Property(e => e.HotRankActive).HasColumnName("hot_rank_active");

                entity.Property(e => e.Local).HasColumnName("local");

                entity.Property(e => e.Locked).HasColumnName("locked");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.Property(e => e.NewestActivityTime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("newest_activity_time");

                entity.Property(e => e.Nsfw).HasColumnName("nsfw");

                entity.Property(e => e.NumberOfComments).HasColumnName("number_of_comments");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published");

                entity.Property(e => e.Removed).HasColumnName("removed");

                entity.Property(e => e.Score).HasColumnName("score");

                entity.Property(e => e.Stickied).HasColumnName("stickied");

                entity.Property(e => e.ThumbnailUrl).HasColumnName("thumbnail_url");

                entity.Property(e => e.Updated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated");

                entity.Property(e => e.Upvotes).HasColumnName("upvotes");

                entity.Property(e => e.Url).HasColumnName("url");
            });

            modelBuilder.Entity<PostAggregatesView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("post_aggregates_view");

                entity.Property(e => e.ApId)
                    .HasMaxLength(255)
                    .HasColumnName("ap_id");

                entity.Property(e => e.Banned).HasColumnName("banned");

                entity.Property(e => e.BannedFromCommunity).HasColumnName("banned_from_community");

                entity.Property(e => e.Body).HasColumnName("body");

                entity.Property(e => e.CommunityActorId)
                    .HasMaxLength(255)
                    .HasColumnName("community_actor_id");

                entity.Property(e => e.CommunityDeleted).HasColumnName("community_deleted");

                entity.Property(e => e.CommunityIcon).HasColumnName("community_icon");

                entity.Property(e => e.CommunityId).HasColumnName("community_id");

                entity.Property(e => e.CommunityLocal).HasColumnName("community_local");

                entity.Property(e => e.CommunityName)
                    .HasMaxLength(20)
                    .HasColumnName("community_name");

                entity.Property(e => e.CommunityNsfw).HasColumnName("community_nsfw");

                entity.Property(e => e.CommunityRemoved).HasColumnName("community_removed");

                entity.Property(e => e.CreatorActorId)
                    .HasMaxLength(255)
                    .HasColumnName("creator_actor_id");

                entity.Property(e => e.CreatorAvatar).HasColumnName("creator_avatar");

                entity.Property(e => e.CreatorCommunityTags)
                    .HasColumnType("jsonb")
                    .HasColumnName("creator_community_tags");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.CreatorLocal).HasColumnName("creator_local");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(20)
                    .HasColumnName("creator_name");

                entity.Property(e => e.CreatorPreferredUsername)
                    .HasMaxLength(20)
                    .HasColumnName("creator_preferred_username");

                entity.Property(e => e.CreatorPublished)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("creator_published");

                entity.Property(e => e.CreatorTags)
                    .HasColumnType("jsonb")
                    .HasColumnName("creator_tags");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Downvotes).HasColumnName("downvotes");

                entity.Property(e => e.EmbedDescription).HasColumnName("embed_description");

                entity.Property(e => e.EmbedHtml).HasColumnName("embed_html");

                entity.Property(e => e.EmbedTitle).HasColumnName("embed_title");

                entity.Property(e => e.HotRank).HasColumnName("hot_rank");

                entity.Property(e => e.HotRankActive).HasColumnName("hot_rank_active");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Local).HasColumnName("local");

                entity.Property(e => e.Locked).HasColumnName("locked");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.Property(e => e.NewestActivityTime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("newest_activity_time");

                entity.Property(e => e.Nsfw).HasColumnName("nsfw");

                entity.Property(e => e.NumberOfComments).HasColumnName("number_of_comments");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published");

                entity.Property(e => e.Removed).HasColumnName("removed");

                entity.Property(e => e.Score).HasColumnName("score");

                entity.Property(e => e.Stickied).HasColumnName("stickied");

                entity.Property(e => e.ThumbnailUrl).HasColumnName("thumbnail_url");

                entity.Property(e => e.Updated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated");

                entity.Property(e => e.Upvotes).HasColumnName("upvotes");

                entity.Property(e => e.Url).HasColumnName("url");
            });

            modelBuilder.Entity<PostFastView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("post_fast_view", "hexbear");

                entity.Property(e => e.ApId)
                    .HasMaxLength(255)
                    .HasColumnName("ap_id");

                entity.Property(e => e.Banned).HasColumnName("banned");

                entity.Property(e => e.BannedFromCommunity).HasColumnName("banned_from_community");

                entity.Property(e => e.Body).HasColumnName("body");

                entity.Property(e => e.CommunityActorId)
                    .HasMaxLength(255)
                    .HasColumnName("community_actor_id");

                entity.Property(e => e.CommunityDeleted).HasColumnName("community_deleted");

                entity.Property(e => e.CommunityHideFromAll).HasColumnName("community_hide_from_all");

                entity.Property(e => e.CommunityIcon).HasColumnName("community_icon");

                entity.Property(e => e.CommunityId).HasColumnName("community_id");

                entity.Property(e => e.CommunityLocal).HasColumnName("community_local");

                entity.Property(e => e.CommunityName)
                    .HasMaxLength(20)
                    .HasColumnName("community_name");

                entity.Property(e => e.CommunityNsfw).HasColumnName("community_nsfw");

                entity.Property(e => e.CommunityRemoved).HasColumnName("community_removed");

                entity.Property(e => e.CreatorActorId)
                    .HasMaxLength(255)
                    .HasColumnName("creator_actor_id");

                entity.Property(e => e.CreatorAvatar).HasColumnName("creator_avatar");

                entity.Property(e => e.CreatorCommunityTags)
                    .HasColumnType("jsonb")
                    .HasColumnName("creator_community_tags");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.CreatorLocal).HasColumnName("creator_local");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(20)
                    .HasColumnName("creator_name");

                entity.Property(e => e.CreatorPreferredUsername)
                    .HasMaxLength(20)
                    .HasColumnName("creator_preferred_username");

                entity.Property(e => e.CreatorPublished)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("creator_published");

                entity.Property(e => e.CreatorTags)
                    .HasColumnType("jsonb")
                    .HasColumnName("creator_tags");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Downvotes).HasColumnName("downvotes");

                entity.Property(e => e.EmbedDescription).HasColumnName("embed_description");

                entity.Property(e => e.EmbedHtml).HasColumnName("embed_html");

                entity.Property(e => e.EmbedTitle).HasColumnName("embed_title");

                entity.Property(e => e.Featured).HasColumnName("featured");

                entity.Property(e => e.HotRank).HasColumnName("hot_rank");

                entity.Property(e => e.HotRankActive).HasColumnName("hot_rank_active");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Local).HasColumnName("local");

                entity.Property(e => e.Locked).HasColumnName("locked");

                entity.Property(e => e.MyVote).HasColumnName("my_vote");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.Property(e => e.NewestActivityTime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("newest_activity_time");

                entity.Property(e => e.Nsfw).HasColumnName("nsfw");

                entity.Property(e => e.NumberOfComments).HasColumnName("number_of_comments");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published");

                entity.Property(e => e.Read).HasColumnName("read");

                entity.Property(e => e.Removed).HasColumnName("removed");

                entity.Property(e => e.Saved).HasColumnName("saved");

                entity.Property(e => e.Score).HasColumnName("score");

                entity.Property(e => e.Stickied).HasColumnName("stickied");

                entity.Property(e => e.Subscribed).HasColumnName("subscribed");

                entity.Property(e => e.ThumbnailUrl).HasColumnName("thumbnail_url");

                entity.Property(e => e.Updated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated");

                entity.Property(e => e.Upvotes).HasColumnName("upvotes");

                entity.Property(e => e.Url).HasColumnName("url");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<PostFastView1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("post_fast_view");

                entity.Property(e => e.ApId)
                    .HasMaxLength(255)
                    .HasColumnName("ap_id");

                entity.Property(e => e.Banned).HasColumnName("banned");

                entity.Property(e => e.BannedFromCommunity).HasColumnName("banned_from_community");

                entity.Property(e => e.Body).HasColumnName("body");

                entity.Property(e => e.CommunityActorId)
                    .HasMaxLength(255)
                    .HasColumnName("community_actor_id");

                entity.Property(e => e.CommunityDeleted).HasColumnName("community_deleted");

                entity.Property(e => e.CommunityIcon).HasColumnName("community_icon");

                entity.Property(e => e.CommunityId).HasColumnName("community_id");

                entity.Property(e => e.CommunityLocal).HasColumnName("community_local");

                entity.Property(e => e.CommunityName)
                    .HasMaxLength(20)
                    .HasColumnName("community_name");

                entity.Property(e => e.CommunityNsfw).HasColumnName("community_nsfw");

                entity.Property(e => e.CommunityRemoved).HasColumnName("community_removed");

                entity.Property(e => e.CreatorActorId)
                    .HasMaxLength(255)
                    .HasColumnName("creator_actor_id");

                entity.Property(e => e.CreatorAvatar).HasColumnName("creator_avatar");

                entity.Property(e => e.CreatorCommunityTags)
                    .HasColumnType("jsonb")
                    .HasColumnName("creator_community_tags");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.CreatorLocal).HasColumnName("creator_local");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(20)
                    .HasColumnName("creator_name");

                entity.Property(e => e.CreatorPreferredUsername)
                    .HasMaxLength(20)
                    .HasColumnName("creator_preferred_username");

                entity.Property(e => e.CreatorPublished)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("creator_published");

                entity.Property(e => e.CreatorTags)
                    .HasColumnType("jsonb")
                    .HasColumnName("creator_tags");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Downvotes).HasColumnName("downvotes");

                entity.Property(e => e.EmbedDescription).HasColumnName("embed_description");

                entity.Property(e => e.EmbedHtml).HasColumnName("embed_html");

                entity.Property(e => e.EmbedTitle).HasColumnName("embed_title");

                entity.Property(e => e.HotRank).HasColumnName("hot_rank");

                entity.Property(e => e.HotRankActive).HasColumnName("hot_rank_active");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Local).HasColumnName("local");

                entity.Property(e => e.Locked).HasColumnName("locked");

                entity.Property(e => e.MyVote).HasColumnName("my_vote");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.Property(e => e.NewestActivityTime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("newest_activity_time");

                entity.Property(e => e.Nsfw).HasColumnName("nsfw");

                entity.Property(e => e.NumberOfComments).HasColumnName("number_of_comments");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published");

                entity.Property(e => e.Read).HasColumnName("read");

                entity.Property(e => e.Removed).HasColumnName("removed");

                entity.Property(e => e.Saved).HasColumnName("saved");

                entity.Property(e => e.Score).HasColumnName("score");

                entity.Property(e => e.Stickied).HasColumnName("stickied");

                entity.Property(e => e.Subscribed).HasColumnName("subscribed");

                entity.Property(e => e.ThumbnailUrl).HasColumnName("thumbnail_url");

                entity.Property(e => e.Updated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated");

                entity.Property(e => e.Upvotes).HasColumnName("upvotes");

                entity.Property(e => e.Url).HasColumnName("url");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<PostLike>(entity =>
            {
                entity.ToTable("post_like");

                entity.HasIndex(e => e.PostId, "idx_post_like_post");

                entity.HasIndex(e => e.UserId, "idx_post_like_user");

                entity.HasIndex(e => new { e.PostId, e.UserId }, "post_like_post_id_user_id_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Score).HasColumnName("score");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.PostLikes)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("post_like_post_id_fkey");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PostLikes)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("post_like_user_id_fkey");
            });

            modelBuilder.Entity<PostRead>(entity =>
            {
                entity.ToTable("post_read");

                entity.HasIndex(e => new { e.PostId, e.UserId }, "post_read_post_id_user_id_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.PostReads)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("post_read_post_id_fkey");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PostReads)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("post_read_user_id_fkey");
            });

            modelBuilder.Entity<PostReport>(entity =>
            {
                entity.ToTable("post_report");

                entity.HasIndex(e => new { e.PostId, e.UserId }, "post_report_post_id_user_id_key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.PostBody).HasColumnName("post_body");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.PostName)
                    .HasMaxLength(100)
                    .HasColumnName("post_name");

                entity.Property(e => e.PostTime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("post_time");

                entity.Property(e => e.PostUrl).HasColumnName("post_url");

                entity.Property(e => e.Reason).HasColumnName("reason");

                entity.Property(e => e.Resolved).HasColumnName("resolved");

                entity.Property(e => e.Time)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("time")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.PostReports)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("post_report_post_id_fkey");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PostReports)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("post_report_user_id_fkey");
            });

            modelBuilder.Entity<PostReportView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("post_report_view");

                entity.Property(e => e.CommunityId).HasColumnName("community_id");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(20)
                    .HasColumnName("creator_name");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PostBody).HasColumnName("post_body");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.PostName)
                    .HasMaxLength(100)
                    .HasColumnName("post_name");

                entity.Property(e => e.PostTime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("post_time");

                entity.Property(e => e.PostUrl).HasColumnName("post_url");

                entity.Property(e => e.Reason).HasColumnName("reason");

                entity.Property(e => e.Resolved).HasColumnName("resolved");

                entity.Property(e => e.Time)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("time");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .HasColumnName("user_name");
            });

            modelBuilder.Entity<PostSaved>(entity =>
            {
                entity.ToTable("post_saved");

                entity.HasIndex(e => new { e.PostId, e.UserId }, "post_saved_post_id_user_id_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.PostSaveds)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("post_saved_post_id_fkey");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PostSaveds)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("post_saved_user_id_fkey");
            });

            modelBuilder.Entity<PostStat>(entity =>
            {
                entity.HasKey(e => e.PostId)
                    .HasName("post_stat_pkey");

                entity.ToTable("post_stat", "hexbear");

                entity.Property(e => e.PostId)
                    .ValueGeneratedNever()
                    .HasColumnName("post_id");

                entity.Property(e => e.Downvotes).HasColumnName("downvotes");

                entity.Property(e => e.HotRank).HasColumnName("hot_rank");

                entity.Property(e => e.HotRankActive).HasColumnName("hot_rank_active");

                entity.Property(e => e.NewestActivityTime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("newest_activity_time");

                entity.Property(e => e.NumberOfComments).HasColumnName("number_of_comments");

                entity.Property(e => e.Score).HasColumnName("score");

                entity.Property(e => e.Upvotes).HasColumnName("upvotes");

                entity.HasOne(d => d.Post)
                    .WithOne(p => p.PostStat)
                    .HasForeignKey<PostStat>(d => d.PostId)
                    .HasConstraintName("post_stat_post_id_fkey");
            });

            modelBuilder.Entity<PostView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("post_view");

                entity.Property(e => e.ApId)
                    .HasMaxLength(255)
                    .HasColumnName("ap_id");

                entity.Property(e => e.Banned).HasColumnName("banned");

                entity.Property(e => e.BannedFromCommunity).HasColumnName("banned_from_community");

                entity.Property(e => e.Body).HasColumnName("body");

                entity.Property(e => e.CommunityActorId)
                    .HasMaxLength(255)
                    .HasColumnName("community_actor_id");

                entity.Property(e => e.CommunityDeleted).HasColumnName("community_deleted");

                entity.Property(e => e.CommunityIcon).HasColumnName("community_icon");

                entity.Property(e => e.CommunityId).HasColumnName("community_id");

                entity.Property(e => e.CommunityLocal).HasColumnName("community_local");

                entity.Property(e => e.CommunityName)
                    .HasMaxLength(20)
                    .HasColumnName("community_name");

                entity.Property(e => e.CommunityNsfw).HasColumnName("community_nsfw");

                entity.Property(e => e.CommunityRemoved).HasColumnName("community_removed");

                entity.Property(e => e.CreatorActorId)
                    .HasMaxLength(255)
                    .HasColumnName("creator_actor_id");

                entity.Property(e => e.CreatorAvatar).HasColumnName("creator_avatar");

                entity.Property(e => e.CreatorCommunityTags)
                    .HasColumnType("jsonb")
                    .HasColumnName("creator_community_tags");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.CreatorLocal).HasColumnName("creator_local");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(20)
                    .HasColumnName("creator_name");

                entity.Property(e => e.CreatorPreferredUsername)
                    .HasMaxLength(20)
                    .HasColumnName("creator_preferred_username");

                entity.Property(e => e.CreatorPublished)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("creator_published");

                entity.Property(e => e.CreatorTags)
                    .HasColumnType("jsonb")
                    .HasColumnName("creator_tags");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Downvotes).HasColumnName("downvotes");

                entity.Property(e => e.EmbedDescription).HasColumnName("embed_description");

                entity.Property(e => e.EmbedHtml).HasColumnName("embed_html");

                entity.Property(e => e.EmbedTitle).HasColumnName("embed_title");

                entity.Property(e => e.HotRank).HasColumnName("hot_rank");

                entity.Property(e => e.HotRankActive).HasColumnName("hot_rank_active");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Local).HasColumnName("local");

                entity.Property(e => e.Locked).HasColumnName("locked");

                entity.Property(e => e.MyVote).HasColumnName("my_vote");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.Property(e => e.NewestActivityTime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("newest_activity_time");

                entity.Property(e => e.Nsfw).HasColumnName("nsfw");

                entity.Property(e => e.NumberOfComments).HasColumnName("number_of_comments");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published");

                entity.Property(e => e.Read).HasColumnName("read");

                entity.Property(e => e.Removed).HasColumnName("removed");

                entity.Property(e => e.Saved).HasColumnName("saved");

                entity.Property(e => e.Score).HasColumnName("score");

                entity.Property(e => e.Stickied).HasColumnName("stickied");

                entity.Property(e => e.Subscribed).HasColumnName("subscribed");

                entity.Property(e => e.ThumbnailUrl).HasColumnName("thumbnail_url");

                entity.Property(e => e.Updated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated");

                entity.Property(e => e.Upvotes).HasColumnName("upvotes");

                entity.Property(e => e.Url).HasColumnName("url");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<PrivateMessage>(entity =>
            {
                entity.ToTable("private_message");

                entity.HasIndex(e => e.ApId, "idx_private_message_ap_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApId)
                    .HasMaxLength(255)
                    .HasColumnName("ap_id")
                    .HasDefaultValueSql("generate_unique_changeme()");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Local)
                    .IsRequired()
                    .HasColumnName("local")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Read).HasColumnName("read");

                entity.Property(e => e.RecipientId).HasColumnName("recipient_id");

                entity.Property(e => e.Updated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated");

                entity.HasOne(d => d.Creator)
                    .WithMany(p => p.PrivateMessageCreators)
                    .HasForeignKey(d => d.CreatorId)
                    .HasConstraintName("private_message_creator_id_fkey");

                entity.HasOne(d => d.Recipient)
                    .WithMany(p => p.PrivateMessageRecipients)
                    .HasForeignKey(d => d.RecipientId)
                    .HasConstraintName("private_message_recipient_id_fkey");
            });

            modelBuilder.Entity<PrivateMessageView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("private_message_view");

                entity.Property(e => e.ApId)
                    .HasMaxLength(255)
                    .HasColumnName("ap_id");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.CreatorActorId)
                    .HasMaxLength(255)
                    .HasColumnName("creator_actor_id");

                entity.Property(e => e.CreatorAvatar).HasColumnName("creator_avatar");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.CreatorLocal).HasColumnName("creator_local");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(20)
                    .HasColumnName("creator_name");

                entity.Property(e => e.CreatorPreferredUsername)
                    .HasMaxLength(20)
                    .HasColumnName("creator_preferred_username");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Local).HasColumnName("local");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published");

                entity.Property(e => e.Read).HasColumnName("read");

                entity.Property(e => e.RecipientActorId)
                    .HasMaxLength(255)
                    .HasColumnName("recipient_actor_id");

                entity.Property(e => e.RecipientAvatar).HasColumnName("recipient_avatar");

                entity.Property(e => e.RecipientId).HasColumnName("recipient_id");

                entity.Property(e => e.RecipientLocal).HasColumnName("recipient_local");

                entity.Property(e => e.RecipientName)
                    .HasMaxLength(20)
                    .HasColumnName("recipient_name");

                entity.Property(e => e.RecipientPreferredUsername)
                    .HasMaxLength(20)
                    .HasColumnName("recipient_preferred_username");

                entity.Property(e => e.Updated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated");
            });

            modelBuilder.Entity<ReplyFastView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("reply_fast_view", "hexbear");

                entity.Property(e => e.ApId)
                    .HasMaxLength(255)
                    .HasColumnName("ap_id");

                entity.Property(e => e.Banned).HasColumnName("banned");

                entity.Property(e => e.BannedFromCommunity).HasColumnName("banned_from_community");

                entity.Property(e => e.CommunityActorId)
                    .HasMaxLength(255)
                    .HasColumnName("community_actor_id");

                entity.Property(e => e.CommunityIcon).HasColumnName("community_icon");

                entity.Property(e => e.CommunityId).HasColumnName("community_id");

                entity.Property(e => e.CommunityLocal).HasColumnName("community_local");

                entity.Property(e => e.CommunityName)
                    .HasMaxLength(20)
                    .HasColumnName("community_name");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.CreatorActorId)
                    .HasMaxLength(255)
                    .HasColumnName("creator_actor_id");

                entity.Property(e => e.CreatorAvatar).HasColumnName("creator_avatar");

                entity.Property(e => e.CreatorCommunityTags)
                    .HasColumnType("jsonb")
                    .HasColumnName("creator_community_tags");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.CreatorLocal).HasColumnName("creator_local");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(20)
                    .HasColumnName("creator_name");

                entity.Property(e => e.CreatorPreferredUsername)
                    .HasMaxLength(20)
                    .HasColumnName("creator_preferred_username");

                entity.Property(e => e.CreatorPublished)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("creator_published");

                entity.Property(e => e.CreatorTags)
                    .HasColumnType("jsonb")
                    .HasColumnName("creator_tags");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Downvotes).HasColumnName("downvotes");

                entity.Property(e => e.HotRank).HasColumnName("hot_rank");

                entity.Property(e => e.HotRankActive).HasColumnName("hot_rank_active");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Local).HasColumnName("local");

                entity.Property(e => e.MyVote).HasColumnName("my_vote");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.PostName)
                    .HasMaxLength(200)
                    .HasColumnName("post_name");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published");

                entity.Property(e => e.Read).HasColumnName("read");

                entity.Property(e => e.RecipientId).HasColumnName("recipient_id");

                entity.Property(e => e.Removed).HasColumnName("removed");

                entity.Property(e => e.Saved).HasColumnName("saved");

                entity.Property(e => e.Score).HasColumnName("score");

                entity.Property(e => e.Subscribed).HasColumnName("subscribed");

                entity.Property(e => e.Updated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated");

                entity.Property(e => e.Upvotes).HasColumnName("upvotes");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<ReplyFastView1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("reply_fast_view");

                entity.Property(e => e.ApId)
                    .HasMaxLength(255)
                    .HasColumnName("ap_id");

                entity.Property(e => e.Banned).HasColumnName("banned");

                entity.Property(e => e.BannedFromCommunity).HasColumnName("banned_from_community");

                entity.Property(e => e.CommunityActorId)
                    .HasMaxLength(255)
                    .HasColumnName("community_actor_id");

                entity.Property(e => e.CommunityIcon).HasColumnName("community_icon");

                entity.Property(e => e.CommunityId).HasColumnName("community_id");

                entity.Property(e => e.CommunityLocal).HasColumnName("community_local");

                entity.Property(e => e.CommunityName)
                    .HasMaxLength(20)
                    .HasColumnName("community_name");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.CreatorActorId)
                    .HasMaxLength(255)
                    .HasColumnName("creator_actor_id");

                entity.Property(e => e.CreatorAvatar).HasColumnName("creator_avatar");

                entity.Property(e => e.CreatorCommunityTags)
                    .HasColumnType("jsonb")
                    .HasColumnName("creator_community_tags");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.CreatorLocal).HasColumnName("creator_local");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(20)
                    .HasColumnName("creator_name");

                entity.Property(e => e.CreatorPreferredUsername)
                    .HasMaxLength(20)
                    .HasColumnName("creator_preferred_username");

                entity.Property(e => e.CreatorPublished)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("creator_published");

                entity.Property(e => e.CreatorTags)
                    .HasColumnType("jsonb")
                    .HasColumnName("creator_tags");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Downvotes).HasColumnName("downvotes");

                entity.Property(e => e.HotRank).HasColumnName("hot_rank");

                entity.Property(e => e.HotRankActive).HasColumnName("hot_rank_active");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Local).HasColumnName("local");

                entity.Property(e => e.MyVote).HasColumnName("my_vote");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.PostName)
                    .HasMaxLength(200)
                    .HasColumnName("post_name");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published");

                entity.Property(e => e.Read).HasColumnName("read");

                entity.Property(e => e.RecipientId).HasColumnName("recipient_id");

                entity.Property(e => e.Removed).HasColumnName("removed");

                entity.Property(e => e.Saved).HasColumnName("saved");

                entity.Property(e => e.Score).HasColumnName("score");

                entity.Property(e => e.Subscribed).HasColumnName("subscribed");

                entity.Property(e => e.Updated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated");

                entity.Property(e => e.Upvotes).HasColumnName("upvotes");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<Site>(entity =>
            {
                entity.ToTable("site");

                entity.HasIndex(e => e.Name, "site_name_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AutosubscribeComms)
                    .HasColumnName("autosubscribe_comms")
                    .HasDefaultValueSql("'{}'::integer[]");

                entity.Property(e => e.Banner).HasColumnName("banner");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EnableCreateCommunities)
                    .IsRequired()
                    .HasColumnName("enable_create_communities")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.EnableDownvotes)
                    .IsRequired()
                    .HasColumnName("enable_downvotes")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.EnableNsfw)
                    .IsRequired()
                    .HasColumnName("enable_nsfw")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Icon).HasColumnName("icon");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .HasColumnName("name");

                entity.Property(e => e.OpenRegistration)
                    .IsRequired()
                    .HasColumnName("open_registration")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Updated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated");

                entity.HasOne(d => d.Creator)
                    .WithMany(p => p.Sites)
                    .HasForeignKey(d => d.CreatorId)
                    .HasConstraintName("site_creator_id_fkey");
            });

            modelBuilder.Entity<SiteView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("site_view");

                entity.Property(e => e.AutosubscribeComms).HasColumnName("autosubscribe_comms");

                entity.Property(e => e.Banner).HasColumnName("banner");

                entity.Property(e => e.CreatorAvatar).HasColumnName("creator_avatar");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(20)
                    .HasColumnName("creator_name");

                entity.Property(e => e.CreatorPreferredUsername)
                    .HasMaxLength(20)
                    .HasColumnName("creator_preferred_username");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EnableCreateCommunities).HasColumnName("enable_create_communities");

                entity.Property(e => e.EnableDownvotes).HasColumnName("enable_downvotes");

                entity.Property(e => e.EnableNsfw).HasColumnName("enable_nsfw");

                entity.Property(e => e.Icon).HasColumnName("icon");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .HasColumnName("name");

                entity.Property(e => e.NumberOfComments).HasColumnName("number_of_comments");

                entity.Property(e => e.NumberOfCommunities).HasColumnName("number_of_communities");

                entity.Property(e => e.NumberOfPosts).HasColumnName("number_of_posts");

                entity.Property(e => e.NumberOfUsers).HasColumnName("number_of_users");

                entity.Property(e => e.OpenRegistration).HasColumnName("open_registration");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published");

                entity.Property(e => e.Updated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user_");

                entity.HasIndex(e => e.ActorId, "idx_user_actor_id")
                    .IsUnique();

                entity.HasIndex(e => e.Email, "user__email_key")
                    .IsUnique();

                entity.HasIndex(e => e.MatrixUserId, "user__matrix_user_id_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActorId)
                    .HasMaxLength(255)
                    .HasColumnName("actor_id")
                    .HasDefaultValueSql("generate_unique_changeme()");

                entity.Property(e => e.Admin).HasColumnName("admin");

                entity.Property(e => e.Avatar).HasColumnName("avatar");

                entity.Property(e => e.Banned).HasColumnName("banned");

                entity.Property(e => e.Banner).HasColumnName("banner");

                entity.Property(e => e.Bio).HasColumnName("bio");

                entity.Property(e => e.DefaultListingType)
                    .HasColumnName("default_listing_type")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.DefaultSortType).HasColumnName("default_sort_type");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Has2fa).HasColumnName("has_2fa");

                entity.Property(e => e.InboxDisabled).HasColumnName("inbox_disabled");

                entity.Property(e => e.Lang)
                    .HasMaxLength(20)
                    .HasColumnName("lang")
                    .HasDefaultValueSql("'browser'::character varying");

                entity.Property(e => e.LastRefreshedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_refreshed_at")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Local)
                    .IsRequired()
                    .HasColumnName("local")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.MatrixUserId).HasColumnName("matrix_user_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .HasColumnName("name");

                entity.Property(e => e.PasswordEncrypted).HasColumnName("password_encrypted");

                entity.Property(e => e.PreferredUsername)
                    .HasMaxLength(20)
                    .HasColumnName("preferred_username");

                entity.Property(e => e.PrivateKey).HasColumnName("private_key");

                entity.Property(e => e.PublicKey).HasColumnName("public_key");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.SendNotificationsToEmail).HasColumnName("send_notifications_to_email");

                entity.Property(e => e.ShowAvatars)
                    .IsRequired()
                    .HasColumnName("show_avatars")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ShowNsfw).HasColumnName("show_nsfw");

                entity.Property(e => e.Sitemod).HasColumnName("sitemod");

                entity.Property(e => e.Theme)
                    .HasMaxLength(20)
                    .HasColumnName("theme")
                    .HasDefaultValueSql("'darkly'::character varying");

                entity.Property(e => e.Updated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated");
            });

            modelBuilder.Entity<UserBan>(entity =>
            {
                entity.ToTable("user_ban");

                entity.HasIndex(e => e.UserId, "user_ban_user_id_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.UserBan)
                    .HasForeignKey<UserBan>(d => d.UserId)
                    .HasConstraintName("user_ban_user_id_fkey");
            });

            modelBuilder.Entity<UserFast>(entity =>
            {
                entity.ToTable("user_fast");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ActorId)
                    .HasMaxLength(255)
                    .HasColumnName("actor_id");

                entity.Property(e => e.Admin).HasColumnName("admin");

                entity.Property(e => e.Avatar).HasColumnName("avatar");

                entity.Property(e => e.Banned).HasColumnName("banned");

                entity.Property(e => e.Banner).HasColumnName("banner");

                entity.Property(e => e.Bio).HasColumnName("bio");

                entity.Property(e => e.CommentScore).HasColumnName("comment_score");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Local).HasColumnName("local");

                entity.Property(e => e.MatrixUserId).HasColumnName("matrix_user_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .HasColumnName("name");

                entity.Property(e => e.NumberOfComments).HasColumnName("number_of_comments");

                entity.Property(e => e.NumberOfPosts).HasColumnName("number_of_posts");

                entity.Property(e => e.PostScore).HasColumnName("post_score");

                entity.Property(e => e.PreferredUsername)
                    .HasMaxLength(20)
                    .HasColumnName("preferred_username");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published");

                entity.Property(e => e.SendNotificationsToEmail).HasColumnName("send_notifications_to_email");

                entity.Property(e => e.ShowAvatars).HasColumnName("show_avatars");

                entity.Property(e => e.Sitemod).HasColumnName("sitemod");
            });

            modelBuilder.Entity<UserMention>(entity =>
            {
                entity.ToTable("user_mention");

                entity.HasIndex(e => new { e.RecipientId, e.CommentId }, "user_mention_recipient_id_comment_id_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CommentId).HasColumnName("comment_id");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Read).HasColumnName("read");

                entity.Property(e => e.RecipientId).HasColumnName("recipient_id");

                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.UserMentions)
                    .HasForeignKey(d => d.CommentId)
                    .HasConstraintName("user_mention_comment_id_fkey");

                entity.HasOne(d => d.Recipient)
                    .WithMany(p => p.UserMentions)
                    .HasForeignKey(d => d.RecipientId)
                    .HasConstraintName("user_mention_recipient_id_fkey");
            });

            modelBuilder.Entity<UserMentionFastView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("user_mention_fast_view", "hexbear");

                entity.Property(e => e.ApId)
                    .HasMaxLength(255)
                    .HasColumnName("ap_id");

                entity.Property(e => e.Banned).HasColumnName("banned");

                entity.Property(e => e.BannedFromCommunity).HasColumnName("banned_from_community");

                entity.Property(e => e.CommunityActorId)
                    .HasMaxLength(255)
                    .HasColumnName("community_actor_id");

                entity.Property(e => e.CommunityIcon).HasColumnName("community_icon");

                entity.Property(e => e.CommunityId).HasColumnName("community_id");

                entity.Property(e => e.CommunityLocal).HasColumnName("community_local");

                entity.Property(e => e.CommunityName)
                    .HasMaxLength(20)
                    .HasColumnName("community_name");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.CreatorActorId)
                    .HasMaxLength(255)
                    .HasColumnName("creator_actor_id");

                entity.Property(e => e.CreatorAvatar).HasColumnName("creator_avatar");

                entity.Property(e => e.CreatorCommunityTags)
                    .HasColumnType("jsonb")
                    .HasColumnName("creator_community_tags");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.CreatorLocal).HasColumnName("creator_local");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(20)
                    .HasColumnName("creator_name");

                entity.Property(e => e.CreatorPreferredUsername)
                    .HasMaxLength(20)
                    .HasColumnName("creator_preferred_username");

                entity.Property(e => e.CreatorPublished)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("creator_published");

                entity.Property(e => e.CreatorTags)
                    .HasColumnType("jsonb")
                    .HasColumnName("creator_tags");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Downvotes).HasColumnName("downvotes");

                entity.Property(e => e.HotRank).HasColumnName("hot_rank");

                entity.Property(e => e.HotRankActive).HasColumnName("hot_rank_active");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Local).HasColumnName("local");

                entity.Property(e => e.MyVote).HasColumnName("my_vote");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.PostName)
                    .HasMaxLength(200)
                    .HasColumnName("post_name");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published");

                entity.Property(e => e.Read).HasColumnName("read");

                entity.Property(e => e.RecipientActorId)
                    .HasMaxLength(255)
                    .HasColumnName("recipient_actor_id");

                entity.Property(e => e.RecipientId).HasColumnName("recipient_id");

                entity.Property(e => e.RecipientLocal).HasColumnName("recipient_local");

                entity.Property(e => e.Removed).HasColumnName("removed");

                entity.Property(e => e.Saved).HasColumnName("saved");

                entity.Property(e => e.Score).HasColumnName("score");

                entity.Property(e => e.Subscribed).HasColumnName("subscribed");

                entity.Property(e => e.Updated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated");

                entity.Property(e => e.Upvotes).HasColumnName("upvotes");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserMentionId).HasColumnName("user_mention_id");
            });

            modelBuilder.Entity<UserMentionFastView1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("user_mention_fast_view");

                entity.Property(e => e.Banned).HasColumnName("banned");

                entity.Property(e => e.BannedFromCommunity).HasColumnName("banned_from_community");

                entity.Property(e => e.CommunityActorId)
                    .HasMaxLength(255)
                    .HasColumnName("community_actor_id");

                entity.Property(e => e.CommunityIcon).HasColumnName("community_icon");

                entity.Property(e => e.CommunityId).HasColumnName("community_id");

                entity.Property(e => e.CommunityLocal).HasColumnName("community_local");

                entity.Property(e => e.CommunityName)
                    .HasMaxLength(20)
                    .HasColumnName("community_name");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.CreatorActorId)
                    .HasMaxLength(255)
                    .HasColumnName("creator_actor_id");

                entity.Property(e => e.CreatorAvatar).HasColumnName("creator_avatar");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.CreatorLocal).HasColumnName("creator_local");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(20)
                    .HasColumnName("creator_name");

                entity.Property(e => e.CreatorPreferredUsername)
                    .HasMaxLength(20)
                    .HasColumnName("creator_preferred_username");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Downvotes).HasColumnName("downvotes");

                entity.Property(e => e.HotRank).HasColumnName("hot_rank");

                entity.Property(e => e.HotRankActive).HasColumnName("hot_rank_active");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MyVote).HasColumnName("my_vote");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.PostName)
                    .HasMaxLength(200)
                    .HasColumnName("post_name");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published");

                entity.Property(e => e.Read).HasColumnName("read");

                entity.Property(e => e.RecipientActorId)
                    .HasMaxLength(255)
                    .HasColumnName("recipient_actor_id");

                entity.Property(e => e.RecipientId).HasColumnName("recipient_id");

                entity.Property(e => e.RecipientLocal).HasColumnName("recipient_local");

                entity.Property(e => e.Removed).HasColumnName("removed");

                entity.Property(e => e.Saved).HasColumnName("saved");

                entity.Property(e => e.Score).HasColumnName("score");

                entity.Property(e => e.Updated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated");

                entity.Property(e => e.Upvotes).HasColumnName("upvotes");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserMentionId).HasColumnName("user_mention_id");
            });

            modelBuilder.Entity<UserMentionView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("user_mention_view");

                entity.Property(e => e.Banned).HasColumnName("banned");

                entity.Property(e => e.BannedFromCommunity).HasColumnName("banned_from_community");

                entity.Property(e => e.CommunityActorId)
                    .HasMaxLength(255)
                    .HasColumnName("community_actor_id");

                entity.Property(e => e.CommunityIcon).HasColumnName("community_icon");

                entity.Property(e => e.CommunityId).HasColumnName("community_id");

                entity.Property(e => e.CommunityLocal).HasColumnName("community_local");

                entity.Property(e => e.CommunityName)
                    .HasMaxLength(20)
                    .HasColumnName("community_name");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.CreatorActorId)
                    .HasMaxLength(255)
                    .HasColumnName("creator_actor_id");

                entity.Property(e => e.CreatorAvatar).HasColumnName("creator_avatar");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.CreatorLocal).HasColumnName("creator_local");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(20)
                    .HasColumnName("creator_name");

                entity.Property(e => e.CreatorPreferredUsername)
                    .HasMaxLength(20)
                    .HasColumnName("creator_preferred_username");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Downvotes).HasColumnName("downvotes");

                entity.Property(e => e.HotRank).HasColumnName("hot_rank");

                entity.Property(e => e.HotRankActive).HasColumnName("hot_rank_active");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MyVote).HasColumnName("my_vote");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.PostName)
                    .HasMaxLength(200)
                    .HasColumnName("post_name");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published");

                entity.Property(e => e.Read).HasColumnName("read");

                entity.Property(e => e.RecipientActorId)
                    .HasMaxLength(255)
                    .HasColumnName("recipient_actor_id");

                entity.Property(e => e.RecipientId).HasColumnName("recipient_id");

                entity.Property(e => e.RecipientLocal).HasColumnName("recipient_local");

                entity.Property(e => e.Removed).HasColumnName("removed");

                entity.Property(e => e.Saved).HasColumnName("saved");

                entity.Property(e => e.Score).HasColumnName("score");

                entity.Property(e => e.Updated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated");

                entity.Property(e => e.Upvotes).HasColumnName("upvotes");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserMentionId).HasColumnName("user_mention_id");
            });

            modelBuilder.Entity<UserStat>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("user_stat_pkey");

                entity.ToTable("user_stat", "hexbear");

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("user_id");

                entity.Property(e => e.CommentScore).HasColumnName("comment_score");

                entity.Property(e => e.NumberOfComments).HasColumnName("number_of_comments");

                entity.Property(e => e.NumberOfPosts).HasColumnName("number_of_posts");

                entity.Property(e => e.PostScore).HasColumnName("post_score");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.UserStat)
                    .HasForeignKey<UserStat>(d => d.UserId)
                    .HasConstraintName("user_stat_user_id_fkey");
            });

            modelBuilder.Entity<UserTag>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("user_tag_pkey");

                entity.ToTable("user_tag");

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("user_id");

                entity.Property(e => e.Tags)
                    .HasColumnType("jsonb")
                    .HasColumnName("tags");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.UserTag)
                    .HasForeignKey<UserTag>(d => d.UserId)
                    .HasConstraintName("user_tag_user_id_fkey");
            });

            modelBuilder.Entity<UserToken>(entity =>
            {
                entity.ToTable("user_tokens", "hexbear");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.ExpiresAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("expires_at")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.IsRevoked).HasColumnName("is_revoked");

                entity.Property(e => e.RenewedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("renewed_at")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.TokenHash).HasColumnName("token_hash");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserTokens)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("user_tokens_user_id_fkey");
            });

            modelBuilder.Entity<UserView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("user_view", "hexbear");

                entity.Property(e => e.ActorId)
                    .HasMaxLength(255)
                    .HasColumnName("actor_id");

                entity.Property(e => e.Admin).HasColumnName("admin");

                entity.Property(e => e.Avatar).HasColumnName("avatar");

                entity.Property(e => e.Banned).HasColumnName("banned");

                entity.Property(e => e.Banner).HasColumnName("banner");

                entity.Property(e => e.Bio).HasColumnName("bio");

                entity.Property(e => e.CommentScore).HasColumnName("comment_score");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Has2fa).HasColumnName("has_2fa");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InboxDisabled).HasColumnName("inbox_disabled");

                entity.Property(e => e.Local).HasColumnName("local");

                entity.Property(e => e.MatrixUserId).HasColumnName("matrix_user_id");

                entity.Property(e => e.Moderator).HasColumnName("moderator");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .HasColumnName("name");

                entity.Property(e => e.NumberOfComments).HasColumnName("number_of_comments");

                entity.Property(e => e.NumberOfPosts).HasColumnName("number_of_posts");

                entity.Property(e => e.PostScore).HasColumnName("post_score");

                entity.Property(e => e.PreferredUsername)
                    .HasMaxLength(20)
                    .HasColumnName("preferred_username");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published");

                entity.Property(e => e.SendNotificationsToEmail).HasColumnName("send_notifications_to_email");

                entity.Property(e => e.ShowAvatars).HasColumnName("show_avatars");

                entity.Property(e => e.Sitemod).HasColumnName("sitemod");
            });

            modelBuilder.Entity<UserView1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("user_view");

                entity.Property(e => e.ActorId)
                    .HasMaxLength(255)
                    .HasColumnName("actor_id");

                entity.Property(e => e.Admin).HasColumnName("admin");

                entity.Property(e => e.Avatar).HasColumnName("avatar");

                entity.Property(e => e.Banned).HasColumnName("banned");

                entity.Property(e => e.Banner).HasColumnName("banner");

                entity.Property(e => e.Bio).HasColumnName("bio");

                entity.Property(e => e.CommentScore).HasColumnName("comment_score");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Local).HasColumnName("local");

                entity.Property(e => e.MatrixUserId).HasColumnName("matrix_user_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .HasColumnName("name");

                entity.Property(e => e.NumberOfComments).HasColumnName("number_of_comments");

                entity.Property(e => e.NumberOfPosts).HasColumnName("number_of_posts");

                entity.Property(e => e.PostScore).HasColumnName("post_score");

                entity.Property(e => e.PreferredUsername)
                    .HasMaxLength(20)
                    .HasColumnName("preferred_username");

                entity.Property(e => e.Published)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("published");

                entity.Property(e => e.SendNotificationsToEmail).HasColumnName("send_notifications_to_email");

                entity.Property(e => e.ShowAvatars).HasColumnName("show_avatars");

                entity.Property(e => e.Sitemod).HasColumnName("sitemod");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
