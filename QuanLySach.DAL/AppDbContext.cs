
using Microsoft.EntityFrameworkCore;
using QuanLySach.Entity;
using System.Configuration;

namespace QuanLySach.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Sach> Sachs { get; set; }
        public DbSet<TheLoai> TheLoais { get; set; }

        protected override void OnConfiguring(
    DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString =
                    ConfigurationManager.ConnectionStrings["QuanLySach"]?.ConnectionString;

                if (string.IsNullOrWhiteSpace(connectionString))
                {
                    throw new InvalidOperationException(
                        "Không tìm thấy Connection String QuanLySach trong App.config!");
                }

                optionsBuilder.UseMySQL(connectionString);
            }
        }
    }
}
