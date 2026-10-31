using System;
using System.Collections.Generic;
using System.Data;
using Quanlysinhvien; // Đảm bảo khớp với namespace chứa class SinhVien của cậu

namespace QuanLySinhVien.Data.DAL
{
    public class SinhVienDAL
    {
        DataHelper dataHelper = new DataHelper();

        public SinhVienDAL() { }

        public List<SinhVien> GetAllSinhVien()
        {
            List<SinhVien> sinhViens = new List<SinhVien>();
            try
            {
                DataTable dt = dataHelper.GetDataTable("Select * from SinhVien");
                foreach (DataRow dr in dt.Rows)
                {
                    SinhVien sv = new SinhVien();
                    sv.MaSV = dr["MaSV"]?.ToString() ?? string.Empty;
                    sv.HoTen = dr["HoTen"]?.ToString() ?? string.Empty;
                    sv.GioiTinh = dr["GioiTinh"]?.ToString() ?? string.Empty;
                    sv.NgaySinh = dr["NgaySinh"] != DBNull.Value && dr["NgaySinh"] != null ? Convert.ToDateTime(dr["NgaySinh"]) : DateTime.Now;
                    sv.SoDienThoai = dr["SoDienThoai"]?.ToString() ?? string.Empty;
                    sv.MaLop = dr["MaLop"]?.ToString() ?? string.Empty;
                    sv.Diem = dr["Diem"] != DBNull.Value && dr["Diem"] != null ? double.Parse(dr["Diem"].ToString() ?? "0") : 0;
                    sv.Email = dr["Email"]?.ToString() ?? string.Empty;
                    sinhViens.Add(sv);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi DAL khi lấy danh sách sinh viên: " + ex.Message);
            }
            return sinhViens;
        }

        public SinhVien GetSinhVienByMaSV(string maSV)
        {
            SinhVien sv = null;
            try
            {
                DataTable dt = dataHelper.GetDataTable($"Select * from SinhVien WHERE MaSV = '{maSV}'");
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    sv = new SinhVien();
                    sv.MaSV = dr["MaSV"]?.ToString() ?? string.Empty;
                    sv.HoTen = dr["HoTen"]?.ToString() ?? string.Empty;
                    sv.GioiTinh = dr["GioiTinh"]?.ToString() ?? string.Empty;
                    sv.NgaySinh = dr["NgaySinh"] != DBNull.Value && dr["NgaySinh"] != null ? Convert.ToDateTime(dr["NgaySinh"]) : DateTime.Now;
                    sv.SoDienThoai = dr["SoDienThoai"]?.ToString() ?? string.Empty;
                    sv.MaLop = dr["MaLop"]?.ToString() ?? string.Empty;
                    sv.Diem = dr["Diem"] != DBNull.Value && dr["Diem"] != null ? double.Parse(dr["Diem"].ToString() ?? "0") : 0;
                    sv.Email = dr["Email"]?.ToString() ?? string.Empty;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi DAL khi tìm sinh viên: " + ex.Message);
            }
            return sv;
        }

        public List<SinhVien> GetSinhViensByMaLop(string maLop)
        {
            List<SinhVien> lv = new List<SinhVien>();
            try
            {
                DataTable dt = dataHelper.GetDataTable($"Select * from SinhVien where Malop='{maLop}'");
                foreach (DataRow r in dt.Rows)
                {
                    SinhVien sv = new SinhVien();
                    sv.MaSV = r["MaSV"]?.ToString() ?? string.Empty;
                    sv.HoTen = r["HoTen"]?.ToString() ?? string.Empty;
                    sv.GioiTinh = r["GioiTinh"]?.ToString() ?? string.Empty;
                    sv.NgaySinh = r["NgaySinh"] != DBNull.Value && r["NgaySinh"] != null ? Convert.ToDateTime(r["NgaySinh"]) : DateTime.Now;
                    sv.SoDienThoai = r["SoDienThoai"]?.ToString() ?? string.Empty;
                    sv.MaLop = r["MaLop"]?.ToString() ?? string.Empty;
                    sv.Diem = r["Diem"] != DBNull.Value && r["Diem"] != null ? double.Parse(r["Diem"].ToString() ?? "0") : 0;
                    sv.Email = r["Email"]?.ToString() ?? string.Empty;
                    lv.Add(sv);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi DAL khi lọc sinh viên theo lớp: " + ex.Message);
            }
            return lv;
        }

        public void AddSinhVien(SinhVien sv)
        {
            try
            {
                string ngaySinhStr = sv.NgaySinh.ToString("yyyy-MM-dd");
                string sql = $"insert into SinhVien (MaSV, Malop, Hoten, GioiTinh, NgaySinh, Diem, SoDienThoai, Email) " +
                             $"values('{sv.MaSV}', '{sv.MaLop}', N'{sv.HoTen}', N'{sv.GioiTinh}', '{ngaySinhStr}', " +
                             $"{sv.Diem}, '{sv.SoDienThoai}', '{sv.Email}')";
                dataHelper.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi DAL khi thêm sinh viên: " + ex.Message);
            }
        }

        public void UpdateSinhVien(SinhVien sv)
        {
            try
            {
                string ngaySinhStr = sv.NgaySinh.ToString("yyyy-MM-dd");
                string sql = $"UPDATE SinhVien SET " +
                             $"Hoten = N'{sv.HoTen}', " +
                             $"Malop = '{sv.MaLop}', " +
                             $"GioiTinh = N'{sv.GioiTinh}', " +
                             $"NgaySinh = '{ngaySinhStr}', " +
                             $"Diem = {sv.Diem}, " +
                             $"SoDienThoai = '{sv.SoDienThoai}', " +
                             $"Email = '{sv.Email}' " +
                             $"WHERE MaSV = '{sv.MaSV}'";
                dataHelper.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi DAL khi cập nhật sinh viên: " + ex.Message);
            }
        }

        public void DeleteSinhVien(string maSV)
        {
            try
            {
                string sql = $"DELETE FROM SinhVien WHERE MaSV = '{maSV}'";
                dataHelper.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi DAL khi xóa sinh viên: " + ex.Message);
            }
        }
    }
}