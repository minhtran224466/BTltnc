using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Linq;

namespace Quanlysinhvien
{
    public partial class Form1 : Form
    {
        List<LopHoc> danhSachLop = new List<LopHoc>();
        private readonly BindingList<SinhVien> danhSachSV = new();
        private readonly BindingSource sinhVienBindingSource = new();

        public Form1()
        {
            InitializeComponent();
        }

        // Các sự kiện trống cậu lỡ tạo, cứ để nguyên không sao
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void textBox6_TextChanged(object sender, EventArgs e) { }
        private void radioButton2_CheckedChanged(object sender, EventArgs e) { }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Tạo sẵn vài lớp học để test
            danhSachLop.Add(new LopHoc { MaLop = "KTPM01", TenLop = "Kỹ thuật phần mềm 01" });
            danhSachLop.Add(new LopHoc { MaLop = "TTNT01", TenLop = "Trí tuệ nhân tạo 01" });

            // 1. Lấy về danh sách lớp học hiển thị combobox
            cboLop.DataSource = danhSachLop;
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";

            // 2. Lấy về danh sách sinh viên hiển thị data gridview
            sinhVienBindingSource.DataSource = danhSachSV;
            dataGridView1.DataSource = sinhVienBindingSource;

            // 3. Thiết lập cho các button có giá trị enable phù hợp
            button1.Enabled = true;  // Nút Thêm
            button2.Enabled = false; // Nút Sửa
            button3.Enabled = false; // Nút Xóa

            // 4. Con trỏ thiết lập mặc định ở txtMasv 
            txtMasv.Focus();
            // --- THÊM DANH SÁCH TRẠNG THÁI VÀO COMBOBOX ---
            comboBox3.Items.Clear(); // Xóa lỡ có dữ liệu cũ
            comboBox3.Items.Add("Đang học");
            comboBox3.Items.Add("Bảo lưu");
            comboBox3.Items.Add("Đã tốt nghiệp");
            comboBox3.Items.Add("Đình chỉ học");
            comboBox3.Items.Add("Buộc thôi học");

            // Mặc định chọn sẵn dòng chữ "Đang học" (vị trí số 0) khi vừa mở Form
            // Hoặc nếu muốn để trống thì cậu đổi thành = -1 nhé
            comboBox3.SelectedIndex = 0;
            // 1. Ép GroupBox 1 bám sát ra 2 cạnh bên phải và trái
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // 2. Ép GroupBox 2 (nếu có phần tìm kiếm) bám sát 2 cạnh
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // 3. Ép DataGridView bám đủ 4 góc, lấp đầy toàn bộ chỗ trống bên dưới
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        // Hàm phụ dùng để xóa trắng các ô nhập liệu khi mã chưa tồn tại
        private void XoaTrongThongTin()
        {
            txtHoten.Clear(); // Xóa Họ tên
            txtEmail.Clear(); // Xóa Email
            txtSdt.Clear();   // Xóa Điện thoại
            dateTimePicker1.Value = DateTime.Now; // Reset ngày sinh
            radioButton1.Checked = true; // Mặc định chọn Nam
            numericUpDown1.Value = 0; // Reset điểm
            comboBox3.SelectedIndex = -1; // Reset trạng thái
        }

        // Sự kiện khi nhập xong mã sinh viên (txtMasv)
        private void textBox1_Leave(object sender, EventArgs e)
        {
            string ma = txtMasv.Text.Trim();
            if (string.IsNullOrEmpty(ma)) return;

            var sv = danhSachSV.FirstOrDefault(s => s.MaSV == ma);

            if (sv != null)
            {
                // TỒN TẠI: Hiển thị thông tin
                txtHoten.Text = sv.HoTen;
                dateTimePicker1.Value = sv.NgaySinh;
                if (sv.GioiTinh == "Nam") radioButton1.Checked = true; else radioButton2.Checked = true;
                txtEmail.Text = sv.Email;
                txtSdt.Text = sv.SoDienThoai;
                cboLop.SelectedValue = sv.MaLop;
                numericUpDown1.Value = (decimal)sv.Diem;
                comboBox3.Text = sv.TrangThai;

                // Khóa Thêm, Mở Sửa/Xóa
                button1.Enabled = false;
                button2.Enabled = true;
                button3.Enabled = true;
            }
            else
            {
                // CHƯA TỒN TẠI: Xóa trắng thông tin
                XoaTrongThongTin();

                // Mở Thêm, Khóa Sửa/Xóa
                button1.Enabled = true;
                button2.Enabled = false;
                button3.Enabled = false;
            }
        }

        // NÚT THÊM (button1)
        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            SinhVien sv = new SinhVien
            {
                MaSV = txtMasv.Text.Trim(),
                HoTen = txtHoten.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                SoDienThoai = txtSdt.Text.Trim(),
                NgaySinh = dateTimePicker1.Value,
                GioiTinh = radioButton1.Checked ? "Nam" : "Nữ",
                MaLop = cboLop.SelectedValue?.ToString(),
                Diem = (double)numericUpDown1.Value,
                TrangThai = comboBox3.Text
            };

            var errors = sv.IsInValid();

            if (errors.Count > 0)
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(txtMasv, "Có lỗi nhập liệu, vui lòng rà soát lại!");
            }
            else
            {
                danhSachSV.Add(sv);
                sinhVienBindingSource.DataSource = danhSachSV;
                dataGridView1.DataSource = sinhVienBindingSource;
                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo");
            }
        }

        // NÚT SỬA (button2)
        private void button2_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string ma = txtMasv.Text.Trim();
            var svCu = danhSachSV.FirstOrDefault(s => s.MaSV == ma);

            if (svCu != null)
            {
                svCu.HoTen = txtHoten.Text.Trim();
                svCu.Email = txtEmail.Text.Trim();
                svCu.SoDienThoai = txtSdt.Text.Trim();
                svCu.NgaySinh = dateTimePicker1.Value;
                svCu.GioiTinh = radioButton1.Checked ? "Nam" : "Nữ";
                svCu.MaLop = cboLop.SelectedValue?.ToString();
                svCu.Diem = (double)numericUpDown1.Value;
                svCu.TrangThai = comboBox3.Text;

                var errors = svCu.IsInValid();
                if (errors.Count > 0)
                {
                    MessageBox.Show("Thông tin cập nhật không hợp lệ!", "Lỗi");
                }
                else
                {
                    sinhVienBindingSource.DataSource = danhSachSV;
                    dataGridView1.DataSource = sinhVienBindingSource;
                    sinhVienBindingSource.ResetItem(danhSachSV.IndexOf(svCu));
                    MessageBox.Show("Cập nhật thành công!", "Thông báo");
                }
            }
        }

        // NÚT XÓA (button3)
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult hoiChot = MessageBox.Show("Cậu có chắc chắn muốn xóa sinh viên này không?", "Cảnh báo nguy hiểm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (hoiChot == DialogResult.Yes)
            {
                string ma = txtMasv.Text.Trim();
                var sv = danhSachSV.FirstOrDefault(s => s.MaSV == ma);
                if (sv != null)
                {
                    danhSachSV.Remove(sv);
                    sinhVienBindingSource.DataSource = danhSachSV;
                    dataGridView1.DataSource = sinhVienBindingSource;

                    XoaTrongThongTin();
                    txtMasv.Clear();
                    button1.Enabled = true;
                    button2.Enabled = false;
                    button3.Enabled = false;
                }
            }
        }

        // NÚT LÀM MỚI
        private void button4_Click(object sender, EventArgs e)
        {
            // 1. Xóa trống các thuộc tính trên form
            XoaTrongThongTin(); // Gọi lại hàm phụ đã viết sẵn
            txtMasv.Clear();    // Xóa nốt ô Mã sinh viên

            // 2. Enable button Nhập, Disable button sửa, xóa
            button1.Enabled = true;  // Bật nút Thêm (Nhập)
            button2.Enabled = false; // Tắt nút Sửa
            button3.Enabled = false; // Tắt nút Xóa

            // 3. Chuyển tiêu điểm về điều khiển txtMaSV
            txtMasv.Focus();
        }
        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem ComboBox đã có giá trị chọn chưa
            if (cboLop.SelectedValue != null)
            {
                string maLopChon = cboLop.SelectedValue.ToString();

                // Lọc danh sách sinh viên thuộc mã lớp đang chọn
                var svTheoLop = danhSachSV.Where(s => s.MaLop == maLopChon).ToList();

                // Đưa danh sách đã lọc lên BindingSource để hiển thị ra DataGridView
                sinhVienBindingSource.DataSource = new BindingList<SinhVien>(svTheoLop);
                dataGridView1.DataSource = sinhVienBindingSource;
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Đảm bảo người dùng không bấm nhầm vào thanh tiêu đề (RowIndex = -1)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Lấy Mã SV từ dòng được chọn gán vào ô txtMasv
                if (row.Cells["MaSV"].Value != null)
                {
                    txtMasv.Text = row.Cells["MaSV"].Value.ToString();

                    // Kích hoạt luôn logic kiểm tra như khi người dùng gõ xong mã và rời chuột (Leave)
                    EventArgs ev = new EventArgs();
                    textBox1_Leave(txtMasv, ev);
                }
            }
        }
    }
}