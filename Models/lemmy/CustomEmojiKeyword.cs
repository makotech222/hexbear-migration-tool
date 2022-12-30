using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.lemmy;

public partial class CustomEmojiKeyword
{
    public int Id { get; set; }

    public int CustomEmojiId { get; set; }

    public string Keyword { get; set; }

    public virtual CustomEmoji CustomEmoji { get; set; }
}
