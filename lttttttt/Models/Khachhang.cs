using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace lttttttt.Models
{
    [Table("Khachhangs")]
    public class Khachhang
    {
        [Key]
        public string MaKhachhang { get; set; }
        public string TenKhachhang { get; set; }
        [MaxLength(15)]
        public string Sodt { get; set; }
        public string Diachi { get; set; }
    }
}