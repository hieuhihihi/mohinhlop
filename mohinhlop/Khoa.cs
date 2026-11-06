using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLySinhVien.Models
{
    [Table("Khoa")]
    public class Khoa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaKhoa { get; set; }

        [Required]
        [StringLength(100)]
        public string TenKhoa { get; set; } = string.Empty;

        // Quan hệ 1 - N: Một khoa có nhiều sinh viên
        public virtual ICollection<SinhVien> SinhViens { get; set; } = new HashSet<SinhVien>();
    }
}
