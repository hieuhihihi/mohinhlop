
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuanLySach.Entity
{
    public class TheLoai
    {
        [Key]
        [StringLength(10)]
        public string MaLoai { get; set; }

        [Required]
        [StringLength(100)]
        public string TenLoai { get; set; }

        // Quan hệ một thể loại có nhiều sách
        public virtual ICollection<Sach> Sachs { get; set; }

        public TheLoai()
        {
            Sachs = new HashSet<Sach>();
        }
    }
}
