using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ChiTietDonHang> DbSetChiTietDonHang { get; set; }
        public DbSet<ChiTietGioHang> DbSetChiTietGioHang { get; set; }
        public DbSet<DonHang> DbSetDonHang { get; set; }
        public DbSet<GioHang> DbSetGioHang { get; set; }
        public DbSet<Sach> DbSetSach { get; set; }
        public DbSet<TheLoai> DbSetTheLoai { get; set; }
        public DbSet<TrangThaiDonHang> DbSetTrangThaiDonHang { get; set; }
    }
}
