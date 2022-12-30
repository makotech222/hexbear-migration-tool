using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.lemmy;

public partial class CommentAggregate
{
    public int Id { get; set; }

    public int CommentId { get; set; }

    public long Score { get; set; }

    public long Upvotes { get; set; }

    public long Downvotes { get; set; }

    public DateTime Published { get; set; }

    public int ChildCount { get; set; }

    public virtual Comment Comment { get; set; }
}
