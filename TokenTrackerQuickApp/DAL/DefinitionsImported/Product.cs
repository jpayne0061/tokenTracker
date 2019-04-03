using System;
using System.Collections.Generic;

namespace DAL.DefinitionsImported
{
    public partial class Product
    {
        public Product()
        {
            PointTransaction = new HashSet<PointTransaction>();
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public int ProductGroupId { get; set; }

        public virtual ProductGroup ProductGroup { get; set; }
        public virtual ICollection<PointTransaction> PointTransaction { get; set; }
    }
}
