using Quanlysinhvien;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // Thư viện bắt buộc để dùng Validate
using System.ComponentModel.DataAnnotations.Schema;
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
        [Table("LopHocBCSE")]
        public class LopHocBCSE
        {
            [Key]
            [StringLength(50)]
            public string MaLop { get; set; }

            [Required]
            [StringLength(100)]
            public string TenLop { get; set; }

            // Quan hệ 1 - Nhiều: Một lớp có nhiều sinh viên
            public virtual ICollection<SinhVien> SinhViens { get; set; }
        }
    }
}
