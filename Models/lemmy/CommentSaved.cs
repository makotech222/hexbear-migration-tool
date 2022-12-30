using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.lemmy;

public partial class CommentSaved
{
    public int Id { get; set; }

    public int CommentId { get; set; }

    public int PersonId { get; set; }

    public DateTime Published { get; set; }

    public virtual Comment Comment { get; set; }

    public virtual Person Person { get; set; }
}
