using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.lemmy;

public partial class PersonBlock
{
    public int Id { get; set; }

    public int PersonId { get; set; }

    public int TargetId { get; set; }

    public DateTime Published { get; set; }

    public virtual Person Person { get; set; }

    public virtual Person Target { get; set; }
}
