using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.lemmy;

public partial class CommentReply
{
    public int Id { get; set; }

    public int RecipientId { get; set; }

    public int CommentId { get; set; }

    public bool Read { get; set; }

    public DateTime Published { get; set; }

    public virtual Comment Comment { get; set; }

    public virtual Person Recipient { get; set; }
}
