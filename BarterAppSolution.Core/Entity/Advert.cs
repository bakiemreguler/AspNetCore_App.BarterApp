using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BarterAppSolution.Core.Entity
{
    public class Advert : AuditableEntity
    {
        public Advert()
        {
            AdvertPhotos = new Collection<AdvertPhoto>();
            Complaints = new Collection<Complaint>();
            Favorites = new Collection<Favorite>();
        }

        public int CategoryId { get; set; }

        public string AdvertCode { get; set; }
        public int NumberOfViews { get; set; }
        public string Title { get; set; }
        public string Explanation { get; set; }
        public string Address { get; set; }
        public double LocLatitude { get; set; }
        public double LocLongitude { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<AdvertPhoto> AdvertPhotos { get; set; }
        public virtual ICollection<Complaint> Complaints { get; set; }
        public virtual ICollection<Favorite> Favorites { get; set; }
    }
}
