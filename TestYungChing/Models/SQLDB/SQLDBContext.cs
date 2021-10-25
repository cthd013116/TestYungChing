using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TestYungChing.Models.SQLDB
{
    public partial class SQLDBContext : DbContext
    {
       

        public virtual DbSet<Employee> GetEmployees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmpId);

               entity.ToTable("Employee");

                entity.Property(e => e.EmpId)
                    .HasColumnName("EmpId")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmpName)
                    .HasColumnName("EmpName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpBirth)
                    .HasColumnName("EmpBirth")
                    .HasMaxLength(10)
                    .IsUnicode(false);

            });

        

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
