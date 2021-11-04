using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceRemake.Models
{
    public class BinhLuan
    {
        [Key]
        public int CommentID { get; set; }
        public string CommentDetails { get; set; }
        public string Id { get; set; }
        public int MaSP { get; set; }
    }
}
