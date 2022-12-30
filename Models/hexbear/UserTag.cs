using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.hexbear
{
    public partial class UserTag
    {
        public int UserId { get; set; }
        public string Tags { get; set; } = null;

        public virtual User User { get; set; } = null;
    }
}
