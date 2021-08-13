using System;
using System.Collections.Generic;
using System.Text;
using BarterAppSolution.Core.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BarterAppSolution.Data.Configuration
{
    class UserReviewConfiguration : BaseConfiguration<UserReview>
    {
        public override void Configure(EntityTypeBuilder<UserReview> builder)
        {
            //Bu sınıfta veritabanı sınıflarımızın özelliklerini, ilişkilerini ve kısıtlarını belirliyeceğiz.
            //IsRequired() -> Zorunlu Alan
            //HasMaxLength() -> Maksimum Karakter Sayısı
            //IsUnique() -> PK olmayan ancak Unique olan alan. (HasAlternate)

            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.Explanation).HasMaxLength(1000);
            base.Configure(builder);
        }
    }
}
