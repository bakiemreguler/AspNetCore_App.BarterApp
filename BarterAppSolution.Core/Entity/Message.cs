using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarterAppSolution.Core.Entity
{
    public class Message : AuditableEntity
    {
        public int AdvertId { get; set; }
        public int SenderUserId { get; set; }
        public int ReceiverUserId { get; set; }
        public string Explanation { get; set; }
    }
}
