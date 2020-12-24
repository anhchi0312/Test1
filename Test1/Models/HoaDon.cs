using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Test1.Models
{
    public class HoaDon
    {
        [Key]
        public int MaHD { get; set; }
        public int ThanhTien { get; set; }
        public int KhachHang_id { get; set; }
        [ForeignKey("KhachHang_id")]
        public KhachHang KhachHang { get; set; }
       
    }
}