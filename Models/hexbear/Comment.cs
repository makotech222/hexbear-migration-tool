using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.hexbear
{
    public partial class Comment
    {
        public Comment()
        {
            CommentLikes = new HashSet<CommentLike>();
            CommentReports = new HashSet<CommentReport>();
            CommentSaveds = new HashSet<CommentSaved>();
            InverseParent = new HashSet<Comment>();
            ModRemoveComments = new HashSet<ModRemoveComment>();
            UserMentions = new HashSet<UserMention>();
        }

        public int Id { get; set; }
        public int CreatorId { get; set; }
        public int PostId { get; set; }
        public int? ParentId { get; set; }
        public string Content { get; set; } = null;
        public bool Removed { get; set; }
        public bool Read { get; set; }
        public DateTime Published { get; set; }
        public DateTime? Updated { get; set; }
        public bool Deleted { get; set; }
        public string ApId { get; set; } = null;
        public bool? Local { get; set; }

        public virtual User Creator { get; set; } = null;
        public virtual Comment Parent { get; set; }
        public virtual Post Post { get; set; } = null;
        public virtual CommentStat CommentStat { get; set; }
        public virtual ICollection<CommentLike> CommentLikes { get; set; }
        public virtual ICollection<CommentReport> CommentReports { get; set; }
        public virtual ICollection<CommentSaved> CommentSaveds { get; set; }
        public virtual ICollection<Comment> InverseParent { get; set; }
        public virtual ICollection<ModRemoveComment> ModRemoveComments { get; set; }
        public virtual ICollection<UserMention> UserMentions { get; set; }
    }
}
