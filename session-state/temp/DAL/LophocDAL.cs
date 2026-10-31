using System;
using System.Collections.Generic;
using System.Data;
using Quanlysinhvien; // Đảm bảo khớp với namespace chứa class LopHoc của cậu

namespace QuanLySinhVien.Data.DAL
{
    public class LopHocDAL
    {
        DataHelper dataHelper = new DataHelper();

        public List<LopHoc> GetAllLopHoc()
        {
            List<LopHoc> list = new List<LopHoc>();
            try
            {
                DataTable dt = dataHelper.GetDataTable("SELECT * FROM LopHoc");
                foreach (DataRow dr in dt.Rows)
                {
                    LopHoc lop = new LopHoc();
                    lop.MaLop = dr["MaLop"]?.ToString() ?? string.Empty;
                    lop.TenLop = dr["TenLop"]?.ToString() ?? string.Empty;
                    list.Add(lop);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi DAL khi lấy danh sách lớp học: " + ex.Message);
            }
            return list;
        }
    }
}