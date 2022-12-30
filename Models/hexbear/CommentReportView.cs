using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.hexbear
{
    public partial class CommentReportView
    {
        public Guid? Id { get; set; }
        public DateTime? Time { get; set; }
        public string Reason { get; set; }
        public bool? Resolved { get; set; }
        public int? UserId { get; set; }
        public int? CommentId { get; set; }
        public string CommentText { get; set; }
        public DateTime? CommentTime { get; set; }
        public int? PostId { get; set; }
        public int? CommunityId { get; set; }
        public string UserName { get; set; }
        public int? CreatorId { get; set; }
        public string CreatorName { get; set; }
    }
}
