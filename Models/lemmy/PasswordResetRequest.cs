using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.lemmy;

public partial class PasswordResetRequest
{
    public int Id { get; set; }

    public string TokenEncrypted { get; set; }

    public DateTime Published { get; set; }

    public int LocalUserId { get; set; }

    public virtual LocalUser LocalUser { get; set; }
}
