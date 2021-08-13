using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarterAppSolution.Core.Entity
{
    public class UserReview : AuditableEntity
    {
        public int UserId { get; set; }

        public string Explanation { get; set; }
        public int Score { get; set; }

        public virtual User User { get; set; }
    }
}
