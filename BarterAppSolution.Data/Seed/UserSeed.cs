using System;
using System.Collections.Generic;
using System.Text;
using BarterAppSolution.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BarterAppSolution.Data.Seed
{
    class UserSeed : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User { Id = 1, Name = "Admin", Surname = "Admin", LoginName = "Admin", LoginPass = "1234", IsVerified = true, IsFemale = false, MailAddress = "bakiemreguler9478@gmail.com", LastLoginDate = DateTime.Now, CreatedBy = 1, UpdatedBy = 1, IsActive = true, IsDeleted = false, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, UserRoleId = 1 },
                new User { Id = 2, Name = "Baki Emre", Surname = "Güler", LoginName = "bkmrglr", LoginPass = "1234", IsVerified = true, IsFemale = false, MailAddress = "bakiemreguler@gmail.com", LastLoginDate = DateTime.Now, CreatedBy = 1, UpdatedBy = 1, IsActive = true, IsDeleted = false, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, UserRoleId = 2 }
            );
        }
    }
}
