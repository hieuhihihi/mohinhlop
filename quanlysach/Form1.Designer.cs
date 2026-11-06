namespace quanlysach
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            groupBox1 = new GroupBox();
            cboTheLoai = new ComboBox();
            txtDonGia = new TextBox();
            txtSoLuong = new TextBox();
            txtTenSach = new TextBox();
            txtMaSach = new TextBox();
            dtpNgayNhap = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            groupBox2 = new GroupBox();
            dgvSach = new DataGridView();
            colMaSach = new DataGridViewTextBoxColumn();
            colTenSach = new DataGridViewTextBoxColumn();
            colNgayNhap = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();
            colDonGia = new DataGridViewTextBoxColumn();
            colTheLoai = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(231, 40);
            label1.Name = "label1";
            label1.Size = new Size(569, 51);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Sách Theo Thể Loại";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboTheLoai);
            groupBox1.Controls.Add(txtDonGia);
            groupBox1.Controls.Add(txtSoLuong);
            groupBox1.Controls.Add(txtTenSach);
            groupBox1.Controls.Add(txtMaSach);
            groupBox1.Controls.Add(dtpNgayNhap);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(29, 106);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1029, 240);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sách";
            // 
            // cboTheLoai
            // 
            cboTheLoai.FormattingEnabled = true;
            cboTheLoai.Location = new Point(144, 45);
            cboTheLoai.Name = "cboTheLoai";
            cboTheLoai.Size = new Size(308, 36);
            cboTheLoai.TabIndex = 11;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(656, 161);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(347, 34);
            txtDonGia.TabIndex = 10;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(656, 104);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(347, 34);
            txtSoLuong.TabIndex = 9;
            // 
            // txtTenSach
            // 
            txtTenSach.Location = new Point(144, 159);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(308, 34);
            txtTenSach.TabIndex = 8;
            // 
            // txtMaSach
            // 
            txtMaSach.Location = new Point(144, 106);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(308, 34);
            txtMaSach.TabIndex = 7;
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.CalendarFont = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dtpNgayNhap.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpNgayNhap.Location = new Point(656, 51);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(347, 30);
            dtpNgayNhap.TabIndex = 6;
            dtpNgayNhap.ValueChanged += dateTimePicker2_ValueChanged_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(530, 161);
            label8.Name = "label8";
            label8.Size = new Size(98, 25);
            label8.TabIndex = 5;
            label8.Text = "Đơn giá:";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(530, 104);
            label7.Name = "label7";
            label7.Size = new Size(108, 25);
            label7.TabIndex = 4;
            label7.Text = "Số lượng:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(530, 47);
            label6.Name = "label6";
            label6.Size = new Size(129, 25);
            label6.TabIndex = 3;
            label6.Text = "Ngày nhập:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(32, 161);
            label5.Name = "label5";
            label5.Size = new Size(109, 25);
            label5.TabIndex = 2;
            label5.Text = "Tên sách:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 104);
            label4.Name = "label4";
            label4.Size = new Size(106, 25);
            label4.TabIndex = 1;
            label4.Text = "Mã sách:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 47);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 0;
            label2.Text = "Thể loại:";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Location = new Point(1082, 102);
            button1.Name = "button1";
            button1.Size = new Size(142, 29);
            button1.TabIndex = 4;
            button1.Text = "✚ Mới";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LawnGreen;
            button3.Location = new Point(1085, 151);
            button3.Name = "button3";
            button3.Size = new Size(139, 29);
            button3.TabIndex = 6;
            button3.Text = "＋ Thêm";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.PaleGoldenrod;
            button4.Location = new Point(1085, 204);
            button4.Name = "button4";
            button4.Size = new Size(139, 29);
            button4.TabIndex = 7;
            button4.Text = "✎ Sửa";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Location = new Point(1085, 259);
            button5.Name = "button5";
            button5.Size = new Size(139, 29);
            button5.TabIndex = 8;
            button5.Text = "✖ Xóa";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.AppWorkspace;
            button6.Location = new Point(1085, 313);
            button6.Name = "button6";
            button6.Size = new Size(139, 29);
            button6.TabIndex = 9;
            button6.Text = "↪ Thoát";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvSach);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(22, 352);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1207, 306);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sách";
            // 
            // dgvSach
            // 
            dgvSach.AllowUserToAddRows = false;
            dgvSach.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLight;
            dgvSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSach.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSach.Columns.AddRange(new DataGridViewColumn[] { colMaSach, colTenSach, colNgayNhap, colSoLuong, colDonGia, colTheLoai });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(30, 58, 138);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvSach.DefaultCellStyle = dataGridViewCellStyle3;
            dgvSach.Location = new Point(6, 33);
            dgvSach.MultiSelect = false;
            dgvSach.Name = "dgvSach";
            dgvSach.RowHeadersVisible = false;
            dgvSach.RowHeadersWidth = 51;
            dgvSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSach.Size = new Size(1195, 253);
            dgvSach.TabIndex = 0;
            dgvSach.CellClick += dgvSach_CellClick;
            // 
            // colMaSach
            // 
            colMaSach.HeaderText = "Mã sách";
            colMaSach.MinimumWidth = 6;
            colMaSach.Name = "colMaSach";
            // 
            // colTenSach
            // 
            colTenSach.HeaderText = "Tên sách";
            colTenSach.MinimumWidth = 6;
            colTenSach.Name = "colTenSach";
            // 
            // colNgayNhap
            // 
            colNgayNhap.HeaderText = "Ngày nhập";
            colNgayNhap.MinimumWidth = 6;
            colNgayNhap.Name = "colNgayNhap";
            // 
            // colSoLuong
            // 
            colSoLuong.HeaderText = "Số lượng";
            colSoLuong.MinimumWidth = 6;
            colSoLuong.Name = "colSoLuong";
            // 
            // colDonGia
            // 
            colDonGia.HeaderText = "Đơn giá";
            colDonGia.MinimumWidth = 6;
            colDonGia.Name = "colDonGia";
            // 
            // colTheLoai
            // 
            colTheLoai.HeaderText = "Thể loại";
            colTheLoai.MinimumWidth = 6;
            colTheLoai.Name = "colTheLoai";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 677);
            Controls.Add(groupBox2);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Quản Lý Sách";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private DateTimePicker dtpNgayNhap;
        private TextBox txtDonGia;
        private TextBox txtSoLuong;
        private TextBox txtTenSach;
        private TextBox txtMaSach;
        private ComboBox cboTheLoai;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private GroupBox groupBox2;
        private DataGridView dgvSach;
        private DataGridViewTextBoxColumn colMaSach;
        private DataGridViewTextBoxColumn colTenSach;
        private DataGridViewTextBoxColumn colNgayNhap;
        private DataGridViewTextBoxColumn colSoLuong;
        private DataGridViewTextBoxColumn colDonGia;
        private DataGridViewTextBoxColumn colTheLoai;
    }
}
