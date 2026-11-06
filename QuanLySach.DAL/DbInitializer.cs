using System;
using System.Linq;
using QuanLySach.Entity;

namespace QuanLySach.DAL
{
    public static class DbInitializer
    {
        public static void Initialize()
        {
            using (var db = new AppDbContext())
            {
                // Thêm thể loại nếu mã chưa tồn tại
                if (!db.TheLoais.Any(x => x.MaLoai == "TL01"))
                    db.TheLoais.Add(new TheLoai
                    {
                        MaLoai = "TL01",
                        TenLoai = "Văn học"
                    });

                if (!db.TheLoais.Any(x => x.MaLoai == "TL02"))
                    db.TheLoais.Add(new TheLoai
                    {
                        MaLoai = "TL02",
                        TenLoai = "Khoa học"
                    });

                if (!db.TheLoais.Any(x => x.MaLoai == "TL03"))
                    db.TheLoais.Add(new TheLoai
                    {
                        MaLoai = "TL03",
                        TenLoai = "Tin học"
                    });

                db.SaveChanges();

                // Thêm sách nếu mã chưa tồn tại
                if (!db.Sachs.Any(x => x.MaSach == "MS001"))
                    db.Sachs.Add(new Sach
                    {
                        MaSach = "MS001",
                        TenSach = "Lập trình C#",
                        NgayNhap = DateTime.Now,
                        SoLuong = 10,
                        DonGia = 100000,
                        MaLoai = "TL03"
                    });

                if (!db.Sachs.Any(x => x.MaSach == "MS002"))
                    db.Sachs.Add(new Sach
                    {
                        MaSach = "MS002",
                        TenSach = "Đắc nhân tâm",
                        NgayNhap = DateTime.Now,
                        SoLuong = 15,
                        DonGia = 85000,
                        MaLoai = "TL01"
                    });

                if (!db.Sachs.Any(x => x.MaSach == "MS003"))
                    db.Sachs.Add(new Sach
                    {
                        MaSach = "MS003",
                        TenSach = "Vũ trụ",
                        NgayNhap = DateTime.Now,
                        SoLuong = 8,
                        DonGia = 120000,
                        MaLoai = "TL02"
                    });

                if (!db.Sachs.Any(x => x.MaSach == "MS004"))
                    db.Sachs.Add(new Sach
                    {
                        MaSach = "MS004",
                        TenSach = "Lập trình Java",
                        NgayNhap = DateTime.Now,
                        SoLuong = 12,
                        DonGia = 110000,
                        MaLoai = "TL03"
                    });

                if (!db.Sachs.Any(x => x.MaSach == "MS005"))
                    db.Sachs.Add(new Sach
                    {
                        MaSach = "MS005",
                        TenSach = "Văn học Việt Nam",
                        NgayNhap = DateTime.Now,
                        SoLuong = 20,
                        DonGia = 95000,
                        MaLoai = "TL01"
                    });

                db.SaveChanges();
            }
        }
    }
}