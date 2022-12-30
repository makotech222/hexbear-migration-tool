using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.hexbear
{
    public partial class Activity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Data { get; set; } = null;
        public bool? Local { get; set; }
        public DateTime Published { get; set; }
        public DateTime? Updated { get; set; }

        public virtual User User { get; set; } = null;
    }
}
