using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.hexbear
{
    public partial class PostReport
    {
        public Guid Id { get; set; }
        public DateTime Time { get; set; }
        public string Reason { get; set; }
        public bool Resolved { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        public string PostName { get; set; } = null;
        public string PostUrl { get; set; }
        public string PostBody { get; set; }
        public DateTime PostTime { get; set; }

        public virtual Post Post { get; set; } = null;
        public virtual User User { get; set; } = null;
    }
}
