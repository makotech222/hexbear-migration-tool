using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.lemmy;

public partial class Instance
{
    public int Id { get; set; }

    public string Domain { get; set; }

    public DateTime Published { get; set; }

    public DateTime? Updated { get; set; }

    public virtual ICollection<Community> Communities { get; } = new List<Community>();

    public virtual FederationAllowlist FederationAllowlist { get; set; }

    public virtual FederationBlocklist FederationBlocklist { get; set; }

    public virtual ICollection<Person> People { get; } = new List<Person>();

    public virtual Site Site { get; set; }
}
