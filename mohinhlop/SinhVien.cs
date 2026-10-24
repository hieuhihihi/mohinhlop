using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLySinhVien.Models
{
    [Table("SinhVien")]
    public class SinhVien
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaSV { get; set; }

        [Required]
        [StringLength(100)]
        public string HoTen { get; set; } = string.Empty;

        public int Tuoi { get; set; }

        [StringLength(200)]
        public string? DiaChi { get; set; }

        // Khóa ngoại liên kết tới bảng Khoa
        public int MaKhoa { get; set; }

        // Thuộc tính điều hướng (Navigation Property)
        [ForeignKey("MaKhoa")]
        public virtual Khoa? Khoa { get; set; }
    }
}
