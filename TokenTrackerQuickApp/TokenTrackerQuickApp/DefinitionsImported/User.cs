using System;
using System.Collections.Generic;

namespace TokenTrackerQuickApp.DefinitionsImported
{
    public partial class User
    {
        public int UserId { get; set; }
        public int GroupId { get; set; }
        public int RoleId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public virtual Group Group { get; set; }
        public virtual Role Role { get; set; }
    }
}
