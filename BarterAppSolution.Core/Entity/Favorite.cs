using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarterAppSolution.Core.Entity
{
    public class Favorite : AuditableEntity
    {
        public int AdvertId { get; set; }

        public virtual Advert Advert { get; set; }
    }
}
