namespace Quanlysinhvien
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtMasv = new TextBox();
            txtSdt = new TextBox();
            txtEmail = new TextBox();
            txtHoten = new TextBox();
            cboLop = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            errorProvider1 = new ErrorProvider(components);
            panel1 = new Panel();
            numericUpDown1 = new NumericUpDown();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            comboBox3 = new ComboBox();
            button6 = new Button();
            groupBox1 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button5 = new Button();
            label11 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtMasv
            // 
            txtMasv.Location = new Point(86, 22);
            txtMasv.Name = "txtMasv";
            txtMasv.Size = new Size(162, 23);
            txtMasv.TabIndex = 0;
            txtMasv.TextChanged += textBox1_Leave;
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(341, 92);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(197, 23);
            txtSdt.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(86, 94);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(162, 23);
            txtEmail.TabIndex = 6;
            txtEmail.TextChanged += textBox3_TextChanged;
            // 
            // txtHoten
            // 
            txtHoten.Location = new Point(341, 23);
            txtHoten.Name = "txtHoten";
            txtHoten.Size = new Size(197, 23);
            txtHoten.TabIndex = 1;
            // 
            // cboLop
            // 
            cboLop.FormattingEnabled = true;
            cboLop.Location = new Point(609, 23);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(121, 23);
            cboLop.TabIndex = 2;
            cboLop.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(86, 55);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(162, 23);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(51, 19);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nam";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(103, 4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(41, 19);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Nữ";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 259);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(803, 228);
            dataGridView1.TabIndex = 18;
            // 
            // button1
            // 
            button1.Location = new Point(444, 128);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(525, 128);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(606, 128);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 11;
            button3.Text = "Xoá";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(687, 128);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 12;
            button4.Text = "Làm mới";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(radioButton2);
            panel1.Location = new Point(341, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(197, 31);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(610, 59);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 5;
            numericUpDown1.Tag = "";
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(110, 25);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(232, 23);
            textBox5.TabIndex = 13;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(444, 20);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 15;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(610, 89);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 14;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // button6
            // 
            button6.Location = new Point(683, 20);
            button6.Name = "button6";
            button6.Size = new Size(101, 23);
            button6.TabIndex = 17;
            button6.Text = "Hiển thị tất cả";
            button6.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtMasv);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtHoten);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtSdt);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(cboLop);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(803, 162);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sinh viên";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(545, 95);
            label9.Name = "label9";
            label9.Size = new Size(59, 15);
            label9.TabIndex = 26;
            label9.Text = "Trạng thái";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(555, 61);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 25;
            label8.Text = "Điểm";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(553, 25);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 24;
            label7.Text = "Lớp học";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(273, 97);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 23;
            label6.Text = "Điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(279, 61);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 22;
            label5.Text = "Giới tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(273, 25);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 21;
            label4.Text = "Họ và tên";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 59);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 20;
            label3.Text = "Ngày sinh";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 97);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 19;
            label2.Text = "email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 26);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 18;
            label1.Text = "Mã sinh viên";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(button6);
            groupBox2.Location = new Point(12, 180);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(803, 65);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // button5
            // 
            button5.Location = new Point(580, 21);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 28;
            button5.Text = "Tìm kiếm";
            button5.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(40, 28);
            label11.Name = "label11";
            label11.Size = new Size(49, 15);
            label11.TabIndex = 27;
            label11.Text = "Từ khoá";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(376, 25);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 26;
            label10.Text = "Điểm  từ";
            label10.Click += label10_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 499);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Quanlysinhvien";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtHoten;
        private TextBox txtEmail;
        private TextBox txtSdt;
        private ComboBox cboLop;
        private DateTimePicker dateTimePicker1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ErrorProvider errorProvider1;
        private Panel panel1;
        private NumericUpDown numericUpDown1;
        private Button button6;
        private ComboBox comboBox3;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox txtMasv;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label6;
        private Label label5;
        private GroupBox groupBox2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label10;
        private Label label11;
        private Button button5;
    }
}
