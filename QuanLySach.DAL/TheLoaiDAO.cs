
using Microsoft.EntityFrameworkCore;
using QuanLySach.Entity;

namespace QuanLySach.DAL
{
    public class TheLoaiDAO
    {
        // 1. Lấy tất cả thể loại
        public List<TheLoai> GetAll()
        {
            using (var db = new AppDbContext())
            {
                return db.TheLoais.ToList();
            }
        }

        // 2. Lấy thể loại theo mã
        public TheLoai GetById(string maLoai)
        {
            using (var db = new AppDbContext())
            {
                return db.TheLoais
                         .FirstOrDefault(t => t.MaLoai == maLoai);
            }
        }

        // 3. Thêm thể loại
        public bool Add(TheLoai theLoai)
        {
            using (var db = new AppDbContext())
            {
                db.TheLoais.Add(theLoai);
                return db.SaveChanges() > 0;
            }
        }

        // 4. Cập nhật thể loại
        public bool Update(TheLoai theLoai)
        {
            using (var db = new AppDbContext())
            {
                db.TheLoais.Update(theLoai);
                return db.SaveChanges() > 0;
            }
        }

        // 5. Xóa thể loại
        public bool Delete(string maLoai)
        {
            using (var db = new AppDbContext())
            {
                var theLoai = db.TheLoais.Find(maLoai);

                if (theLoai == null)
                    return false;

                db.TheLoais.Remove(theLoai);
                return db.SaveChanges() > 0;
            }
        }

        // 6. Tìm kiếm thể loại theo tên
        public List<TheLoai> SearchByName(string tenLoai)
        {
            using (var db = new AppDbContext())
            {
                return db.TheLoais
                         .Where(t => t.TenLoai.Contains(tenLoai))
                         .ToList();
            }
        }
    }
}
