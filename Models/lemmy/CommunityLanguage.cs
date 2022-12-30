using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.lemmy;

public partial class CommunityLanguage
{
    public int Id { get; set; }

    public int CommunityId { get; set; }

    public int LanguageId { get; set; }

    public virtual Community Community { get; set; }

    public virtual Language Language { get; set; }
}
