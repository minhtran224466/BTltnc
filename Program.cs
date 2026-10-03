using System;
using System.Collections.Generic;
using System.Linq;

namespace oop.cs
{
    public class Student
    {
        public string StdID { get; set; }
        public string Name { get; set; }
        public Student(string masv, string hoten)
        {
            StdID = masv;
            Name = hoten;
        }
    }

    public class StudentDAO
    {
        private List<Student> Students = new List<Student>();

        static void Main()
        {
            var dao = new StudentDAO();
            dao.Students = new List<Student>()
            {
                new Student("SV001", "An"),
                new Student("SV002", "Binh"),
                new Student("SV001", "An")
            };
            dao.Add(new Student("SV004", "Cuong"));
        }

        public void Add(Student student)
        {
            Students.Add(student);
        }

        public void Edit(Student student)
        {
            var existingStudent = Students.FirstOrDefault(s => s.StdID == student.StdID);

            if (existingStudent != null)
            {
                existingStudent.Name = student.Name;
                Console.WriteLine($"tim thay sinh vien thanh cong {student.StdID}!");
            }
            else
            {
                Console.WriteLine($"khong tim thay sinh vien {student.StdID} de sua.");
            }
        }
        static SinhVien GetById(List<SinhVien> danhSach, string id)
        {
            return danhSach.FirstOrDefault(sv => sv.MaSV.Equals(id, StringComparison.OrdinalIgnoreCase));
        }
        static List<SinhVien> GetByName(List<SinhVien> danhSach, string name)
        {
            return danhSach.Where(sv => sv.HoTen.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        static bool Delete(List<SinhVien> danhSach, string id)
        {
            var sv = GetById(danhSach, id);
            if (sv != null)
            {
                danhSach.Remove(sv);
                return true;
            }
            return false;
        }

        static List<SinhVien> GetAlls(List<SinhVien> danhSach)
        {
            return danhSach ?? new List<SinhVien>();
        }

        static void RunSinhVienDemo()
        {
            List<SinhVien> danhSachSV = new List<SinhVien>
        {
            new SinhVien("SV001", "Tran Hieu Minh", 22),
            new SinhVien("SV002", "Nguyen Minh Duc", 22),
            new SinhVien("SV003", "Bui Khanh Linh", 21)
        };
            Console.WriteLine("=== 1. TEST GET ALLS ===");
            var tatCa = GetAlls(danhSachSV);
            foreach (var sv in tatCa)
            {
                Console.WriteLine($"Ma: {sv.MaSV} | Ho ten: {sv.HoTen}");
            }
            Console.WriteLine("\n=== 2. TEST GET BY ID (SV002) ===");
            var svById = GetById(danhSachSV, "SV002");
            if (svById != null)
            {
                Console.WriteLine($"Da Tim Thay: {svById.HoTen}, {svById.Tuoi} tuoi");
            }
            Console.WriteLine("\n=== 3. TEST GET BY NAME ('Minh') ===");
            var svByName = GetByName(danhSachSV, "Minh");
            foreach (var sv in svByName)
            {
                Console.WriteLine($"Ket qua khop: {sv.MaSV} - {sv.HoTen}");
            }
            Console.WriteLine("\n=== 4. TEST DELETE (Xóa SV001) ===");
            bool xoaThanhCong = Delete(danhSachSV, "SV001");
            if (xoaThanhCong)
            {
                Console.WriteLine("Xoa thanh cong! Danh sach sau khi xoa:");
                foreach (var sv in GetAlls(danhSachSV))
                {
                    Console.WriteLine($"Ma: {sv.MaSV} | Ho ten: {sv.HoTen}");
                }
            }
            else
            {
                Console.WriteLine("Khong tim thay sinh vien de xoa!");
            }
        }
    }

    public class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public int Tuoi { get; set; }

        public SinhVien(string maSV, string hoTen, int tuoi)
        {
            MaSV = maSV;
            HoTen = hoTen;
            Tuoi = tuoi;
        }
    }
}


