using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models
{
    [Table("ChiTietGioHang")]
    public class ChiTietGioHang
    {
        [Key]
        public int MaChiTietGioHang { get; set; }
        [Required]
        public int MaGioHang { get; set; }
        [Required]
        public int MaSach { get; set; }
        [Required]
        public int SoLuong {  get; set; }
        public double DonGia { get; set; }
        public GioHang GioHang { get; set; }
        public Sach Sach { get; set; } 


    }
}
