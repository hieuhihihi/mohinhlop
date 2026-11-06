
using Microsoft.EntityFrameworkCore;
using QuanLySach.Entity;

namespace QuanLySach.DAL
{
    public class SachDAO
    {
        // 1. Lấy toàn bộ danh sách sách
        public List<Sach> GetAll()
        {
            using (var db = new AppDbContext())
            {
                return db.Sachs
                         .Include(s => s.TheLoai)
                         .ToList();
            }
        }

        // 2. Lấy sách theo mã
        public Sach GetById(string maSach)
        {
            using (var db = new AppDbContext())
            {
                return db.Sachs
                         .Include(s => s.TheLoai)
                         .FirstOrDefault(s => s.MaSach == maSach);
            }
        }

        // 3. Thêm sách
        public bool Add(Sach sach)
        {
            using (var db = new AppDbContext())
            {
                db.Sachs.Add(sach);
                return db.SaveChanges() > 0;
            }
        }

        // 4. Cập nhật sách
        public bool Update(Sach sach)
        {
            using (var db = new AppDbContext())
            {
                db.Sachs.Update(sach);
                return db.SaveChanges() > 0;
            }
        }

        // 5. Xóa sách
        public bool Delete(string maSach)
        {
            using (var db = new AppDbContext())
            {
                var sach = db.Sachs.Find(maSach);

                if (sach == null)
                    return false;

                db.Sachs.Remove(sach);
                return db.SaveChanges() > 0;
            }
        }

        // 6. Tìm kiếm sách theo tên
        public List<Sach> SearchByName(string tenSach)
        {
            using (var db = new AppDbContext())
            {
                return db.Sachs
                         .Include(s => s.TheLoai)
                         .Where(s => s.TenSach.Contains(tenSach))
                         .ToList();
            }
        }
    }
}
