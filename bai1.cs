using System;
using System.Collections.Generic;

namespace QuanLyHinhHoc
{
    // 1. Khai báo Interface IHinh
    public interface IHinh
    {
        double GetDienTich();
        double GetChuVi();
        void Nhap();
        void HienThi();
    }

    // 2. Lớp Hình Tròn
    public class HinhTron : IHinh
    {
        private double banKinh;

        // Thuộc tính có kiểm tra tính hợp lệ
        public double BanKinh
        {
            get { return banKinh; }
            set
            {
                if (value <= 0) throw new ArgumentException("Bán kính phải lớn hơn 0!");
                banKinh = value;
            }
        }

        public HinhTron() { }

        public HinhTron(double r)
        {
            BanKinh = r;
        }

        public double GetChuVi() => 2 * Math.PI * BanKinh;

        public double GetDienTich() => Math.PI * BanKinh * BanKinh;

        public void Nhap()
        {
            Console.WriteLine("--- NHẬP HÌNH TRÒN ---");
            while (true)
            {
                try
                {
                    Console.Write("Nhập bán kính: ");
                    BanKinh = double.Parse(Console.ReadLine());
                    break; // Nhập đúng thì thoát vòng lặp
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi: {ex.Message}. Vui lòng nhập lại số dương!");
                }
            }
        }

        public void HienThi()
        {
            Console.WriteLine($"[Hình Tròn] Bán kính = {BanKinh} | Chu vi = {GetChuVi():F2} | Diện tích = {GetDienTich():F2}");
        }
    }

    // 3. Lớp Hình Chữ Nhật
    public class HinhChuNhat : IHinh
    {
        private double chieuDai, chieuRong;

        public double ChieuDai
        {
            get { return chieuDai; }
            set { if (value <= 0) throw new ArgumentException("Chiều dài phải > 0"); chieuDai = value; }
        }

        public double ChieuRong
        {
            get { return chieuRong; }
            set { if (value <= 0) throw new ArgumentException("Chiều rộng phải > 0"); chieuRong = value; }
        }

        public HinhChuNhat() { }

        public HinhChuNhat(double dai, double rong)
        {
            ChieuDai = dai;
            ChieuRong = rong;
        }

        public double GetChuVi() => (ChieuDai + ChieuRong) * 2;

        public double GetDienTich() => ChieuDai * ChieuRong;

        public void Nhap()
        {
            Console.WriteLine("--- NHẬP HÌNH CHỮ NHẬT ---");
            while (true)
            {
                try
                {
                    Console.Write("Nhập chiều dài: ");
                    ChieuDai = double.Parse(Console.ReadLine());
                    Console.Write("Nhập chiều rộng: ");
                    ChieuRong = double.Parse(Console.ReadLine());

                    if (ChieuDai < ChieuRong)
                        Console.WriteLine("Cảnh báo: Chiều dài đang nhỏ hơn chiều rộng, nhưng vẫn tính tiếp!");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi: {ex.Message}. Vui lòng nhập lại số dương!");
                }
            }
        }

        public void HienThi()
        {
            Console.WriteLine($"[Hình Chữ Nhật] Dài = {ChieuDai}, Rộng = {ChieuRong} | Chu vi = {GetChuVi():F2} | Diện tích = {GetDienTich():F2}");
        }
    }

    // 4. Lớp Hình Tam Giác
    public class HinhTamGiac : IHinh
    {
        public double CanhA { get; private set; }
        public double CanhB { get; private set; }
        public double CanhC { get; private set; }

        public HinhTamGiac() { }

        public HinhTamGiac(double a, double b, double c)
        {
            if (!IsTamGiac(a, b, c))
                throw new ArgumentException("3 cạnh này không tạo thành tam giác hợp lệ!");
            CanhA = a; CanhB = b; CanhC = c;
        }

        // Phương thức kiểm tra điều kiện hình tam giác (Tổng 2 cạnh > cạnh còn lại)
        public bool IsTamGiac(double a, double b, double c)
        {
            return (a > 0 && b > 0 && c > 0) && (a + b > c) && (a + c > b) && (b + c > a);
        }

        public double GetChuVi() => CanhA + CanhB + CanhC;

        public double GetDienTich()
        {
            // Sử dụng công thức Heron
            double p = GetChuVi() / 2; // Nửa chu vi
            return Math.Sqrt(p * (p - CanhA) * (p - CanhB) * (p - CanhC));
        }

        public void Nhap()
        {
            Console.WriteLine("--- NHẬP HÌNH TAM GIÁC ---");
            while (true)
            {
                try
                {
                    Console.Write("Nhập cạnh a: "); double a = double.Parse(Console.ReadLine());
                    Console.Write("Nhập cạnh b: "); double b = double.Parse(Console.ReadLine());
                    Console.Write("Nhập cạnh c: "); double c = double.Parse(Console.ReadLine());

                    if (IsTamGiac(a, b, c))
                    {
                        CanhA = a; CanhB = b; CanhC = c;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Lỗi: 3 cạnh không tạo thành một tam giác! Vui lòng nhập lại.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lỗi: Vui lòng nhập số hợp lệ!");
                }
            }
        }

        public void HienThi()
        {
            Console.WriteLine($"[Hình Tam Giác] a = {CanhA}, b = {CanhB}, c = {CanhC} | Chu vi = {GetChuVi():F2} | Diện tích = {GetDienTich():F2}");
        }
    }

    // 5. Chương trình chính
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Hỗ trợ hiển thị tiếng Việt

            // TÍNH ĐA HÌNH THÁI (Polymorphism):
            // Khai báo một List kiểu IHinh nhưng có thể chứa mọi class con thực thi nó
            List<IHinh> danhSachHinh = new List<IHinh>();

            // Khởi tạo cứng bằng Constructor
            Console.WriteLine("=> KHỞI TẠO DỮ LIỆU SẴN:");
            IHinh hinhTron = new HinhTron(5.5);
            IHinh hinhChuNhat = new HinhChuNhat(4, 3);

            danhSachHinh.Add(hinhTron);
            danhSachHinh.Add(hinhChuNhat);

            // Thử nhập từ bàn phím qua phương thức Nhap()
            Console.WriteLine("\n=> NHẬP TỪ BÀN PHÍM:");
            IHinh tamGiac = new HinhTamGiac();
            tamGiac.Nhap(); // Gọi phương thức Nhap để Validate người dùng
            danhSachHinh.Add(tamGiac);

            // HienThi danh sách - Trình diễn Đa Hình (Tự động biết gọi hàm HienThi của class nào)
            Console.WriteLine("\n================ KẾT QUẢ DANH SÁCH HÌNH ================");
            foreach (var hinh in danhSachHinh)
            {
                hinh.HienThi();
            }

            Console.ReadLine();
        }
    }
}
