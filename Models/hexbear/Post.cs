using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.hexbear
{
    public partial class Post
    {
        public Post()
        {
            CommentLikes = new HashSet<CommentLike>();
            Comments = new HashSet<Comment>();
            ModLockPosts = new HashSet<ModLockPost>();
            ModRemovePosts = new HashSet<ModRemovePost>();
            ModStickyPosts = new HashSet<ModStickyPost>();
            PostLikes = new HashSet<PostLike>();
            PostReads = new HashSet<PostRead>();
            PostReports = new HashSet<PostReport>();
            PostSaveds = new HashSet<PostSaved>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null;
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
        public bool Stickied { get; set; }
        public string EmbedTitle { get; set; }
        public string EmbedDescription { get; set; }
        public string EmbedHtml { get; set; }
        public string ThumbnailUrl { get; set; }
        public string ApId { get; set; } = null;
        public bool? Local { get; set; }
        public bool Featured { get; set; }

        public virtual Community Community { get; set; } = null;
        public virtual User Creator { get; set; } = null;
        public virtual PostStat PostStat { get; set; }
        public virtual ICollection<CommentLike> CommentLikes { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<ModLockPost> ModLockPosts { get; set; }
        public virtual ICollection<ModRemovePost> ModRemovePosts { get; set; }
        public virtual ICollection<ModStickyPost> ModStickyPosts { get; set; }
        public virtual ICollection<PostLike> PostLikes { get; set; }
        public virtual ICollection<PostRead> PostReads { get; set; }
        public virtual ICollection<PostReport> PostReports { get; set; }
        public virtual ICollection<PostSaved> PostSaveds { get; set; }
    }
}
