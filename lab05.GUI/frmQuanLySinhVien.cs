using Lab05.BUS;
using Lab05.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace lab05.GUI
{
    public partial class frmQuanLySinhVien : Form
    {
        private readonly StudentService studentService = new StudentService();
        private readonly FacultyService facultyService = new FacultyService();
        // Declare a class-level variable to hold the image path
        private string selectedImagePath;
        private readonly string[] imageExtensions = {".jpg",".jpeg",".png",".bmp" };
        public frmQuanLySinhVien()
        {
            InitializeComponent();
            frmQuanLySinhVien_Load(this, EventArgs.Empty); // Gọi phương thức frmQuanLySinhVien_Load

        }

        private void frmQuanLySinhVien_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form Loaded");
            try
            {
                setGridViewStyle(dgvDanhSachSinhVien);
                // Lấy danh sách khoa
                var listFacultys = facultyService.GetAll();
                MessageBox.Show("Số lượng khoa: " + listFacultys.Count);
                
                // Lấy danh sách sinh viên từ cơ sở dữ liệu
                var listStudents = studentService.GetAll(); // Đảm bảo rằng phương thức này lấy dữ liệu từ CSDL
                MessageBox.Show("Số lượng sinh viên: " + listStudents.Count);
                
                FillFalcultyCombobox(listFacultys);
                BindGrid(listStudents);
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
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

        public void FillFalcultyCombobox(List<Faculty> listFacultys)
        {
            listFacultys.Insert(0, new Faculty());
            this.cbxKhoa.DataSource = listFacultys;
            this.cbxKhoa.DisplayMember = "FacultyName";
            this.cbxKhoa.ValueMember = "FacultyID";
        }

        private void BindGrid(List<Student> listStudent)
        {
            dgvDanhSachSinhVien.Rows.Clear();
            
            // Kiểm tra nếu listStudent không rỗng
            if (listStudent == null || !listStudent.Any())
            {
                MessageBox.Show("Không có dữ liệu sinh viên để hiển thị.");
                return;
            }

            // Sử dụng LINQ để tạo danh sách với chỉ số STT
            var studentData = listStudent.Select((student, index) => new
            
            {
                colSTT = index + 1, // Số thứ tự
                colStudentID = student.StudentID, // MSSV
                colFullName = student.FullName, // Họ tên
                colAverageScore = student.AverageScore, // Điểm trung bình
                colMajorName = student.MajorID != null ? student.Major.Name : string.Empty, // Chuyên ngành
                colFacultyName = student.FacultyID != null ? student.Faculty.FacultyName : string.Empty
            }).ToList();

            foreach (var item in studentData)
            {
                int index = dgvDanhSachSinhVien.Rows.Add();
                dgvDanhSachSinhVien.Rows[index].Cells["colSTT"].Value = item.colSTT; // Gán giá trị cho cột STT
                dgvDanhSachSinhVien.Rows[index].Cells["colmssv"].Value = item.colStudentID; // Gán giá trị cho cột MSSV
                dgvDanhSachSinhVien.Rows[index].Cells["colHoTen"].Value = item.colFullName; // Gán giá trị cho cột Họ tên
                dgvDanhSachSinhVien.Rows[index].Cells["colDTB"].Value = item.colAverageScore; // Gán giá trị cho cột Điểm trung bình
                dgvDanhSachSinhVien.Rows[index].Cells["colChuyenNganh"].Value = item.colMajorName; // Gán giá trị cho cột Chuyên ngành
                dgvDanhSachSinhVien.Rows[index].Cells["colKhoa"].Value = item.colFacultyName;
            }
        }

        private void ShowAvatar(string imageName)
        {
            if (string.IsNullOrEmpty(imageName))
            {
                picAnhDaiDien.Image = null;
            }
            else
            {
                string studentID = txtMaSinhVien.Text.Trim();
                string fileExtension = Path.GetExtension(imageName);

                if (string.IsNullOrEmpty(fileExtension))
                {
                    fileExtension = ".png";
                    MessageBox.Show("Đường dẫn hình ảnh không có phần mở rộng. Sử dụng phần mở rộng mặc định: " + fileExtension);
                }

                string newFileName = $"{studentID}{fileExtension}";
                string imagesDirectory = @"C:\Users\DIMON\source\repos\Images"; // Cập nhật đường dẫn lưu ảnh
                if (!Directory.Exists(imagesDirectory))
                {
                    Directory.CreateDirectory(imagesDirectory);
                }

                // Check if the image file exists before trying to open it
                if (File.Exists(imageName))
                {
                    if (picAnhDaiDien.Image != null)
                    {
                        picAnhDaiDien.Image.Dispose();
                        picAnhDaiDien.Image = null;
                    }

                    string destinationPath = Path.Combine(imagesDirectory, newFileName);
                    // Remove the redundant File.Copy here
                    // File.Copy(imageName, destinationPath, true); // This line is removed

                    // Properly dispose of the file stream after loading the image
                    using (FileStream stream = new FileStream(imageName, FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        picAnhDaiDien.Image = Image.FromStream(stream);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tệp nguồn SV: " + imageName);
                }
            }
        }




        private void chkUnregisterMajor_CheckedChanged(object sender, EventArgs e)
        {
            var listStudents = new List<Student>();
            if (this.chkChuaDkChuyenNganh.Checked)
                listStudents = studentService.GetALLHasNoMajor();
            else
                listStudents = studentService.GetAll();
            BindGrid(listStudents);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nút Thêm/Sửa đã được nhấn!");

            // Kiểm tra dữ liệu nhập
            if (string.IsNullOrEmpty(txtMaSinhVien.Text) || string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên!");
                return; // Nếu thông tin không đầy đủ, dừng lại
            }

            var student = new Student
            {
                StudentID = txtMaSinhVien.Text,
                FullName = txtHoTen.Text,
                AverageScore = double.TryParse(txtDiemTB.Text, out double score) ? score : 0,
                FacultyID = (int?)cbxKhoa.SelectedValue,
                MajorID = null, // Hoặc giá trị tương ứng
                Avatar = picAnhDaiDien.Image != null ? $"{txtMaSinhVien.Text}{Path.GetExtension(picAnhDaiDien.ImageLocation)}" : null // Thêm thuộc tính Avatar
            };

            try
            {
                // Kiểm tra nếu thư mục ảnh tồn tại
                string imagesDirectory = @"C:\Users\DIMON\source\repos\Images"; // Cập nhật đường dẫn lưu ảnh
                if (!Directory.Exists(imagesDirectory))
                {
                    Directory.CreateDirectory(imagesDirectory);
                }

                // Tìm sinh viên theo ID
                var existingStudent = studentService.FindById(student.StudentID);
                if (existingStudent != null)
                {
                    MessageBox.Show("Đã tìm thấy sinh viên. Tiến hành cập nhật...");
                    studentService.InsertUpdate(student); // Cập nhật thông tin sinh viên
                    MessageBox.Show("Cập nhật thông tin sinh viên thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên. Thêm mới...");
                    // Nếu sinh viên mới có ảnh đại diện
                    if (!string.IsNullOrEmpty(student.Avatar))
                    {
                        // Sử dụng đường dẫn đã chọn từ btnAddAnh_Click
                        string imagePath = selectedImagePath;

                        // Kiểm tra xem đường dẫn ảnh có hợp lệ không
                        if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                        {
                            studentService.InsertUpdate(student); // Thêm mới sinh viên
                            Console.WriteLine($"Đường dẫn hình ảnh: {imagePath}");
                            studentService.SaveStudentAvatar(student.StudentID, imagePath); // Lưu ảnh sinh viên
                            MessageBox.Show("Thêm sinh viên thành công!");

                            // Thêm thông báo kiểm tra ảnh
                            MessageBox.Show("Sinh viên đã được thêm với ảnh đại diện: " + Path.GetFileName(imagePath));
                        }
                        else
                        {
                            MessageBox.Show("Đường dẫn hình ảnh không hợp lệ. Vui lòng kiểm tra lại.");
                        }
                    }
                    else
                    {
                        // Nếu không có ảnh đại diện
                        MessageBox.Show("Sinh viên đã được thêm nhưng không có ảnh đại diện.");
                    }
                }

                // Kiểm tra sau khi thêm hoặc cập nhật, dữ liệu có được nạp lại vào DataGridView không
                MessageBox.Show("Nạp lại danh sách sinh viên vào DataGridView...");
                var listStudents = studentService.GetAll();
                BindGrid(listStudents); // Nạp lại dữ liệu vào DataGridView
                MessageBox.Show("Đã nạp danh sách sinh viên vào DataGridView!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message); // Hiển thị thông báo lỗi
            }
        }


        private void btnAddAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = openFileDialog.FileName; // Store the selected image path
                    // Hiển thị hình ảnh lên PictureBox
                    ShowAvatar(selectedImagePath); // Gửi đường dẫn đầy đủ của ảnh
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Lấy mã sinh viên từ textbox
            string studentID = txtMaSinhVien.Text;

            if (string.IsNullOrEmpty(studentID))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên để xóa!");
                return;
            }

            try
            {
                // Gọi phương thức xóa sinh viên từ StudentService
                studentService.DeleteStudent(studentID);
                MessageBox.Show("Xóa sinh viên thành công!");

                // Nạp lại danh sách sinh viên vào DataGridView
                var listStudents = studentService.GetAll();
                BindGrid(listStudents);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi xóa sinh viên: " + ex.Message);
            }
        }

        private void btnXoaTimMa_Click(object sender, EventArgs e) // New event handler for the delete button
        {
            string studentID = txtMaNhanVienXoa.Text; // Get the student ID from the textbox

            if (string.IsNullOrEmpty(studentID))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên để xóa!");
                return;
            }

            try
            {
                // Call the method to delete the student from StudentService
                studentService.DeleteStudent(studentID);
                MessageBox.Show("Xóa sinh viên thành công!");

                // Reload the student list into the DataGridView
                var listStudents = studentService.GetAll();
                BindGrid(listStudents);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi xóa sinh viên: " + ex.Message);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e) // New event handler for the cancel button
        {
            // Xóa tất cả thông tin trong các textbox
            txtMaSinhVien.Clear();
            txtHoTen.Clear();
            txtDiemTB.Clear();
            cbxKhoa.SelectedIndex = -1; // Đặt lại combobox
            picAnhDaiDien.Image = null; // Xóa hình ảnh đại diện
            MessageBox.Show("Đã hủy bỏ thông tin nhập.");
        }

        private void btnThoat_Click(object sender, EventArgs e) // New event handler for the exit button
        {
            // Prompt the user for confirmation before exiting
            var result = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Exit the application
            }
        }

        private void dgvDanhSachSinhVien_CellClick(object sender, DataGridViewCellEventArgs e) // New event handler for cell click
        {
            // Kiểm tra nếu người dùng đã nhấp vào một ô hợp lệ
            if (e.RowIndex >= 0) // Đảm bảo rằng hàng được nhấp là hợp lệ
            {
                try
                {
                    // Lấy thông tin sinh viên t các ô trong hàng đã nhấp
                    var selectedRow = dgvDanhSachSinhVien.Rows[e.RowIndex];
                    txtMaSinhVien.Text = selectedRow.Cells["colmssv"].Value.ToString(); // Gán mã sinh viên
                    txtHoTen.Text = selectedRow.Cells["colHoTen"].Value.ToString(); // Gán họ tên
                    txtDiemTB.Text = selectedRow.Cells["colDTB"].Value.ToString(); // Gán điểm trung bình

                    // Gán giá trị khoa
                    var facultyID = selectedRow.Cells["colKhoa"].Value; // Lấy giá trị khoa
                    cbxKhoa.SelectedValue = facultyID; // Gán khoa
                    cbxKhoa.Text = selectedRow.Cells["colKhoa"].FormattedValue.ToString(); // Hiển thị tên khoa

                    picAnhDaiDien.Image = null;
                    // Hiển thị ảnh đại diện nếu có
                    string studentID = selectedRow.Cells["colmssv"].Value.ToString();
                    string imagePath = GetAvatarPath(studentID); // Lấy đường dẫn ảnh đại diện

                    if (imagePath != null)
                    {
                        ShowAvatar(imagePath); // Hiển thị ảnh đại diện
                    }
                    else
                    {
                        // Hiển thị đường dẫn không tìm thấy
                        MessageBox.Show($"Không tìm thấy ảnh đại diện cho sinh viên này. Đường dẫn kiểm tra: {string.Join(", ", imageExtensions.Select(ext => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", $"{studentID}{ext}")))}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Thêm phương thức để lấy đường dẫn ảnh đại diện
        private string GetAvatarPath(string studentID)
        {
            // Loại bỏ khoảng trắng ở đầu và cuối
            studentID = studentID.Trim();

            foreach (var extension in imageExtensions)
            {
                string potentialPath = Path.Combine(@"C:\Users\DIMON\source\repos\Images", $"{studentID}{extension}"); // Cập nhật đường dẫn lưu ảnh
                
                // Debugging: Log the potential path being checked
                Console.WriteLine($"Checking path: {potentialPath}");
                
                if (File.Exists(potentialPath))
                {
                    return potentialPath; // Trả về đường dẫn ảnh nếu tồn tại
                }
            }
            return null; // Trả về null nếu không tìm thấy ảnh
        }

        private void lblQuanLyKhoa_Click(object sender, EventArgs e)
        {
            frmQuanLyKhoa frmquanlykhoa = new frmQuanLyKhoa();
            frmquanlykhoa.ShowDialog();
        }

        private void menuQuanLyKhoa_Click(object sender, EventArgs e)
        {
            lblQuanLyKhoa_Click(sender, e);
        }

        private void menuDangKyChuyenNganh_Click(object sender, EventArgs e)
        {
            frmRegister frmregister = new frmRegister();
            frmregister.ShowDialog();
        }

        private void lblDangKyChuyenNganh_Click(object sender, EventArgs e)
        {
            menuDangKyChuyenNganh_Click(sender, e);
        }
    }
}
