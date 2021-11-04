using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceRemake.Models
{
    public class DonDatHang
    {
        [Key]
        public int MaDHDH { get; set; }
        public DateTime NgayDat { get; set; }
        public bool TinhTrangGiao { get; set; }
        public DateTime NgayGiao { get; set; }
        public bool DaThanhToan { get; set; }
        public string Id { get; set; }
        public int Sales { get; set; }
    }
}
