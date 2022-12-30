using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.lemmy;

public partial class Language
{
    public int Id { get; set; }

    public string Code { get; set; }

    public string Name { get; set; }

    public virtual ICollection<Comment> Comments { get; } = new List<Comment>();

    public virtual ICollection<CommunityLanguage> CommunityLanguages { get; } = new List<CommunityLanguage>();

    public virtual ICollection<LocalUserLanguage> LocalUserLanguages { get; } = new List<LocalUserLanguage>();

    public virtual ICollection<Post> Posts { get; } = new List<Post>();

    public virtual ICollection<SiteLanguage> SiteLanguages { get; } = new List<SiteLanguage>();
}
