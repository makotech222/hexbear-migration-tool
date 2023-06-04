﻿using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.lemmy;

public partial class LocalUser
{
    public int Id { get; set; }

    public int PersonId { get; set; }

    public string PasswordEncrypted { get; set; }

    public string Email { get; set; }

    public bool ShowNsfw { get; set; }

    public string Theme { get; set; }

    public string InterfaceLanguage { get; set; }

    public bool? ShowAvatars { get; set; }

    public bool SendNotificationsToEmail { get; set; }

    public DateTime ValidatorTime { get; set; }

    public bool? ShowScores { get; set; }

    public bool? ShowBotAccounts { get; set; }

    public bool? ShowReadPosts { get; set; }

    public bool ShowNewPostNotifs { get; set; }

    public bool EmailVerified { get; set; }

    public bool AcceptedApplication { get; set; }

    public string Totp2faSecret { get; set; }

    public string Totp2faUrl { get; set; }

    public virtual ICollection<EmailVerification> EmailVerifications { get; } = new List<EmailVerification>();

    public virtual ICollection<LocalUserLanguage> LocalUserLanguages { get; } = new List<LocalUserLanguage>();

    public virtual ICollection<PasswordResetRequest> PasswordResetRequests { get; } = new List<PasswordResetRequest>();

    public virtual Person Person { get; set; }

    public virtual RegistrationApplication RegistrationApplication { get; set; }
}
