using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.hexbear
{
    public partial class PostReportView
    {
        public Guid? Id { get; set; }
        public DateTime? Time { get; set; }
        public string Reason { get; set; }
        public bool? Resolved { get; set; }
        public int? UserId { get; set; }
        public int? PostId { get; set; }
        public string PostName { get; set; }
        public string PostUrl { get; set; }
        public string PostBody { get; set; }
        public DateTime? PostTime { get; set; }
        public int? CommunityId { get; set; }
        public string UserName { get; set; }
        public int? CreatorId { get; set; }
        public string CreatorName { get; set; }
    }
}
