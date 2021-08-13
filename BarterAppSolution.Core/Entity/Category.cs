using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BarterAppSolution.Core.Entity
{
    public class Category : AuditableEntity
    {
        public Category()
        {
            Adverts = new Collection<Advert>();
        }

        public int ParentCategoryId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Advert> Adverts { get; set; }
    }
}
