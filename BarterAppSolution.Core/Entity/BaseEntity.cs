using System;
using System.Collections.Generic;
using System.Text;

namespace BarterAppSolution.Core.Entity
{
    public class BaseEntity
    {
        // Bu sınıf diğer veritabanı sınıflarının türeyeceği, ortak alanları tanımlar.
        // Bazı sınıflar bu sınıftan, bazı sınıflar ise AuditableEntity sınıfından türeyebilir.
        // AuditableEntity sınıfı da BaseEntity sınıfından türemekte. 
        // Bu nedenle tüm veritabanı sınıfları, BaseEntity sınıfı ögelerini icerecektir.  

        public int Id { get; set; }
    }
}
