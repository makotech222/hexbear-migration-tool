using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.hexbear
{
    public partial class PasswordResetRequest
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string TokenEncrypted { get; set; } = null;
        public DateTime Published { get; set; }

        public virtual User User { get; set; } = null;
    }
}
