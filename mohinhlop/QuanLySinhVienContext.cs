using System.Data.Entity;
using QuanLySinhVien.Models;

namespace QuanLySinhVien
{
    public class QuanLySinhVienContext : DbContext
    {
        public QuanLySinhVienContext()
            : base("name=QuanLySinhVienConnection")
        {
            
            Database.SetInitializer(new CreateDatabaseIfNotExists<QuanLySinhVienContext>());
        }

        public virtual DbSet<Khoa> Khoas { get; set; } = null!;
        public virtual DbSet<SinhVien> SinhViens { get; set; } = null!;

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
