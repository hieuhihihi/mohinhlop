
using System;
using System.Collections.Generic;
using System.Linq;
using QuanLySach.DAL;
using QuanLySach.Entity;

namespace QuanLySach.BUS
{
    public class SachBUS
    {
        private readonly SachDAO sachDAO = new SachDAO();

        // 1. Lấy toàn bộ danh sách sách
        public List<Sach> GetAll()
        {
            return sachDAO.GetAll();
        }

        // 2. Lấy sách theo mã
        public Sach GetById(string maSach)
        {
            if (string.IsNullOrWhiteSpace(maSach))
                throw new ArgumentException("Mã sách không được để trống!");

            return sachDAO.GetById(maSach.Trim());
        }

        // 3. Thêm sách
        public bool Add(Sach sach)
        {
            if (sach == null)
                throw new ArgumentNullException(nameof(sach));

            if (string.IsNullOrWhiteSpace(sach.MaSach))
                throw new ArgumentException("Mã sách không được để trống!");

            if (string.IsNullOrWhiteSpace(sach.TenSach))
                throw new ArgumentException("Tên sách không được để trống!");

            if (sach.SoLuong < 0)
                throw new ArgumentException("Số lượng không được âm!");

            if (sach.DonGia < 0)
                throw new ArgumentException("Đơn giá không được âm!");

            if (sachDAO.GetById(sach.MaSach.Trim()) != null)
                throw new ArgumentException("Mã sách đã tồn tại!");

            sach.MaSach = sach.MaSach.Trim();
            sach.TenSach = sach.TenSach.Trim();

            return sachDAO.Add(sach);
        }

        // 4. Cập nhật sách
        public bool Update(Sach sach)
        {
            if (sach == null)
                throw new ArgumentNullException(nameof(sach));

            if (string.IsNullOrWhiteSpace(sach.MaSach))
                throw new ArgumentException("Mã sách không được để trống!");

            if (sachDAO.GetById(sach.MaSach.Trim()) == null)
                throw new ArgumentException("Không tìm thấy sách cần sửa!");

            if (string.IsNullOrWhiteSpace(sach.TenSach))
                throw new ArgumentException("Tên sách không được để trống!");

            if (sach.SoLuong < 0 || sach.DonGia < 0)
                throw new ArgumentException("Số lượng và đơn giá không được âm!");

            sach.MaSach = sach.MaSach.Trim();
            sach.TenSach = sach.TenSach.Trim();

            return sachDAO.Update(sach);
        }

        // 5. Xóa sách
        public bool Delete(string maSach)
        {
            if (string.IsNullOrWhiteSpace(maSach))
                throw new ArgumentException("Mã sách không được để trống!");

            return sachDAO.Delete(maSach.Trim());
        }

        // 6. Tìm kiếm sách theo tên
        public List<Sach> SearchByName(string tenSach)
        {
            if (string.IsNullOrWhiteSpace(tenSach))
                return sachDAO.GetAll();

            return sachDAO.SearchByName(tenSach.Trim());
        }
    }
}
