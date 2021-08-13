using BarterAppSolution.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BarterAppSolution.Data.Seed
{
    class UserRoleSeed : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.HasData(
                new UserRole { Id = 1, Role = "Administrator", IsActive = true, IsDeleted = false, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new UserRole { Id = 2, Role = "Standart Kullanıcı", IsActive = true, IsDeleted = false, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now }
            );
        }
    }
}
