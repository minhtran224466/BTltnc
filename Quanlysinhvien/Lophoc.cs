using Quanlysinhvien;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // Thư viện bắt buộc để dùng Validate

namespace Quanlysinhvien
{
    public class LopHoc
    {
        [Required(ErrorMessage = "Mã lớp không được để trống")]
        public string MaLop { get; set; }

        [Required(ErrorMessage = "Tên lớp không được để trống")]
        public string TenLop { get; set; }

        // Quan hệ 1-n: 1 Lớp học chứa nhiều Sinh viên
        public virtual ICollection<SinhVien> DanhSachSinhVien { get; set; } = new List<SinhVien>();

        // Phương thức kiểm tra hợp lệ cho Lớp học
        public List<ValidationResult> IsInValid()
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(this);
            Validator.TryValidateObject(this, context, results, true); // true = kiểm tra tất cả thuộc tính
            return results;
        }
    }
}
