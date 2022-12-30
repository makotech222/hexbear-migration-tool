using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.lemmy;

public partial class PostRead
{
    public int Id { get; set; }

    public int PostId { get; set; }

    public int PersonId { get; set; }

    public DateTime Published { get; set; }

    public virtual Person Person { get; set; }

    public virtual Post Post { get; set; }
}
