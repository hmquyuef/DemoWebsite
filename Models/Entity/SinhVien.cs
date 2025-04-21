using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoWebsite.Models.Entity
{
    public class SinhVien
    {
        [Key]
        public Guid Id { get; set; }
        public string MSSV { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
    }
}
