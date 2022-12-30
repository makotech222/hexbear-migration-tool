using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.hexbear
{
    public partial class UserToken
    {
        public Guid Id { get; set; }
        public int UserId { get; set; }
        public string TokenHash { get; set; } = null;
        public DateTime CreatedAt { get; set; }
        public DateTime ExpiresAt { get; set; }
        public DateTime RenewedAt { get; set; }
        public bool IsRevoked { get; set; }

        public virtual User User { get; set; } = null;
    }
}
