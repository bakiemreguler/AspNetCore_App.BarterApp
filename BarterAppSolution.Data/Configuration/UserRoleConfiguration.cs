using BarterAppSolution.Core.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BarterAppSolution.Data.Configuration
{
    class UserRoleConfiguration : BaseConfiguration<UserRole>
    {
        public override void Configure(EntityTypeBuilder<UserRole> builder)
        {
            //Bu sınıfta veritabanı sınıflarımızın özelliklerini, ilişkilerini ve kısıtlarını belirliyeceğiz.
            //IsRequired() -> Zorunlu Alan
            //HasMaxLength() -> Maksimum Karakter Sayısı
            //IsUnique() -> PK olmayan ancak Unique olan alan. (HasAlternate)

            builder.Property(x => x.Role).HasMaxLength(80);
            base.Configure(builder);
        }
    }
}
