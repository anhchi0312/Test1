using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Test1.Models
{
    public class KhachHang
    {
        [Key]
        public int MaKH { get; set; }
        public string TenKH { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        public string role { get; set; }
        [Required]
        public string PW { get; set; }
        [NotMapped]
        [Required]
        [System.ComponentModel.DataAnnotations.Compare("PW")]
        public string confirm_pw { get; set; }

        public ICollection<HoaDon> HoaDons { get; set; }
    }
}