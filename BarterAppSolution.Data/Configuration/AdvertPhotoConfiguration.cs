using BarterAppSolution.Core.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BarterAppSolution.Data.Configuration
{
    class AdvertPhotoConfiguration : BaseConfiguration<AdvertPhoto>
    {
        public override void Configure(EntityTypeBuilder<AdvertPhoto> builder)
        {
            //Bu sınıfta veritabanı sınıflarımızın özelliklerini, ilişkilerini ve kısıtlarını belirliyeceğiz.
            //IsRequired() -> Zorunlu Alan
            //HasMaxLength() -> Maksimum Karakter Sayısı
            //IsUnique() -> PK olmayan ancak Unique olan alan. (HasAlternate)

            builder.Property(x => x.AdvertId).IsRequired();
            builder.Property(x => x.PhotoPath).HasMaxLength(200);
            base.Configure(builder);
        }
    }
}
