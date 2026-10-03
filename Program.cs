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
        static Student GetById(List<Student> danhSach, string id)
        {
            return danhSach.FirstOrDefault(sv => sv.StdID.Equals(id, StringComparison.OrdinalIgnoreCase));
        }

        static List<Student> GetByName(List<Student> danhSach, string name)
        {
            return danhSach.Where(sv => sv.Name != null && sv.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        static bool Delete(List<Student> danhSach, string id)
        {
            var sv = GetById(danhSach, id);
            if (sv != null)
            {
                danhSach.Remove(sv);
                return true;
            }
            return false;
        }

        static List<Student> GetAlls(List<Student> danhSach)
        {
            return danhSach ?? new List<Student>();
        }
    }
}




