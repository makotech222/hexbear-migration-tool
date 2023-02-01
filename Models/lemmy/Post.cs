using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.lemmy;

public partial class Post
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Url { get; set; }

    public string Body { get; set; }

    public int CreatorId { get; set; }

    public int CommunityId { get; set; }

    public bool Removed { get; set; }

    public bool Locked { get; set; }

    public DateTime Published { get; set; }

    public DateTime? Updated { get; set; }

    public bool Deleted { get; set; }

    public bool Nsfw { get; set; }

    public string EmbedTitle { get; set; }

    public string EmbedDescription { get; set; }

    public string ThumbnailUrl { get; set; }

    public string ApId { get; set; }

    public bool? Local { get; set; }

    public string EmbedVideoUrl { get; set; }

    public int LanguageId { get; set; }

    public bool FeaturedCommunity { get; set; }

    public bool FeaturedLocal { get; set; }

    public virtual ICollection<AdminPurgeComment> AdminPurgeComments { get; } = new List<AdminPurgeComment>();

    public virtual ICollection<CommentLike> CommentLikes { get; } = new List<CommentLike>();

    public virtual Community Community { get; set; }

    public virtual Person Creator { get; set; }

    public virtual Language Language { get; set; }

    public virtual ICollection<ModFeaturePost> ModFeaturePosts { get; } = new List<ModFeaturePost>();

    public virtual ICollection<ModLockPost> ModLockPosts { get; } = new List<ModLockPost>();

    public virtual ICollection<ModRemovePost> ModRemovePosts { get; } = new List<ModRemovePost>();

    public virtual ICollection<PersonPostAggregate> PersonPostAggregates { get; } = new List<PersonPostAggregate>();

    public virtual PostAggregate PostAggregate { get; set; }

    public virtual ICollection<PostLike> PostLikes { get; } = new List<PostLike>();

    public virtual ICollection<PostRead> PostReads { get; } = new List<PostRead>();

    public virtual ICollection<PostReport> PostReports { get; } = new List<PostReport>();

    public virtual ICollection<PostSaved> PostSaveds { get; } = new List<PostSaved>();
}
