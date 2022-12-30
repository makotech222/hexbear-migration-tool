using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.hexbear
{
    public partial class UserFast
    {
        public int Id { get; set; }
        public string ActorId { get; set; }
        public string Name { get; set; }
        public string PreferredUsername { get; set; }
        public string Avatar { get; set; }
        public string Banner { get; set; }
        public string Email { get; set; }
        public string MatrixUserId { get; set; }
        public string Bio { get; set; }
        public bool? Local { get; set; }
        public bool? Admin { get; set; }
        public bool? Sitemod { get; set; }
        public bool? Banned { get; set; }
        public bool? ShowAvatars { get; set; }
        public bool? SendNotificationsToEmail { get; set; }
        public DateTime? Published { get; set; }
        public long? NumberOfPosts { get; set; }
        public long? PostScore { get; set; }
        public long? NumberOfComments { get; set; }
        public long? CommentScore { get; set; }
    }
}
