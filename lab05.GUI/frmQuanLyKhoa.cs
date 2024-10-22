using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab05.BUS;
using Lab05.DAL.Entities;

namespace lab05.GUI
{
    public partial class frmQuanLyKhoa : Form
    {
        private FacultyService facultyService = new FacultyService();

        public frmQuanLyKhoa()
        {
            InitializeComponent();
           frmQuanLyKhoa_Load(this,EventArgs.Empty);
            
        }

        private void frmQuanLyKhoa_Load(object sender, EventArgs e)
        {
            
            try
            {
                setGridViewStyle(dgvDanhSachKhoa);

                var faculties = facultyService.GetAll();
                MessageBox.Show("Số lượng khoa: " + faculties.Count);

                BindGrid(faculties);
            }
            catch (Exception ex) { }

        }

        private void BindGrid(List<Faculty> listFaculty)
        {
            dgvDanhSachKhoa.Rows.Clear();

            // Kiểm tra nếu listStudent không rỗng
            if (listFaculty == null || !listFaculty.Any())
            {
                MessageBox.Show("Không có dữ liệu sinh viên để hiển thị.");
                return;
            }

            var facultyData = listFaculty.Select((faculty, index) => new

            {
                colSTT = index + 1, 
                colFacultyID = faculty.FacultyID, 
                colFullName = faculty.FacultyName, 
            }).ToList();

            foreach (var item in facultyData) {
                int index = dgvDanhSachKhoa.Rows.Add();
                dgvDanhSachKhoa.Rows[index].Cells["colSTT"].Value = item.colSTT;
                dgvDanhSachKhoa.Rows[index].Cells["colFacultyID"].Value = item.colFacultyID;
                dgvDanhSachKhoa.Rows[index].Cells["colFacultyName"].Value = item.colFullName;
            }
        }

        private void setGridViewStyle(DataGridView dgv)
        {
            // Thiết lập giao diện tiêu đề cột
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font(dgv.Font, FontStyle.Bold);

            // Tùy chỉnh giao diện cho các hàng
            dgv.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Đặt căn lề cho các ô
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Thiết lập chiều cao hàng và chiều rộng cột tự động điều chỉnh theo nội dung
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Loại bỏ viền mặc định của các ô (cells)
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // Thiết lập màu nền xen kẽ cho các hàng
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }
    }
}
