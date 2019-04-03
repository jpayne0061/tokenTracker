using System;
using System.Collections.Generic;

namespace TokenTrackerQuickApp.DefinitionsImported
{
    public partial class PointTransaction
    {
        public int PointTransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public int ProductId { get; set; }
        public int Points { get; set; }
        public int? AwardToId { get; set; }
        public int? AwardFromId { get; set; }
        public string AwardMessage { get; set; }

        public virtual Product Product { get; set; }
    }
}
