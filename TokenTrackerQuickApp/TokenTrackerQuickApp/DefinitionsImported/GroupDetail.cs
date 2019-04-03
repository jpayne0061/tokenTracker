using System;
using System.Collections.Generic;

namespace TokenTrackerQuickApp.DefinitionsImported
{
    public partial class GroupDetail
    {
        public int GroupDetailId { get; set; }
        public string Name { get; set; }
        public int GroupId { get; set; }

        public virtual Group Group { get; set; }
    }
}
