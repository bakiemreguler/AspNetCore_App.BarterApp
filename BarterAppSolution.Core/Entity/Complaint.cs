using System;
using System.Collections.Generic;
using System.Text;

namespace BarterAppSolution.Core.Entity
{
    public class Complaint : AuditableEntity
    {
        public int ComplaintReasonId { get; set; }
        public int AdvertId { get; set; }
        public string Explanation { get; set; }

        public virtual Advert Advert { get; set; }
        public virtual ComplaintReason ComplaintReason { get; set; }
    }
}
