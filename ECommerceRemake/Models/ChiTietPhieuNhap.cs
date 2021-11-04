using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceRemake.Models
{
    public class ChiTietPhieuNhap
    {
        [Key]
        public int MaChiTietPN { get; set; }
        public int MaPN { get; set; }
        public int MaSP { get; set; }
        public decimal DonGiaNhap { get; set; }
        public int SoLuongNhap { get; set; }
    }
}
