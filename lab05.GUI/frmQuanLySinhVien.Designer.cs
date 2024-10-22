using System;

namespace lab05.GUI
{
    partial class frmQuanLySinhVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbxChucNang = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuMainChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuanLyKhoa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDangKyChuyenNganh = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvDanhSachSinhVien = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmssv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChuyenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoaTimMa = new System.Windows.Forms.Button();
            this.lblMaSinhVienXoa = new System.Windows.Forms.Label();
            this.txtMaNhanVienXoa = new System.Windows.Forms.TextBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxXoaMSV = new System.Windows.Forms.GroupBox();
            this.gbxThongTinSinhVien = new System.Windows.Forms.GroupBox();
            this.btnAddAnh = new System.Windows.Forms.Button();
            this.lblAnhDaiDien = new System.Windows.Forms.Label();
            this.picAnhDaiDien = new System.Windows.Forms.PictureBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.cbxKhoa = new System.Windows.Forms.ComboBox();
            this.txtDiemTB = new System.Windows.Forms.TextBox();
            this.lblDiemTB = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMaSinhVien = new System.Windows.Forms.Label();
            this.txtMaSinhVien = new System.Windows.Forms.TextBox();
            this.lblQuanLyThongTinSinhVien = new System.Windows.Forms.Label();
            this.chkChuaDkChuyenNganh = new System.Windows.Forms.CheckBox();
            this.toolMain = new System.Windows.Forms.ToolStrip();
            this.btnQuanLyKhoa = new System.Windows.Forms.ToolStripButton();
            this.lblQuanLyKhoa = new System.Windows.Forms.ToolStripLabel();
            this.btnTimKiem = new System.Windows.Forms.ToolStripButton();
            this.lblTimKiem = new System.Windows.Forms.ToolStripLabel();
            this.btnDangKyChuyenNganh = new System.Windows.Forms.ToolStripButton();
            this.lblDangKyChuyenNganh = new System.Windows.Forms.ToolStripLabel();
            this.gbxChucNang.SuspendLayout();
            this.menuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.gbxXoaMSV.SuspendLayout();
            this.gbxThongTinSinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhDaiDien)).BeginInit();
            this.toolMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxChucNang
            // 
            this.gbxChucNang.Controls.Add(this.btnAdd);
            this.gbxChucNang.Controls.Add(this.btnHuyBo);
            this.gbxChucNang.Controls.Add(this.btnXoa);
            this.gbxChucNang.Controls.Add(this.btnThoat);
            this.gbxChucNang.Location = new System.Drawing.Point(17, 566);
            this.gbxChucNang.Name = "gbxChucNang";
            this.gbxChucNang.Size = new System.Drawing.Size(457, 94);
            this.gbxChucNang.TabIndex = 57;
            this.gbxChucNang.TabStop = false;
            this.gbxChucNang.Text = "Chức Năng";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(13, 35);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 42);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.Text = "Thêm/Sửa";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHuyBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyBo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyBo.Location = new System.Drawing.Point(233, 35);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(102, 42);
            this.btnHuyBo.TabIndex = 49;
            this.btnHuyBo.Text = "Huỷ Bỏ";
            this.btnHuyBo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(122, 35);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 42);
            this.btnXoa.TabIndex = 38;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(345, 35);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(102, 42);
            this.btnThoat.TabIndex = 46;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // menuMain
            // 
            this.menuMain.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMainChucNang});
            this.menuMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(1200, 27);
            this.menuMain.TabIndex = 58;
            this.menuMain.Text = "menuStrip1";
            // 
            // menuMainChucNang
            // 
            this.menuMainChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuQuanLyKhoa,
            this.menuDangKyChuyenNganh,
            this.menuTimKiem,
            this.toolStripSeparator1,
            this.menuThoat});
            this.menuMainChucNang.Name = "menuMainChucNang";
            this.menuMainChucNang.Size = new System.Drawing.Size(87, 23);
            this.menuMainChucNang.Text = "Chức năng";
            // 
            // menuQuanLyKhoa
            // 
            this.menuQuanLyKhoa.Name = "menuQuanLyKhoa";
            this.menuQuanLyKhoa.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.menuQuanLyKhoa.Size = new System.Drawing.Size(240, 24);
            this.menuQuanLyKhoa.Text = "Quản lý khoa";
            this.menuQuanLyKhoa.Click += new System.EventHandler(this.menuQuanLyKhoa_Click);
            // 
            // menuDangKyChuyenNganh
            // 
            this.menuDangKyChuyenNganh.Name = "menuDangKyChuyenNganh";
            this.menuDangKyChuyenNganh.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.menuDangKyChuyenNganh.Size = new System.Drawing.Size(240, 24);
            this.menuDangKyChuyenNganh.Text = "Đăng ký chuyên ngành";
            this.menuDangKyChuyenNganh.Click += new System.EventHandler(this.menuDangKyChuyenNganh_Click);
            // 
            // menuTimKiem
            // 
            this.menuTimKiem.Name = "menuTimKiem";
            this.menuTimKiem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.menuTimKiem.Size = new System.Drawing.Size(240, 24);
            this.menuTimKiem.Text = "Tìm kiếm";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(237, 6);
            // 
            // menuThoat
            // 
            this.menuThoat.Name = "menuThoat";
            this.menuThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuThoat.Size = new System.Drawing.Size(240, 24);
            this.menuThoat.Text = "Thoát";
            // 
            // dgvDanhSachSinhVien
            // 
            this.dgvDanhSachSinhVien.AllowUserToAddRows = false;
            this.dgvDanhSachSinhVien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDanhSachSinhVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvDanhSachSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachSinhVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachSinhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvDanhSachSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colmssv,
            this.colHoTen,
            this.colKhoa,
            this.colDTB,
            this.colChuyenNganh});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachSinhVien.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvDanhSachSinhVien.Location = new System.Drawing.Point(449, 88);
            this.dgvDanhSachSinhVien.MultiSelect = false;
            this.dgvDanhSachSinhVien.Name = "dgvDanhSachSinhVien";
            this.dgvDanhSachSinhVien.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachSinhVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvDanhSachSinhVien.RowHeadersVisible = false;
            this.dgvDanhSachSinhVien.RowHeadersWidth = 45;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDanhSachSinhVien.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvDanhSachSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachSinhVien.Size = new System.Drawing.Size(739, 467);
            this.dgvDanhSachSinhVien.TabIndex = 55;
            this.dgvDanhSachSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachSinhVien_CellClick);
            // 
            // colSTT
            // 
            this.colSTT.DataPropertyName = "colSTT";
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            // 
            // colmssv
            // 
            this.colmssv.DataPropertyName = "colmssv";
            this.colmssv.HeaderText = "MSSV";
            this.colmssv.Name = "colmssv";
            this.colmssv.ReadOnly = true;
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "colHoTen";
            this.colHoTen.HeaderText = "Họ Tên";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.ReadOnly = true;
            // 
            // colKhoa
            // 
            this.colKhoa.DataPropertyName = "colKhoa";
            this.colKhoa.HeaderText = "Khoa";
            this.colKhoa.Name = "colKhoa";
            this.colKhoa.ReadOnly = true;
            // 
            // colDTB
            // 
            this.colDTB.DataPropertyName = "colDTB";
            this.colDTB.HeaderText = "Điểm Trung Bình";
            this.colDTB.Name = "colDTB";
            this.colDTB.ReadOnly = true;
            // 
            // colChuyenNganh
            // 
            this.colChuyenNganh.DataPropertyName = "colChuyenNganh";
            this.colChuyenNganh.HeaderText = "Chuyên Ngành";
            this.colChuyenNganh.Name = "colChuyenNganh";
            this.colChuyenNganh.ReadOnly = true;
            // 
            // btnXoaTimMa
            // 
            this.btnXoaTimMa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnXoaTimMa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaTimMa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaTimMa.Location = new System.Drawing.Point(352, 32);
            this.btnXoaTimMa.Name = "btnXoaTimMa";
            this.btnXoaTimMa.Size = new System.Drawing.Size(178, 46);
            this.btnXoaTimMa.TabIndex = 32;
            this.btnXoaTimMa.Text = "Xoá Mã Sinh Viên";
            this.btnXoaTimMa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaTimMa.UseVisualStyleBackColor = true;
            this.btnXoaTimMa.Click += new System.EventHandler(this.btnXoaTimMa_Click);
            // 
            // lblMaSinhVienXoa
            // 
            this.lblMaSinhVienXoa.AutoSize = true;
            this.lblMaSinhVienXoa.Location = new System.Drawing.Point(6, 46);
            this.lblMaSinhVienXoa.Name = "lblMaSinhVienXoa";
            this.lblMaSinhVienXoa.Size = new System.Drawing.Size(132, 19);
            this.lblMaSinhVienXoa.TabIndex = 13;
            this.lblMaSinhVienXoa.Text = "Mã Sinh Viên Xoá";
            // 
            // txtMaNhanVienXoa
            // 
            this.txtMaNhanVienXoa.Location = new System.Drawing.Point(144, 43);
            this.txtMaNhanVienXoa.Name = "txtMaNhanVienXoa";
            this.txtMaNhanVienXoa.Size = new System.Drawing.Size(196, 27);
            this.txtMaNhanVienXoa.TabIndex = 12;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // gbxXoaMSV
            // 
            this.gbxXoaMSV.Controls.Add(this.btnXoaTimMa);
            this.gbxXoaMSV.Controls.Add(this.lblMaSinhVienXoa);
            this.gbxXoaMSV.Controls.Add(this.txtMaNhanVienXoa);
            this.gbxXoaMSV.Location = new System.Drawing.Point(631, 569);
            this.gbxXoaMSV.Name = "gbxXoaMSV";
            this.gbxXoaMSV.Size = new System.Drawing.Size(536, 94);
            this.gbxXoaMSV.TabIndex = 56;
            this.gbxXoaMSV.TabStop = false;
            this.gbxXoaMSV.Text = "Xoá Thông Tin Sinh Viên Theo MSV";
            // 
            // gbxThongTinSinhVien
            // 
            this.gbxThongTinSinhVien.Controls.Add(this.btnAddAnh);
            this.gbxThongTinSinhVien.Controls.Add(this.lblAnhDaiDien);
            this.gbxThongTinSinhVien.Controls.Add(this.picAnhDaiDien);
            this.gbxThongTinSinhVien.Controls.Add(this.lblKhoa);
            this.gbxThongTinSinhVien.Controls.Add(this.cbxKhoa);
            this.gbxThongTinSinhVien.Controls.Add(this.txtDiemTB);
            this.gbxThongTinSinhVien.Controls.Add(this.lblDiemTB);
            this.gbxThongTinSinhVien.Controls.Add(this.txtHoTen);
            this.gbxThongTinSinhVien.Controls.Add(this.lblHoTen);
            this.gbxThongTinSinhVien.Controls.Add(this.lblMaSinhVien);
            this.gbxThongTinSinhVien.Controls.Add(this.txtMaSinhVien);
            this.gbxThongTinSinhVien.Location = new System.Drawing.Point(12, 157);
            this.gbxThongTinSinhVien.Name = "gbxThongTinSinhVien";
            this.gbxThongTinSinhVien.Size = new System.Drawing.Size(412, 398);
            this.gbxThongTinSinhVien.TabIndex = 54;
            this.gbxThongTinSinhVien.TabStop = false;
            this.gbxThongTinSinhVien.Text = "Thông tin sinh viên";
            // 
            // btnAddAnh
            // 
            this.btnAddAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAnh.Location = new System.Drawing.Point(371, 357);
            this.btnAddAnh.Name = "btnAddAnh";
            this.btnAddAnh.Size = new System.Drawing.Size(35, 27);
            this.btnAddAnh.TabIndex = 14;
            this.btnAddAnh.Text = "...";
            this.btnAddAnh.UseVisualStyleBackColor = true;
            this.btnAddAnh.Click += new System.EventHandler(this.btnAddAnh_Click);
            // 
            // lblAnhDaiDien
            // 
            this.lblAnhDaiDien.AutoSize = true;
            this.lblAnhDaiDien.Location = new System.Drawing.Point(27, 250);
            this.lblAnhDaiDien.Name = "lblAnhDaiDien";
            this.lblAnhDaiDien.Size = new System.Drawing.Size(94, 19);
            this.lblAnhDaiDien.TabIndex = 13;
            this.lblAnhDaiDien.Text = "Ảnh đại diện";
            // 
            // picAnhDaiDien
            // 
            this.picAnhDaiDien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picAnhDaiDien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picAnhDaiDien.Location = new System.Drawing.Point(169, 250);
            this.picAnhDaiDien.Name = "picAnhDaiDien";
            this.picAnhDaiDien.Size = new System.Drawing.Size(196, 134);
            this.picAnhDaiDien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnhDaiDien.TabIndex = 12;
            this.picAnhDaiDien.TabStop = false;
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(27, 191);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(107, 19);
            this.lblKhoa.TabIndex = 11;
            this.lblKhoa.Text = "Chuyên Ngành";
            // 
            // cbxKhoa
            // 
            this.cbxKhoa.FormattingEnabled = true;
            this.cbxKhoa.Location = new System.Drawing.Point(169, 183);
            this.cbxKhoa.Name = "cbxKhoa";
            this.cbxKhoa.Size = new System.Drawing.Size(196, 27);
            this.cbxKhoa.TabIndex = 6;
            // 
            // txtDiemTB
            // 
            this.txtDiemTB.Location = new System.Drawing.Point(169, 132);
            this.txtDiemTB.Name = "txtDiemTB";
            this.txtDiemTB.Size = new System.Drawing.Size(196, 27);
            this.txtDiemTB.TabIndex = 5;
            this.txtDiemTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDiemTB
            // 
            this.lblDiemTB.AutoSize = true;
            this.lblDiemTB.Location = new System.Drawing.Point(27, 140);
            this.lblDiemTB.Name = "lblDiemTB";
            this.lblDiemTB.Size = new System.Drawing.Size(71, 19);
            this.lblDiemTB.TabIndex = 8;
            this.lblDiemTB.Text = "Điểm TB";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(169, 85);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(196, 27);
            this.txtHoTen.TabIndex = 2;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(27, 93);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(59, 19);
            this.lblHoTen.TabIndex = 3;
            this.lblHoTen.Text = "Họ Tên";
            // 
            // lblMaSinhVien
            // 
            this.lblMaSinhVien.AutoSize = true;
            this.lblMaSinhVien.Location = new System.Drawing.Point(27, 46);
            this.lblMaSinhVien.Name = "lblMaSinhVien";
            this.lblMaSinhVien.Size = new System.Drawing.Size(100, 19);
            this.lblMaSinhVien.TabIndex = 2;
            this.lblMaSinhVien.Text = "Mã Sinh Viên";
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.Location = new System.Drawing.Point(169, 38);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.Size = new System.Drawing.Size(196, 27);
            this.txtMaSinhVien.TabIndex = 1;
            // 
            // lblQuanLyThongTinSinhVien
            // 
            this.lblQuanLyThongTinSinhVien.AutoSize = true;
            this.lblQuanLyThongTinSinhVien.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLyThongTinSinhVien.ForeColor = System.Drawing.Color.Blue;
            this.lblQuanLyThongTinSinhVien.Location = new System.Drawing.Point(66, 88);
            this.lblQuanLyThongTinSinhVien.Name = "lblQuanLyThongTinSinhVien";
            this.lblQuanLyThongTinSinhVien.Size = new System.Drawing.Size(286, 31);
            this.lblQuanLyThongTinSinhVien.TabIndex = 53;
            this.lblQuanLyThongTinSinhVien.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // chkChuaDkChuyenNganh
            // 
            this.chkChuaDkChuyenNganh.AutoSize = true;
            this.chkChuaDkChuyenNganh.Location = new System.Drawing.Point(956, 59);
            this.chkChuaDkChuyenNganh.Name = "chkChuaDkChuyenNganh";
            this.chkChuaDkChuyenNganh.Size = new System.Drawing.Size(228, 23);
            this.chkChuaDkChuyenNganh.TabIndex = 60;
            this.chkChuaDkChuyenNganh.Text = "Chưa Đăng Ký Chuyên Ngành";
            this.chkChuaDkChuyenNganh.UseVisualStyleBackColor = true;
            this.chkChuaDkChuyenNganh.CheckedChanged += new System.EventHandler(this.chkUnregisterMajor_CheckedChanged);
            // 
            // toolMain
            // 
            this.toolMain.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQuanLyKhoa,
            this.lblQuanLyKhoa,
            this.btnTimKiem,
            this.lblTimKiem,
            this.btnDangKyChuyenNganh,
            this.lblDangKyChuyenNganh});
            this.toolMain.Location = new System.Drawing.Point(0, 27);
            this.toolMain.Name = "toolMain";
            this.toolMain.Size = new System.Drawing.Size(1200, 25);
            this.toolMain.TabIndex = 61;
            this.toolMain.Text = "toolStrip1";
            // 
            // btnQuanLyKhoa
            // 
            this.btnQuanLyKhoa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnQuanLyKhoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuanLyKhoa.Name = "btnQuanLyKhoa";
            this.btnQuanLyKhoa.Size = new System.Drawing.Size(23, 22);
            this.btnQuanLyKhoa.Text = "Quản lý khoa";
            // 
            // lblQuanLyKhoa
            // 
            this.lblQuanLyKhoa.Name = "lblQuanLyKhoa";
            this.lblQuanLyKhoa.Size = new System.Drawing.Size(86, 22);
            this.lblQuanLyKhoa.Text = "Quản lý khoa";
            this.lblQuanLyKhoa.Click += new System.EventHandler(this.lblQuanLyKhoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTimKiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(23, 22);
            this.btnTimKiem.Text = "Tìm kiếm";
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(63, 22);
            this.lblTimKiem.Text = "Tìm kiếm";
            // 
            // btnDangKyChuyenNganh
            // 
            this.btnDangKyChuyenNganh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDangKyChuyenNganh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDangKyChuyenNganh.Name = "btnDangKyChuyenNganh";
            this.btnDangKyChuyenNganh.Size = new System.Drawing.Size(23, 22);
            this.btnDangKyChuyenNganh.Text = "Đăng ký chuyên ngành";
            // 
            // lblDangKyChuyenNganh
            // 
            this.lblDangKyChuyenNganh.Name = "lblDangKyChuyenNganh";
            this.lblDangKyChuyenNganh.Size = new System.Drawing.Size(143, 22);
            this.lblDangKyChuyenNganh.Text = "Đăng ký chuyên ngành";
            this.lblDangKyChuyenNganh.Click += new System.EventHandler(this.lblDangKyChuyenNganh_Click);
            // 
            // frmQuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 677);
            this.Controls.Add(this.toolMain);
            this.Controls.Add(this.chkChuaDkChuyenNganh);
            this.Controls.Add(this.gbxChucNang);
            this.Controls.Add(this.menuMain);
            this.Controls.Add(this.dgvDanhSachSinhVien);
            this.Controls.Add(this.gbxXoaMSV);
            this.Controls.Add(this.gbxThongTinSinhVien);
            this.Controls.Add(this.lblQuanLyThongTinSinhVien);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLySinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            this.gbxChucNang.ResumeLayout(false);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.gbxXoaMSV.ResumeLayout(false);
            this.gbxXoaMSV.PerformLayout();
            this.gbxThongTinSinhVien.ResumeLayout(false);
            this.gbxThongTinSinhVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhDaiDien)).EndInit();
            this.toolMain.ResumeLayout(false);
            this.toolMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxChucNang;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuMainChucNang;
        private System.Windows.Forms.ToolStripMenuItem menuQuanLyKhoa;
        private System.Windows.Forms.ToolStripMenuItem menuTimKiem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuThoat;
        private System.Windows.Forms.DataGridView dgvDanhSachSinhVien;
        private System.Windows.Forms.Button btnXoaTimMa;
        private System.Windows.Forms.Label lblMaSinhVienXoa;
        private System.Windows.Forms.TextBox txtMaNhanVienXoa;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.ToolStrip toolMain;
        private System.Windows.Forms.ToolStripButton btnQuanLyKhoa;
        private System.Windows.Forms.ToolStripLabel lblQuanLyKhoa;
        private System.Windows.Forms.ToolStripButton btnTimKiem;
        private System.Windows.Forms.ToolStripLabel lblTimKiem;
        private System.Windows.Forms.CheckBox chkChuaDkChuyenNganh;
        private System.Windows.Forms.GroupBox gbxXoaMSV;
        private System.Windows.Forms.GroupBox gbxThongTinSinhVien;
        private System.Windows.Forms.Label lblAnhDaiDien;
        private System.Windows.Forms.PictureBox picAnhDaiDien;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.ComboBox cbxKhoa;
        private System.Windows.Forms.TextBox txtDiemTB;
        private System.Windows.Forms.Label lblDiemTB;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMaSinhVien;
        private System.Windows.Forms.TextBox txtMaSinhVien;
        private System.Windows.Forms.Label lblQuanLyThongTinSinhVien;
        private System.Windows.Forms.Button btnAddAnh;
        private System.Windows.Forms.ToolStripButton btnDangKyChuyenNganh;
        private System.Windows.Forms.ToolStripLabel lblDangKyChuyenNganh;
        private System.Windows.Forms.ToolStripMenuItem menuDangKyChuyenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmssv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChuyenNganh;
    }
}