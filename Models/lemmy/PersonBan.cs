using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.lemmy;

public partial class PersonBan
{
    public int Id { get; set; }

    public int PersonId { get; set; }

    public DateTime Published { get; set; }

    public virtual Person Person { get; set; }
}
