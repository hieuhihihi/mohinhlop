using QuanLySach.BUS;
using QuanLySach.Entity;
using System;
using System.Collections.Generic;

using System.Linq;

namespace quanlysach
{
    public partial class Form1 : Form
    {
        private SachBUS sachBUS = new SachBUS();
        private TheLoaiBUS theLoaiBUS = new TheLoaiBUS();
        public Form1()
        {
            InitializeComponent();

            LoadTheLoai();
            LoadSach();
        }
        private void LoadSach()
        {
            dgvSach.AutoGenerateColumns = false;

            colMaSach.DataPropertyName = "MaSach";
            colTenSach.DataPropertyName = "TenSach";
            colNgayNhap.DataPropertyName = "NgayNhap";
            colSoLuong.DataPropertyName = "SoLuong";
            colDonGia.DataPropertyName = "DonGia";
            colTheLoai.DataPropertyName = "TenLoai";

            var danhSach = sachBUS.GetAll()
                .Select(s => new
                {
                    s.MaSach,
                    s.TenSach,
                    s.NgayNhap,
                    s.SoLuong,
                    s.DonGia,
                    TenLoai = s.TheLoai != null
                        ? s.TheLoai.TenLoai
                        : ""
                })
                .ToList();

            dgvSach.DataSource = danhSach;
        }
        private void LoadTheLoai()
        {
            cboTheLoai.DataSource = theLoaiBUS.GetAll();

            cboTheLoai.DisplayMember = "TenLoai";
            cboTheLoai.ValueMember = "MaLoai";

            cboTheLoai.SelectedIndex = -1;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();

            // Bỏ chọn thể loại
            cboTheLoai.SelectedIndex = -1;

            // Đặt ngày nhập về ngày hiện tại
            dtpNgayNhap.Value = DateTime.Now;

            // Đưa con trỏ về ô mã sách
            txtMaSach.Focus();

            // Bỏ chọn dòng trong bảng
            dgvSach.ClearSelection();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaSach.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã sách!");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtTenSach.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên sách!");
                    return;
                }

                if (cboTheLoai.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn thể loại!");
                    return;
                }

                if (!int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong < 0)
                {
                    MessageBox.Show("Số lượng không hợp lệ!");
                    return;
                }

                if (!decimal.TryParse(txtDonGia.Text, out decimal donGia) || donGia < 0)
                {
                    MessageBox.Show("Đơn giá không hợp lệ!");
                    return;
                }

                Sach sach = new Sach()
                {
                    MaSach = txtMaSach.Text.Trim(),
                    TenSach = txtTenSach.Text.Trim(),
                    NgayNhap = dtpNgayNhap.Value,
                    SoLuong = soLuong,
                    DonGia = donGia,
                    MaLoai = cboTheLoai.SelectedValue.ToString()
                };

                bool ketQua = sachBUS.Update(sach);

                if (ketQua)
                {
                    MessageBox.Show("Sửa sách thành công!");
                    LoadSach();
                }
                else
                {
                    MessageBox.Show("Sửa sách thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra thông tin nhập
                if (string.IsNullOrWhiteSpace(txtMaSach.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã sách!");
                    txtMaSach.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtTenSach.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên sách!");
                    txtTenSach.Focus();
                    return;
                }

                if (cboTheLoai.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn thể loại!");
                    cboTheLoai.Focus();
                    return;
                }

                // Kiểm tra số lượng
                if (!int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong < 0)
                {
                    MessageBox.Show("Số lượng phải là số nguyên không âm!");
                    txtSoLuong.Focus();
                    return;
                }

                // Kiểm tra đơn giá
                if (!decimal.TryParse(txtDonGia.Text, out decimal donGia) || donGia < 0)
                {
                    MessageBox.Show("Đơn giá không hợp lệ!");
                    txtDonGia.Focus();
                    return;
                }

                // Tạo đối tượng sách
                Sach sach = new Sach()
                {
                    MaSach = txtMaSach.Text.Trim(),
                    TenSach = txtTenSach.Text.Trim(),
                    NgayNhap = dtpNgayNhap.Value,
                    SoLuong = soLuong,
                    DonGia = donGia,
                    MaLoai = cboTheLoai.SelectedValue.ToString()
                };

                // Gọi BUS để thêm sách
                bool ketQua = sachBUS.Add(sach);

                if (ketQua)
                {
                    MessageBox.Show("Thêm sách thành công!");

                    // Tải lại danh sách
                    LoadSach();
                }
                else
                {
                    MessageBox.Show("Thêm sách thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi");
            }
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvSach.Rows[e.RowIndex];

            txtMaSach.Text = row.Cells["colMaSach"].Value?.ToString();
            txtTenSach.Text = row.Cells["colTenSach"].Value?.ToString();
            txtSoLuong.Text = row.Cells["colSoLuong"].Value?.ToString();
            txtDonGia.Text = row.Cells["colDonGia"].Value?.ToString();

            if (row.Cells["colNgayNhap"].Value != null)
            {
                dtpNgayNhap.Value =
                    Convert.ToDateTime(row.Cells["colNgayNhap"].Value);
            }

            string maLoai = sachBUS.GetById(txtMaSach.Text)?.MaLoai;

            if (maLoai != null)
                cboTheLoai.SelectedValue = maLoai;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra mã sách
                if (string.IsNullOrWhiteSpace(txtMaSach.Text))
                {
                    MessageBox.Show("Vui lòng chọn sách cần xóa!");
                    return;
                }

                // Xác nhận trước khi xóa
                DialogResult xacNhan = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa sách này không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (xacNhan == DialogResult.No)
                    return;

                // Gọi BUS thực hiện xóa
                bool ketQua = sachBUS.Delete(txtMaSach.Text.Trim());

                if (ketQua)
                {
                    MessageBox.Show("Xóa sách thành công!");

                    // Tải lại danh sách
                    LoadSach();

                    // Xóa thông tin trên các ô nhập
                    txtMaSach.Clear();
                    txtTenSach.Clear();
                    txtSoLuong.Clear();
                    txtDonGia.Clear();

                    cboTheLoai.SelectedIndex = -1;
                    dtpNgayNhap.Value = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sách hoặc xóa thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
