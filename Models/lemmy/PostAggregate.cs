﻿using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.lemmy;

public partial class PostAggregate
{
    public int Id { get; set; }

    public int PostId { get; set; }

    public long Comments { get; set; }

    public long Score { get; set; }

    public long Upvotes { get; set; }

    public long Downvotes { get; set; }

    public DateTime Published { get; set; }

    public DateTime NewestCommentTimeNecro { get; set; }

    public DateTime NewestCommentTime { get; set; }

    public bool FeaturedCommunity { get; set; }

    public bool FeaturedLocal { get; set; }

    public virtual Post Post { get; set; }
}
