namespace lab05.GUI
{
    partial class frmQuanLyKhoa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.gbxChucNang = new System.Windows.Forms.GroupBox();
            this.btnThoatKhoa = new System.Windows.Forms.Button();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.lblTenKhoa = new System.Windows.Forms.Label();
            this.lblMaKhoa = new System.Windows.Forms.Label();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.gbxThongTinSinhVien = new System.Windows.Forms.GroupBox();
            this.lblQuanLyThongTinKhoa = new System.Windows.Forms.Label();
            this.dgvDanhSachKhoa = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFacultyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFacultyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.gbxChucNang.SuspendLayout();
            this.gbxThongTinSinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(5, 36);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 42);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.Text = "Thêm/Sửa";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyBo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyBo.Location = new System.Drawing.Point(205, 36);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(102, 42);
            this.btnHuyBo.TabIndex = 49;
            this.btnHuyBo.Text = "Huỷ Bỏ";
            this.btnHuyBo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(105, 36);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 42);
            this.btnXoa.TabIndex = 38;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // gbxChucNang
            // 
            this.gbxChucNang.Controls.Add(this.btnAdd);
            this.gbxChucNang.Controls.Add(this.btnHuyBo);
            this.gbxChucNang.Controls.Add(this.btnXoa);
            this.gbxChucNang.Controls.Add(this.btnThoatKhoa);
            this.gbxChucNang.Location = new System.Drawing.Point(19, 267);
            this.gbxChucNang.Name = "gbxChucNang";
            this.gbxChucNang.Size = new System.Drawing.Size(412, 98);
            this.gbxChucNang.TabIndex = 55;
            this.gbxChucNang.TabStop = false;
            this.gbxChucNang.Text = "Chức Năng";
            // 
            // btnThoatKhoa
            // 
            this.btnThoatKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoatKhoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoatKhoa.Location = new System.Drawing.Point(310, 36);
            this.btnThoatKhoa.Name = "btnThoatKhoa";
            this.btnThoatKhoa.Size = new System.Drawing.Size(96, 42);
            this.btnThoatKhoa.TabIndex = 46;
            this.btnThoatKhoa.Text = "Trở lại";
            this.btnThoatKhoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoatKhoa.UseVisualStyleBackColor = true;
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(168, 108);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(196, 27);
            this.txtTenKhoa.TabIndex = 2;
            // 
            // lblTenKhoa
            // 
            this.lblTenKhoa.AutoSize = true;
            this.lblTenKhoa.Location = new System.Drawing.Point(26, 116);
            this.lblTenKhoa.Name = "lblTenKhoa";
            this.lblTenKhoa.Size = new System.Drawing.Size(74, 19);
            this.lblTenKhoa.TabIndex = 3;
            this.lblTenKhoa.Text = "Tên Khoa";
            // 
            // lblMaKhoa
            // 
            this.lblMaKhoa.AutoSize = true;
            this.lblMaKhoa.Location = new System.Drawing.Point(26, 69);
            this.lblMaKhoa.Name = "lblMaKhoa";
            this.lblMaKhoa.Size = new System.Drawing.Size(71, 19);
            this.lblMaKhoa.TabIndex = 2;
            this.lblMaKhoa.Text = "Mã Khoa";
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(168, 61);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(196, 27);
            this.txtMaKhoa.TabIndex = 1;
            // 
            // gbxThongTinSinhVien
            // 
            this.gbxThongTinSinhVien.Controls.Add(this.txtTenKhoa);
            this.gbxThongTinSinhVien.Controls.Add(this.lblTenKhoa);
            this.gbxThongTinSinhVien.Controls.Add(this.lblMaKhoa);
            this.gbxThongTinSinhVien.Controls.Add(this.txtMaKhoa);
            this.gbxThongTinSinhVien.Location = new System.Drawing.Point(19, 71);
            this.gbxThongTinSinhVien.Name = "gbxThongTinSinhVien";
            this.gbxThongTinSinhVien.Size = new System.Drawing.Size(412, 178);
            this.gbxThongTinSinhVien.TabIndex = 53;
            this.gbxThongTinSinhVien.TabStop = false;
            this.gbxThongTinSinhVien.Text = "Thông tin sinh viên";
            // 
            // lblQuanLyThongTinKhoa
            // 
            this.lblQuanLyThongTinKhoa.AutoSize = true;
            this.lblQuanLyThongTinKhoa.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLyThongTinKhoa.ForeColor = System.Drawing.Color.Blue;
            this.lblQuanLyThongTinKhoa.Location = new System.Drawing.Point(118, 12);
            this.lblQuanLyThongTinKhoa.Name = "lblQuanLyThongTinKhoa";
            this.lblQuanLyThongTinKhoa.Size = new System.Drawing.Size(228, 31);
            this.lblQuanLyThongTinKhoa.TabIndex = 52;
            this.lblQuanLyThongTinKhoa.Text = "QUẢN LÝ KHOA";
            // 
            // dgvDanhSachKhoa
            // 
            this.dgvDanhSachKhoa.AllowUserToAddRows = false;
            this.dgvDanhSachKhoa.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDanhSachKhoa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachKhoa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDanhSachKhoa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachKhoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colFacultyID,
            this.colFacultyName});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachKhoa.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhSachKhoa.Location = new System.Drawing.Point(457, 12);
            this.dgvDanhSachKhoa.MultiSelect = false;
            this.dgvDanhSachKhoa.Name = "dgvDanhSachKhoa";
            this.dgvDanhSachKhoa.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachKhoa.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDanhSachKhoa.RowHeadersVisible = false;
            this.dgvDanhSachKhoa.RowHeadersWidth = 45;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDanhSachKhoa.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDanhSachKhoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachKhoa.Size = new System.Drawing.Size(718, 353);
            this.dgvDanhSachKhoa.TabIndex = 54;
            // 
            // colSTT
            // 
            this.colSTT.DataPropertyName = "colSTT";
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            // 
            // colFacultyID
            // 
            this.colFacultyID.DataPropertyName = "colFacultyID";
            this.colFacultyID.HeaderText = "Mã Khoa";
            this.colFacultyID.Name = "colFacultyID";
            this.colFacultyID.ReadOnly = true;
            // 
            // colFacultyName
            // 
            this.colFacultyName.DataPropertyName = "colFacultyName";
            this.colFacultyName.HeaderText = "Tên Khoa";
            this.colFacultyName.Name = "colFacultyName";
            this.colFacultyName.ReadOnly = true;
            // 
            // frmQuanLyKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 387);
            this.Controls.Add(this.gbxChucNang);
            this.Controls.Add(this.gbxThongTinSinhVien);
            this.Controls.Add(this.lblQuanLyThongTinKhoa);
            this.Controls.Add(this.dgvDanhSachKhoa);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLyKhoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khoa";
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.gbxChucNang.ResumeLayout(false);
            this.gbxThongTinSinhVien.ResumeLayout(false);
            this.gbxThongTinSinhVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKhoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            // Đăng ký sự kiện Click cho btnAdd
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // Đăng ký sự kiện Click cho btnXoa
            this.btnXoa.Click += new System.EventHandler(this.btnDelete_Click);

            // Đăng ký sự kiện Click cho btnThoatKhoa
            this.btnThoatKhoa.Click += new System.EventHandler(this.btnThoatKhoa_Click);
            this.dgvDanhSachKhoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachKhoa_CellClick);
        }

        #endregion

        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.GroupBox gbxChucNang;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoatKhoa;
        private System.Windows.Forms.GroupBox gbxThongTinSinhVien;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.Label lblTenKhoa;
        private System.Windows.Forms.Label lblMaKhoa;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.Label lblQuanLyThongTinKhoa;
        private System.Windows.Forms.DataGridView dgvDanhSachKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacultyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacultyName;
    }
}
