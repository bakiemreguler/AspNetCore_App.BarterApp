using System;
using System.Collections.Generic;
using System.Text;
using BarterAppSolution.Core.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BarterAppSolution.Data.Configuration
{
    class ComplaintReasonConfiguration : BaseConfiguration<ComplaintReason>
    {
        public override void Configure(EntityTypeBuilder<ComplaintReason> builder)
        {
            //Bu sınıfta veritabanı sınıflarımızın özelliklerini, ilişkilerini ve kısıtlarını belirliyeceğiz.
            //IsRequired() -> Zorunlu Alan
            //HasMaxLength() -> Maksimum Karakter Sayısı
            //IsUnique() -> PK olmayan ancak Unique olan alan. (HasAlternate)

            builder.Property(x => x.Reason).HasMaxLength(100);
            base.Configure(builder);
        }
    }
}
