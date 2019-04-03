using System;
using System.Collections.Generic;

namespace DAL.DefinitionsImported
{
    public partial class Group
    {
        public Group()
        {
            GroupDetail = new HashSet<GroupDetail>();
            User = new HashSet<User>();
        }

        public int GroupId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<GroupDetail> GroupDetail { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
