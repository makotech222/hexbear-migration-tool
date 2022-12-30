using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.lemmy;

public partial class CustomEmoji
{
    public int Id { get; set; }

    public int LocalSiteId { get; set; }

    public string Shortcode { get; set; }

    public string ImageUrl { get; set; }

    public string AltText { get; set; }

    public string Category { get; set; }

    public DateTime Published { get; set; }

    public DateTime? Updated { get; set; }

    public virtual ICollection<CustomEmojiKeyword> CustomEmojiKeywords { get; } = new List<CustomEmojiKeyword>();

    public virtual LocalSite LocalSite { get; set; }
}
