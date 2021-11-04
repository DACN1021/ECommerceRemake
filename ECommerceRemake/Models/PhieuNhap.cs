using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceRemake.Models
{
    public class PhieuNhap
    {
        [Key]
        public int MaPN { get; set; }
        public DateTime NgayNhap { get; set; }
        public bool DaXoa { get; set; }
    }
}
