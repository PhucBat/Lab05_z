using System;

namespace lab05.GUI
{
    partial class frmRegister
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDangKyChuyenNganh = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.cbxKhoa = new System.Windows.Forms.ComboBox();
            this.dgvDanhSachDangKy = new System.Windows.Forms.DataGridView();
            this.cbxChuyenNganh = new System.Windows.Forms.ComboBox();
            this.lblChuyenNganh = new System.Windows.Forms.Label();
            this.btnDangKyChuyenNganh = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.chkChuaDkChuyenNganh = new System.Windows.Forms.CheckBox();
            this.colChon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colmssv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChuyenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDangKy)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDangKyChuyenNganh
            // 
            this.lblDangKyChuyenNganh.AutoSize = true;
            this.lblDangKyChuyenNganh.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangKyChuyenNganh.ForeColor = System.Drawing.Color.Blue;
            this.lblDangKyChuyenNganh.Location = new System.Drawing.Point(384, 9);
            this.lblDangKyChuyenNganh.Name = "lblDangKyChuyenNganh";
            this.lblDangKyChuyenNganh.Size = new System.Drawing.Size(376, 31);
            this.lblDangKyChuyenNganh.TabIndex = 54;
            this.lblDangKyChuyenNganh.Text = "ĐĂNG KÝ CHUYÊN NGÀNH";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(345, 71);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(45, 19);
            this.lblKhoa.TabIndex = 55;
            this.lblKhoa.Text = "Khoa";

            // 
            // cbxKhoa
            // 
            this.cbxKhoa.FormattingEnabled = true;
            this.cbxKhoa.Location = new System.Drawing.Point(458, 68);
            this.cbxKhoa.Name = "cbxKhoa";
            this.cbxKhoa.Size = new System.Drawing.Size(323, 27);
            this.cbxKhoa.TabIndex = 56;
            this.cbxKhoa.SelectedIndexChanged += new EventHandler(cmbFaculty_SelectedIndexChanged);
            // 
            // dgvDanhSachDangKy
            // 
            this.dgvDanhSachDangKy.AllowUserToAddRows = false;
            this.dgvDanhSachDangKy.AllowUserToDeleteRows = false;
            this.dgvDanhSachDangKy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachDangKy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachDangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachDangKy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChon,
            this.colmssv,
            this.colHoTen,
            this.colKhoa,
            this.colDTB,
            this.colChuyenNganh});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachDangKy.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachDangKy.Location = new System.Drawing.Point(12, 174);
            this.dgvDanhSachDangKy.Name = "dgvDanhSachDangKy";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachDangKy.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDanhSachDangKy.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDanhSachDangKy.Size = new System.Drawing.Size(1176, 472);
            this.dgvDanhSachDangKy.TabIndex = 57;
            // 
            // cbxChuyenNganh
            // 
            this.cbxChuyenNganh.FormattingEnabled = true;
            this.cbxChuyenNganh.Location = new System.Drawing.Point(458, 117);
            this.cbxChuyenNganh.Name = "cbxChuyenNganh";
            this.cbxChuyenNganh.Size = new System.Drawing.Size(323, 27);
            this.cbxChuyenNganh.TabIndex = 59;
            // 
            // lblChuyenNganh
            // 
            this.lblChuyenNganh.AutoSize = true;
            this.lblChuyenNganh.Location = new System.Drawing.Point(345, 120);
            this.lblChuyenNganh.Name = "lblChuyenNganh";
            this.lblChuyenNganh.Size = new System.Drawing.Size(107, 19);
            this.lblChuyenNganh.TabIndex = 58;
            this.lblChuyenNganh.Text = "Chuyên Ngành";
            // 
            // btnDangKyChuyenNganh
            // 
            this.btnDangKyChuyenNganh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKyChuyenNganh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangKyChuyenNganh.Location = new System.Drawing.Point(941, 121);
            this.btnDangKyChuyenNganh.Name = "btnDangKyChuyenNganh";
            this.btnDangKyChuyenNganh.Size = new System.Drawing.Size(129, 47);
            this.btnDangKyChuyenNganh.TabIndex = 60;
            this.btnDangKyChuyenNganh.Text = "Đăng ký";
            this.btnDangKyChuyenNganh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangKyChuyenNganh.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(1076, 121);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 47);
            this.btnThoat.TabIndex = 61;
            this.btnThoat.Text = "Trở lại";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // chkChuaDkChuyenNganh
            // 
            this.chkChuaDkChuyenNganh.AutoSize = true;
            this.chkChuaDkChuyenNganh.Location = new System.Drawing.Point(12, 134);
            this.chkChuaDkChuyenNganh.Name = "chkChuaDkChuyenNganh";
            this.chkChuaDkChuyenNganh.Size = new System.Drawing.Size(228, 23);
            this.chkChuaDkChuyenNganh.TabIndex = 62;
            this.chkChuaDkChuyenNganh.Text = "Chưa Đăng Ký Chuyên Ngành";
            this.chkChuaDkChuyenNganh.UseVisualStyleBackColor = true;
            this.chkChuaDkChuyenNganh.CheckedChanged += new System.EventHandler(this.chkUnregisterMajor_CheckedChanged);
            // 
            // colChon
            // 
            this.colChon.HeaderText = "Chọn";
            this.colChon.Name = "colChon";
            this.colChon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colChon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.chkChuaDkChuyenNganh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangKyChuyenNganh);
            this.Controls.Add(this.cbxChuyenNganh);
            this.Controls.Add(this.lblChuyenNganh);
            this.Controls.Add(this.dgvDanhSachDangKy);
            this.Controls.Add(this.cbxKhoa);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.lblDangKyChuyenNganh);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý đăng ký chuyên ngành";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDangKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDangKyChuyenNganh;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.ComboBox cbxKhoa;
        private System.Windows.Forms.DataGridView dgvDanhSachDangKy;
        private System.Windows.Forms.ComboBox cbxChuyenNganh;
        private System.Windows.Forms.Label lblChuyenNganh;
        private System.Windows.Forms.Button btnDangKyChuyenNganh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.CheckBox chkChuaDkChuyenNganh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmssv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChuyenNganh;
    }
}