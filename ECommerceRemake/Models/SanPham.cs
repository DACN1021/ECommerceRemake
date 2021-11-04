using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceRemake.Models
{
    public class SanPham
    {
        [Key]
        [Required]
        public int MaSP { get; set; }
        [Required, DisplayName("Tên Sản Phẩm")]
        public string TenSP { get; set; }
        [Required,DisplayName("Giá")]
        public decimal DonGia { get; set; }
        [DisplayName("Ngày Cập Nhật")]
        public DateTime NgayCapNhat { get; set; }
        [DisplayName("Cấu Hình")]
        public string CauHinh { get; set; }
        [DisplayName("Mô tả")]
        public string MoTa { get; set; }
        [DisplayName("Hình ảnh sản phẩm")]
        public string HinhAnh { get; set; }
        [DisplayName("Số lượng tồn"),Range(0,9999)]
        public int SoLuongTon { get; set; }
        [DisplayName("Số lượt xem"), Range(0, 999999999999999)]
        public int LuotXem { get; set; }
        [DisplayName("Số lượt bình luận"), Range(0, 999999999999999)]
        public int LuotBinhLuan { get; set; }
        [DisplayName("Số lần mua"), Range(0, 999999999999999)]
        public int SoLanMua { get; set; }
        [DisplayName("Mới?"), Range(0,1)]
        public int Moi { get; set; }
        [DisplayName("Mã Loại")]
        public int MaLoai { get; set; }
        [DisplayName("Đã Xóa?")]
        public bool DaXoa { get; set; }
    }
}
