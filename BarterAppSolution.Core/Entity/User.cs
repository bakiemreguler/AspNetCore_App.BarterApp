using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarterAppSolution.Core.Entity
{
    public class User : AuditableEntity
    {
        public User()
        {
            UserReviews = new Collection<UserReview>();
        }

        public int UserRoleId { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string ProfilePhoto { get; set; }
        public string LoginName { get; set; }
        public string LoginPass { get; set; }
        public bool IsVerified { get; set; }
        public bool IsFemale { get; set; }
        public string MailAddress { get; set; }
        public DateTime LastLoginDate { get; set; }
        public string ActivationLink { get; set; }

        public virtual UserRole UserRole { get; set; }
        public virtual ICollection<UserReview> UserReviews { get; set; }
    }
}
