using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.hexbear
{
    public partial class Site
    {
        public int Id { get; set; }
        public string Name { get; set; } = null;
        public string Description { get; set; }
        public int CreatorId { get; set; }
        public DateTime Published { get; set; }
        public DateTime? Updated { get; set; }
        public bool? EnableDownvotes { get; set; }
        public bool? OpenRegistration { get; set; }
        public bool? EnableNsfw { get; set; }
        public bool? EnableCreateCommunities { get; set; }
        public string Icon { get; set; }
        public string Banner { get; set; }
        public int[] AutosubscribeComms { get; set; } = null;

        public virtual User Creator { get; set; } = null;
    }
}
