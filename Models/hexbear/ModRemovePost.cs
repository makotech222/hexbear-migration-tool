using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.hexbear
{
    public partial class ModRemovePost
    {
        public int Id { get; set; }
        public int ModUserId { get; set; }
        public int PostId { get; set; }
        public string Reason { get; set; }
        public bool? Removed { get; set; }
        public DateTime When { get; set; }

        public virtual User ModUser { get; set; } = null;
        public virtual Post Post { get; set; } = null;
    }
}
