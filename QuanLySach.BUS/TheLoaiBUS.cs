
using System;
using System.Collections.Generic;
using QuanLySach.DAL;
using QuanLySach.Entity;

namespace QuanLySach.BUS
{
    public class TheLoaiBUS
    {
        private readonly TheLoaiDAO theLoaiDAO = new TheLoaiDAO();

        public List<TheLoai> GetAll()
        {
            return theLoaiDAO.GetAll();
        }

        public TheLoai GetById(string maLoai)
        {
            if (string.IsNullOrWhiteSpace(maLoai))
                throw new ArgumentException("Mã thể loại không được để trống!");

            return theLoaiDAO.GetById(maLoai.Trim());
        }

        public bool Add(TheLoai theLoai)
        {
            if (theLoai == null)
                throw new ArgumentNullException(nameof(theLoai));

            if (string.IsNullOrWhiteSpace(theLoai.MaLoai))
                throw new ArgumentException("Mã thể loại không được để trống!");

            if (string.IsNullOrWhiteSpace(theLoai.TenLoai))
                throw new ArgumentException("Tên thể loại không được để trống!");

            if (theLoaiDAO.GetById(theLoai.MaLoai.Trim()) != null)
                throw new ArgumentException("Mã thể loại đã tồn tại!");

            theLoai.MaLoai = theLoai.MaLoai.Trim();
            theLoai.TenLoai = theLoai.TenLoai.Trim();

            return theLoaiDAO.Add(theLoai);
        }

        public bool Update(TheLoai theLoai)
        {
            if (theLoai == null)
                throw new ArgumentNullException(nameof(theLoai));

            if (string.IsNullOrWhiteSpace(theLoai.MaLoai))
                throw new ArgumentException("Mã thể loại không được để trống!");

            if (string.IsNullOrWhiteSpace(theLoai.TenLoai))
                throw new ArgumentException("Tên thể loại không được để trống!");

            if (theLoaiDAO.GetById(theLoai.MaLoai.Trim()) == null)
                throw new ArgumentException("Không tìm thấy thể loại cần sửa!");

            theLoai.MaLoai = theLoai.MaLoai.Trim();
            theLoai.TenLoai = theLoai.TenLoai.Trim();

            return theLoaiDAO.Update(theLoai);
        }

        public bool Delete(string maLoai)
        {
            if (string.IsNullOrWhiteSpace(maLoai))
                throw new ArgumentException("Mã thể loại không được để trống!");

            return theLoaiDAO.Delete(maLoai.Trim());
        }

        public List<TheLoai> SearchByName(string tenLoai)
        {
            if (string.IsNullOrWhiteSpace(tenLoai))
                return theLoaiDAO.GetAll();

            return theLoaiDAO.SearchByName(tenLoai.Trim());
        }
    }
}
