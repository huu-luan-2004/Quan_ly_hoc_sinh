using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanlyHocSinh.Enties
{
    public partial class StudentContext : DbContext
    {
        public StudentContext()
            : base("name=StudentContext1")
        {
        }

        public virtual DbSet<SINHVIEN> SINHVIEN { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
