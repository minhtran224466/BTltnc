using Microsoft.EntityFrameworkCore;

namespace Quanlysinhvien
{
    public class AppDbContext : DbContext
    {
        public DbSet<LopHoc> LopHocs { get; set; }
        public DbSet<SinhVien> SinhViens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Sử dụng chuỗi kết nối SQL Server quen thuộc của cậu
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-6SN65NCS\HUECTMDB; Database=QLSV_EFCore; Integrated Security=True; TrustServerCertificate=true");
        }
    }
}
