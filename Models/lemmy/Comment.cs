using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace hexbear_migration_tool.Models.lemmy;

public partial class Comment
{
    public int Id { get; set; }

    public int CreatorId { get; set; }

    public int PostId { get; set; }

    public string Content { get; set; }

    public bool Removed { get; set; }

    public DateTime Published { get; set; }

    public DateTime? Updated { get; set; }

    public bool Deleted { get; set; }

    public string ApId { get; set; }

    public bool? Local { get; set; }

    public LTree Path { get; set; }

    public bool Distinguished { get; set; }

    public int LanguageId { get; set; }

    public virtual CommentAggregate CommentAggregate { get; set; }

    public virtual ICollection<CommentLike> CommentLikes { get; } = new List<CommentLike>();

    public virtual ICollection<CommentReply> CommentReplies { get; } = new List<CommentReply>();

    public virtual ICollection<CommentReport> CommentReports { get; } = new List<CommentReport>();

    public virtual ICollection<CommentSaved> CommentSaveds { get; } = new List<CommentSaved>();

    public virtual Language Language { get; set; }

    public virtual ICollection<ModRemoveComment> ModRemoveComments { get; } = new List<ModRemoveComment>();

    public virtual ICollection<PersonMention> PersonMentions { get; } = new List<PersonMention>();
}
