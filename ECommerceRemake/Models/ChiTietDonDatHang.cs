using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceRemake.Models
{
    public class ChiTietDonDatHang
    {
        [Key]
        public int MaChiTietDDH { get; set; }
        public int MaDDH { get; set; }
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public int SoLuongDat { get; set; }
        public decimal DonGia { get; set; }
    }
}
