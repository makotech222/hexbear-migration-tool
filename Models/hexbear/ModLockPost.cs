using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.hexbear
{
    public partial class ModLockPost
    {
        public int Id { get; set; }
        public int ModUserId { get; set; }
        public int PostId { get; set; }
        public bool? Locked { get; set; }
        public DateTime When { get; set; }

        public virtual User ModUser { get; set; } = null;
        public virtual Post Post { get; set; } = null;
    }
}
