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
    internal class InstructorConfigurations : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.Property(I => I.Salary)
                   .HasColumnType("decimal(18,3)");

            builder.Property(I => I.HoureRate)
                   .HasColumnType("decimal(18,3)");

            builder.Property(I => I.Address)
                   .HasDefaultValue("Cairo");

            //// ONE To ONE

            //builder.HasOne(I => I.ManageDepartment)
            //       .WithOne(D => D.Manager)
            //       .IsRequired(false)
            //       .HasForeignKey<Department>(D => D.ManagerId);

            //// ONE To Many

            //builder.HasOne(I => I.WorkForDepartment)
            //       .WithMany(D => D.Instructors)
            //       .IsRequired(false)
            //       .HasForeignKey(I => I.DepartmentId);
        }
    }
}
