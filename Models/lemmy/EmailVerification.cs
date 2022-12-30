using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.lemmy;

public partial class EmailVerification
{
    public int Id { get; set; }

    public int LocalUserId { get; set; }

    public string Email { get; set; }

    public string VerificationToken { get; set; }

    public DateTime Published { get; set; }

    public virtual LocalUser LocalUser { get; set; }
}
