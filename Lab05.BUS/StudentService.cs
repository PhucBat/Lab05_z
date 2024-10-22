using Lab05.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05.BUS
{
    public class StudentService
    {
        // Cập nhật đường dẫn lưu ảnh
        private readonly string imagesDirectory = @"C:\Users\DIMON\source\repos\Images"; // Unified image directory

        public List<Student> GetAll()
        {
            StudentModel Context = new StudentModel();
            return Context.Students.ToList();
        }

        public List<Student> GetALLHasNoMajor()
        {
            StudentModel context = new StudentModel();
            return context.Students.Where(p => p.MajorID == null).ToList();
        }

        public List<Student> GetALLHasNoMajor(int facultyID)
        {
            StudentModel context = new StudentModel();
            return context.Students.Where(p => p.MajorID == null && p.FacultyID == facultyID).ToList();
        }

        public Student FindById(String studentId)
        {
            StudentModel context = new StudentModel();
            return context.Students.FirstOrDefault(p => p.StudentID == studentId);
        }

        public void InsertUpdate(Student s)
        {
            StudentModel context = new StudentModel();
            context.Students.AddOrUpdate(s);
            context.SaveChanges();
        }

        public void SaveStudentAvatar(string studentID, string imagePath)
        {
            if (string.IsNullOrEmpty(studentID))
            {
                throw new ArgumentException("Student ID không được rỗng.");
            }

            if (string.IsNullOrEmpty(imagePath))
            {
                throw new ArgumentException("Đường dẫn hình ảnh không được rỗng.");
            }

            // In ra đường dẫn để kiểm tra
            Console.WriteLine($"Đường dẫn hình ảnh: {imagePath}");

            if (!File.Exists(imagePath))
            {
                // Thêm đường dẫn vào thông báo lỗi
                throw new FileNotFoundException($"Không tìm thấy tệp nguồn. Save. Đường dẫn: {imagePath}", imagePath);
            }

            // Ensure the new file name includes the file extension
            string fileExtension = Path.GetExtension(imagePath);
            if (string.IsNullOrEmpty(fileExtension))
            {
                throw new ArgumentException("Đường dẫn hình ảnh không hợp lệ.");
            }

            // Tạo tên tệp mới với phần mở rộng
            string newFileName = $"{studentID}{fileExtension}"; // Lưu ảnh với định dạng {studentID}.{typeFile}
            string targetPath = Path.Combine(imagesDirectory, newFileName); // Đường dẫn lưu ảnh

            Directory.CreateDirectory(imagesDirectory); // Tạo thư mục nếu chưa tồn tại

            if (!HasWriteAccessToFolder(imagesDirectory))
            {
                throw new UnauthorizedAccessException("Thư mục không có quyền ghi.");
            }

            CopyFileWithRetry(imagePath, targetPath, 5); // Sao chép tệp vào thư mục


        }

        private bool HasWriteAccessToFolder(string folderPath)
        {
            try
            {
                // Tạo một tệp tạm thời để kiểm tra quyền ghi
                string tempFile = Path.Combine(folderPath, Path.GetRandomFileName());
                using (FileStream fs = File.Create(tempFile, 1, FileOptions.DeleteOnClose))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private void CopyFileWithRetry(string sourcePath, string destinationPath, int maxAttempts)
        {
            bool fileCopied = false;
            int attempts = 0;

            while (!fileCopied && attempts < maxAttempts) // Thử tối đa maxAttempts lần
            {
                try
                {
                    File.Copy(sourcePath, destinationPath, true); // Sao chép tệp
                    fileCopied = true; // Nếu sao chép thành công, thoát khỏi vòng lặp
                }
                catch (IOException ex)
                {
                    attempts++;
                    Console.WriteLine($"Lỗi khi sao chép tệp: {ex.Message}. Thử lại lần {attempts}.");
                    System.Threading.Thread.Sleep(attempts * 1000); // Tăng thời gian chờ theo số lần thử
                }
            }

            if (!fileCopied)
            {
                throw new IOException($"Không thể sao chép tệp từ đường dẫn: {sourcePath} đến: {destinationPath} sau {attempts} lần thử.");
            }
        }

        public void DeleteStudent(string studentId)
        {
            if (string.IsNullOrEmpty(studentId))
            {
                throw new ArgumentException("Student ID không được rỗng.");
            }

            StudentModel context = new StudentModel();
            var student = context.Students.FirstOrDefault(p => p.StudentID == studentId);

            if (student == null)
            {
                throw new InvalidOperationException("Không tìm thấy sinh viên với ID đã cho.");
            }

            context.Students.Remove(student);
            context.SaveChanges();
        }

        public void UpdateStudentAvatar(string studentID, string imagePath)
        {
            // Kiểm tra nếu studentID bị rỗng hoặc null
            if (string.IsNullOrEmpty(studentID))
            {
                throw new ArgumentException("Student ID không được rỗng.");
            }

            // Kiểm tra tệp nguồn có tồn tại không
            if (!File.Exists(imagePath))
            {
                throw new FileNotFoundException("Không tìm thấy tệp nguồn Update.", imagePath);
            }

            // Lấy phần mở rộng tệp của hình ảnh
            string fileExtension = Path.GetExtension(imagePath);
            if (string.IsNullOrEmpty(fileExtension))
            {
                throw new ArgumentException("Đường dẫn hình ảnh không hợp lệ.");
            }

            // Tạo tên tệp mới với studentID và phần mở rộng tệp
            string newFileName = $"{studentID}{fileExtension}"; // Lưu ảnh với định dạng {studentID}.{typeFile}
            string targetPath = Path.Combine(imagesDirectory, newFileName); // Đường dẫn lưu ảnh

            // Sử dụng File.Copy để sao chép tệp
            try
            {
                File.Copy(imagePath, targetPath, true); // Overwrite if exists
            }
            catch (Exception ex)
            {
                throw new IOException($"Không thể sao chép tệp từ {imagePath} đến {targetPath}: {ex.Message}");
            }

            // Cập nhật thông tin avatar trong cơ sở dữ liệu
            StudentModel context = new StudentModel();
            var student = context.Students.FirstOrDefault(p => p.StudentID == studentID);
            if (student != null)
            {
                student.Avatar = newFileName; // Cập nhật tên tệp avatar
                context.SaveChanges(); // Lưu thay đổi
            }
            else
            {
                throw new InvalidOperationException("Không tìm thấy sinh viên với ID đã cho.");
            }
        }

        // New method to get avatar path
        public string GetStudentAvatarPath(string studentID)
        {
            return Path.Combine(imagesDirectory, $"{studentID}.jpg"); // Hoặc sử dụng phần mở rộng phù hợp
        }

        public List<Student> GetAllByFaculty(int facultyID)
        {
            StudentModel context = new StudentModel();
            return context.Students.Where(p => p.FacultyID == facultyID).ToList();
        }

    }
}
