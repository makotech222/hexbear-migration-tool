using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.hexbear
{
    public partial class SiteView
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? CreatorId { get; set; }
        public DateTime? Published { get; set; }
        public DateTime? Updated { get; set; }
        public bool? EnableDownvotes { get; set; }
        public bool? OpenRegistration { get; set; }
        public bool? EnableNsfw { get; set; }
        public bool? EnableCreateCommunities { get; set; }
        public string Icon { get; set; }
        public string Banner { get; set; }
        public int[] AutosubscribeComms { get; set; }
        public string CreatorName { get; set; }
        public string CreatorPreferredUsername { get; set; }
        public string CreatorAvatar { get; set; }
        public long? NumberOfUsers { get; set; }
        public long? NumberOfPosts { get; set; }
        public long? NumberOfComments { get; set; }
        public long? NumberOfCommunities { get; set; }
    }
}
