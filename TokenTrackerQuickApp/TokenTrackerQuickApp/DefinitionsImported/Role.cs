﻿using System;
using System.Collections.Generic;

namespace TokenTrackerQuickApp.DefinitionsImported
{
    public partial class Role
    {
        public Role()
        {
            User = new HashSet<User>();
        }

        public int RoleId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<User> User { get; set; }
    }
}
