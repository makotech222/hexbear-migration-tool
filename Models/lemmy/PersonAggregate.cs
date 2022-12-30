using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.lemmy;

public partial class PersonAggregate
{
    public int Id { get; set; }

    public int PersonId { get; set; }

    public long PostCount { get; set; }

    public long PostScore { get; set; }

    public long CommentCount { get; set; }

    public long CommentScore { get; set; }

    public virtual Person Person { get; set; }
}
