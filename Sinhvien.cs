using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // Thư viện bắt buộc để dùng Validate
using System.ComponentModel.DataAnnotations.Schema;

namespace Quanlysinhvien
{
    public class SinhVien
    {
        [Required(ErrorMessage = "Mã sinh viên không được để trống")]
        public string MaSV { get; set; }

        [Required(ErrorMessage = "Họ tên không được để trống")]
        public string HoTen { get; set; }

        [Required(ErrorMessage = "Email không được để trống")]
        [EmailAddress(ErrorMessage = "Email không đúng định dạng (phải có @)")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [Phone(ErrorMessage = "Số điện thoại không hợp lệ")]
        public string SoDienThoai { get; set; }

        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }

        [Range(0, 10, ErrorMessage = "Điểm phải nằm trong khoảng từ 0 đến 10")]
        public double Diem { get; set; }

        public string TrangThai { get; set; }

        // Quan hệ n-1: Nhiều Sinh viên thuộc về 1 Lớp học
        public string MaLop { get; set; }
        public virtual LopHoc LopHoc { get; set; }

        // Phương thức kiểm tra xem các thuộc tính của đối tượng có hợp lệ hay không
        public List<ValidationResult> IsInValid()
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(this);
            // Quét toàn bộ đối tượng sinh viên hiện tại, nhét các lỗi vi phạm vào list results
            Validator.TryValidateObject(this, context, results, true);
            return results;
        }
        [Table("SinhVienBCSE")]
        public class SinhVienBCSE
        {
            [Key]
            [StringLength(50)]
            public string MaSV { get; set; }

            [Required]
            [StringLength(150)]
            public string HoTen { get; set; }

            [StringLength(10)]
            public string GioiTinh { get; set; }

            public DateTime NgaySinh { get; set; }

            [StringLength(20)]
            public string SoDienThoai { get; set; }

            [StringLength(100)]
            public string Email { get; set; }

            public double Diem { get; set; }

            // Khóa ngoại liên kết với bảng LopHoc
            [StringLength(50)]
            public string MaLop { get; set; }

            [ForeignKey("MaLop")]
            public virtual LopHoc LopHoc { get; set; }
        }
    }
}