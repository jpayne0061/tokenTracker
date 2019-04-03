using System;
using System.Collections.Generic;

namespace TokenTrackerQuickApp.DefinitionsImported
{
    public partial class ProductGroup
    {
        public ProductGroup()
        {
            Product = new HashSet<Product>();
        }

        public int ProductGroupId { get; set; }
        public string Name { get; set; }
        public int AffectOnTransaction { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
