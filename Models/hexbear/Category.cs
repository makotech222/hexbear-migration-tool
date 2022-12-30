using System;
using System.Collections.Generic;

namespace hexbear_migration_tool.Models.hexbear
{
    public partial class Category
    {
        public Category()
        {
            Communities = new HashSet<Community>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null;

        public virtual ICollection<Community> Communities { get; set; }
    }
}
