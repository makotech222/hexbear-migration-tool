using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.lemmy;

public partial class PrivateMessage
{
    public int Id { get; set; }

    public int CreatorId { get; set; }

    public int RecipientId { get; set; }

    public string Content { get; set; }

    public bool Deleted { get; set; }

    public bool Read { get; set; }

    public DateTime Published { get; set; }

    public DateTime? Updated { get; set; }

    public string ApId { get; set; }

    public bool? Local { get; set; }

    public virtual Person Creator { get; set; }

    public virtual ICollection<PrivateMessageReport> PrivateMessageReports { get; } = new List<PrivateMessageReport>();

    public virtual Person Recipient { get; set; }
}
