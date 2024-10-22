using Lab05.BUS;
using Lab05.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab05.GUI
{
    public partial class frmRegister : Form
    {
        private readonly StudentService studentService = new StudentService();
        private readonly FacultyService facultyService = new FacultyService();
        private readonly MajorService majorService = new MajorService();
        public frmRegister()
        {
            InitializeComponent();
            frmRegister_Load(this,EventArgs.Empty);
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            try
            {
                setGridViewStyle(dgvDanhSachDangKy);
                var listFacultys = facultyService.GetAll();
                var listStudents = studentService.GetAll();
                FillFacultyCombobox(listFacultys);

                // Lấy facultyID từ khoa đầu tiên (nếu có) hoặc từ khoa người dùng đã chọn
                if (listFacultys != null && listFacultys.Count > 0)
                {
                    int facultyID = listFacultys[0].FacultyID; // Lấy facultyID của khoa đầu tiên
                    var listMajor = majorService.GetAllByFaculty(facultyID);
                    FillMajorCombobox(listMajor);
                    BindGird(listStudents);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void FillFacultyCombobox(List<Faculty> listFacultys)
        {
            this.cbxKhoa.DataSource = listFacultys;
            this.cbxKhoa.DisplayMember = "FacultyName";
            this.cbxKhoa.ValueMember = "FacultyID";
        }

        private void cmbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            Faculty selectedFaculty = cbxKhoa.SelectedItem as Faculty;
            if (selectedFaculty != null)
            {
                var listMajor = majorService.GetAllByFaculty(selectedFaculty.FacultyID);
                FillMajorCombobox(listMajor);
                var listStudent = studentService.GetALLHasNoMajor(selectedFaculty.FacultyID);
                BindGird(listStudent);
            }
        }

        private void FillMajorCombobox(List<Major> listMajor)
        {
            this.cbxChuyenNganh.DataSource = listMajor;
            this.cbxChuyenNganh.DisplayMember = "FacultyID";
            this.cbxChuyenNganh.DisplayMember = "Name";
            this.cbxChuyenNganh.ValueMember = "MajorID";
        }

        private void BindGird(List<Student> listStudent)
        {
            dgvDanhSachDangKy.Rows.Clear();
            foreach (var item in listStudent) {
                int index = dgvDanhSachDangKy.Rows.Add();
                dgvDanhSachDangKy.Rows[index].Cells["colmssv"].Value = item.StudentID;
                dgvDanhSachDangKy.Rows[index].Cells["colHoTen"].Value = item.FullName;
                if(item.Faculty != null )
                    dgvDanhSachDangKy.Rows[index].Cells["colKhoa"].Value = item.Faculty.FacultyName;
                dgvDanhSachDangKy.Rows[index].Cells["colDTB"].Value = item.AverageScore + "";
                if (item.MajorID != null)
                    dgvDanhSachDangKy.Rows[index].Cells["colChuyenNganh"].Value = item.Major.Name + "";
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

        private void chkUnregisterMajor_CheckedChanged(object sender, EventArgs e)
        {
            var listStudents = new List<Student>();
            if (this.chkChuaDkChuyenNganh.Checked)
                listStudents = studentService.GetALLHasNoMajor();
            else
                listStudents = studentService.GetAll();
            BindGird(listStudents);
        }
    }
}
