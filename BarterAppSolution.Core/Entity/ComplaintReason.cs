using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarterAppSolution.Core.Entity
{
    public class ComplaintReason : AuditableEntity
    {
        public ComplaintReason()
        {
            Complaints = new Collection<Complaint>();
        }

        public string Reason { get; set; }

        public virtual ICollection<Complaint> Complaints { get; set; }
    }
}
