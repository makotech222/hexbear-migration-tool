using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.hexbear
{
    public partial class BanId
    {
        public BanId()
        {
            InverseAliasedToNavigation = new HashSet<BanId>();
            Uids = new HashSet<User>();
        }

        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public Guid? AliasedTo { get; set; }

        public virtual BanId AliasedToNavigation { get; set; }
        public virtual ICollection<BanId> InverseAliasedToNavigation { get; set; }

        public virtual ICollection<User> Uids { get; set; }
    }
}
