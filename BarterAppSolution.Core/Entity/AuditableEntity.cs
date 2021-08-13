using System;
using System.Collections.Generic;
using System.Text;

namespace BarterAppSolution.Core.Entity
{
    public class AuditableEntity : BaseEntity
    {
        // Bu sınıf diğer veritabanı sınıflarının türeyeceği, ortak alanları tanımlar.
        // Bazı sınıflar bu sınıftan, bazı sınıflar ise sadece BaseEntity sınıfından türeyebilir.

        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int CreatedBy { get; set; } = 0;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
        public int UpdatedBy { get; set; } = 0;
    }
}
