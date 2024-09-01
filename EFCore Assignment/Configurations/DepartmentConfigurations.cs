using EFCore_Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Assignment.Configurations
{
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(D => D.Id).UseIdentityColumn(10, 10);

            builder.Property(D => D.HirirngDate).HasComputedColumnSql("GETDATE()");

            // ONE To MANY

            builder.HasMany(D => D.Instructors)
                   .WithOne(I => I.WorkForDepartment)
                   .IsRequired(false)
                   .HasForeignKey(I => I.DepartmentId)
                   .OnDelete(DeleteBehavior.Cascade);

            // ONE To ONE

            builder.HasOne(D => D.Manager)
                   .WithOne(I => I.ManageDepartment)
                   .HasForeignKey<Department>(D => D.ManagerId)
                   .IsRequired(false);
        }
    }
}
