using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Management.Instrumentation;
using System.Web;

namespace lttttttt.Models
{
    [Table("NhaCCs")]
    public class NhaCC
    {
        [Key]
        public string MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string MaKhachhang { get; set; }
    }
}