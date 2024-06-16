using System.ComponentModel.DataAnnotations;

namespace BaiThucHanh.Models
{
    public class SinhVien
    {
        [Key]
        public string Masinhvien { get; set; }
        public string Tensinhvien { get; set; }
        public string Lophoc { get; set; }
    }
}