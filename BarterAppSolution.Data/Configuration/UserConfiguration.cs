using System;
using System.Collections.Generic;
using System.Text;
using BarterAppSolution.Core.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BarterAppSolution.Data.Configuration
{
    class UserConfiguration : BaseConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            //Bu sınıfta veritabanı sınıflarımızın özelliklerini, ilişkilerini ve kısıtlarını belirliyeceğiz.
            //IsRequired() -> Zorunlu Alan
            //HasMaxLength() -> Maksimum Karakter Sayısı
            //IsUnique() -> PK olmayan ancak Unique olan alan. (HasAlternate)

            builder.Property(x => x.UserRoleId).IsRequired();
            builder.Property(x => x.IsVerified).IsRequired();
            builder.Property(x => x.IsFemale).IsRequired();

            builder.Property(x => x.Name).HasMaxLength(80);
            builder.Property(x => x.Surname).HasMaxLength(80);
            builder.Property(x => x.ProfilePhoto).HasMaxLength(200);
            builder.Property(x => x.LoginName).HasMaxLength(80);
            builder.Property(x => x.LoginPass).HasMaxLength(1000);
            builder.Property(x => x.MailAddress).HasMaxLength(200);
            builder.Property(x => x.ActivationLink).HasMaxLength(1000);

            builder.HasIndex(x => x.MailAddress).IsUnique();
            builder.HasIndex(x => x.LoginName).IsUnique();

            base.Configure(builder);
        }
    }
}
