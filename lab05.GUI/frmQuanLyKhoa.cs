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
            frmQuanLyKhoa_Load(this, EventArgs.Empty);

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
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Faculty faculty = new Faculty
            {
                FacultyID = int.Parse(txtMaKhoa.Text),
                FacultyName = txtTenKhoa.Text
            };

            FacultyService facultyService = new FacultyService();

            // Kiểm tra xem khoa đã tồn tại hay chưa
            var existingFaculty = facultyService.GetAll().FirstOrDefault(f => f.FacultyID == faculty.FacultyID);
            if (existingFaculty != null)
            {
                // Nếu khoa đã tồn tại, cập nhật thông tin
                existingFaculty.FacultyName = faculty.FacultyName;
                facultyService.Update(existingFaculty);
                MessageBox.Show("Cập nhật khoa thành công!");
            }
            else
            {
                // Nếu khoa chưa tồn tại, thêm mới
                facultyService.Add(faculty);
                MessageBox.Show("Thêm khoa thành công!");
            }

            // LoadData(); // Cập nhật lại DataGridView
            frmQuanLyKhoa_Load(this, EventArgs.Empty); // Refresh DataGridView
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (dgvDanhSachKhoa.SelectedRows.Count > 0)
            {
                int facultyID = (int)dgvDanhSachKhoa.SelectedRows[0].Cells["colFacultyID"].Value;

                // Xóa khoa
                facultyService.Delete(facultyID);
                MessageBox.Show("Xóa khoa thành công!");

                // Refresh DataGridView
                frmQuanLyKhoa_Load(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khoa để xóa.");
            }
        }

        private void btnThoatKhoa_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra kết quả của hộp thoại
            if (result == DialogResult.Yes)
            {
                this.Close(); // Đóng form nếu người dùng chọn Yes
            }
        }

        private void dgvDanhSachKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the click is on a valid row
            if (e.RowIndex >= 0)
            {
                // Retrieve the selected faculty's ID
                int facultyID = (int)dgvDanhSachKhoa.Rows[e.RowIndex].Cells["colFacultyID"].Value;

                // Retrieve the selected faculty's name
                string facultyName = dgvDanhSachKhoa.Rows[e.RowIndex].Cells["colFacultyName"].Value.ToString();

                // Display or process the selected faculty information
                MessageBox.Show($"Selected Faculty ID: {facultyID}, Name: {facultyName}");

                // Reflect the selected faculty information back into the input fields
                txtMaKhoa.Text = facultyID.ToString();
                txtTenKhoa.Text = facultyName;
            }
        }
    }
}
