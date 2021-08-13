using BarterAppSolution.Core.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BarterAppSolution.Data.Configuration
{
    class AdvertConfiguration : BaseConfiguration<Advert>
    {
        public override void Configure(EntityTypeBuilder<Advert> builder)
        {
            //Bu sınıfta veritabanı sınıflarımızın özelliklerini, ilişkilerini ve kısıtlarını belirliyeceğiz.
            //IsRequired() -> Zorunlu Alan
            //HasMaxLength() -> Maksimum Karakter Sayısı
            //IsUnique() -> PK olmayan ancak Unique olan alan. (HasAlternate)

            builder.Property(x => x.CategoryId).IsRequired();
            builder.Property(x => x.AdvertCode).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Title).HasMaxLength(150);
            builder.Property(x => x.Explanation).HasMaxLength(1000);
            builder.Property(x => x.Address).HasMaxLength(500);
            builder.HasIndex(x => x.AdvertCode).IsUnique();
            base.Configure(builder);
        }
    }
}
