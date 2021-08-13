using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarterAppSolution.Core.Entity
{
    public class UserRole : AuditableEntity
    {
        public UserRole()
        {
            Users = new Collection<User>();
        }

        public string Role { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
