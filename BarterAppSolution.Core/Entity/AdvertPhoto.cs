using System;
using System.Collections.Generic;
using System.Text;

namespace BarterAppSolution.Core.Entity
{
    public class AdvertPhoto : AuditableEntity
    {
        public int AdvertId { get; set; }
        public string PhotoPath { get; set; }

        public virtual Advert Advert { get; set; }
    }
}
