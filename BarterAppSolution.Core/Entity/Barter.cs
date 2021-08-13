using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BarterAppSolution.Core.Entity
{
    public class Barter : AuditableEntity
    {
        public int OfferedAdvertId { get; set; }
        public int AcceptedAdvertId { get; set; }

    }
}
