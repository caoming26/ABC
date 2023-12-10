namespace ABC
{
    partial class form_xuatHuy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            button1 = new Button();
            btn_xuatBanhMan = new Button();
            btn_xoaPhieu = new Button();
            btn_themPhieu = new Button();
            txt_ghiChu = new TextBox();
            txt_tongSoLuong = new TextBox();
            txt_tongTienHang = new TextBox();
            lb_ghiChu = new Label();
            lb_tongSoLuong = new Label();
            lb_tongTienHang = new Label();
            column_ma = new DataGridViewTextBoxColumn();
            column_tenBanh = new DataGridViewTextBoxColumn();
            column_tong = new DataGridViewTextBoxColumn();
            column_soLuong = new DataGridViewTextBoxColumn();
            column_donVi = new DataGridViewTextBoxColumn();
            btn_in = new Button();
            column_gia = new DataGridViewTextBoxColumn();
            column_xoa = new DataGridViewButtonColumn();
            dataGridView = new DataGridView();
            column_thanhTien = new DataGridViewTextBoxColumn();
            btn_after = new Button();
            btn_before = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            txt_maPhieu = new TextBox();
            pictureBox3 = new PictureBox();
            lb_xuatCho = new Label();
            pictureBox2 = new PictureBox();
            lb_ngay = new Label();
            pictureBox1 = new PictureBox();
            btn_luuGhiChu = new Button();
            lb_maPhieu = new Label();
            lb_PhieuXuatHuy = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ForeColor = Color.FromArgb(226, 199, 153);
            button1.Location = new Point(725, 5);
            button1.Name = "button1";
            button1.Size = new Size(82, 29);
            button1.TabIndex = 50;
            button1.Text = "Đổi Ngày";
            button1.UseVisualStyleBackColor = true;
            // 
            // btn_xuatBanhMan
            // 
            btn_xuatBanhMan.Location = new Point(484, 388);
            btn_xuatBanhMan.Margin = new Padding(2);
            btn_xuatBanhMan.Name = "btn_xuatBanhMan";
            btn_xuatBanhMan.Size = new Size(74, 56);
            btn_xuatBanhMan.TabIndex = 48;
            btn_xuatBanhMan.Text = "Xuất Hủy Bánh Mặn";
            btn_xuatBanhMan.UseVisualStyleBackColor = true;
            // 
            // btn_xoaPhieu
            // 
            btn_xoaPhieu.Location = new Point(301, 388);
            btn_xoaPhieu.Margin = new Padding(2);
            btn_xoaPhieu.Name = "btn_xoaPhieu";
            btn_xoaPhieu.Size = new Size(66, 57);
            btn_xoaPhieu.TabIndex = 47;
            btn_xoaPhieu.Text = "Xóa Phiếu";
            btn_xoaPhieu.UseVisualStyleBackColor = true;
            // 
            // btn_themPhieu
            // 
            btn_themPhieu.Location = new Point(214, 388);
            btn_themPhieu.Margin = new Padding(2);
            btn_themPhieu.Name = "btn_themPhieu";
            btn_themPhieu.Size = new Size(66, 57);
            btn_themPhieu.TabIndex = 46;
            btn_themPhieu.Text = "Thêm Phiếu";
            btn_themPhieu.UseVisualStyleBackColor = true;
            // 
            // txt_ghiChu
            // 
            txt_ghiChu.Location = new Point(-15, 421);
            txt_ghiChu.Name = "txt_ghiChu";
            txt_ghiChu.Size = new Size(132, 23);
            txt_ghiChu.TabIndex = 45;
            // 
            // txt_tongSoLuong
            // 
            txt_tongSoLuong.Location = new Point(408, 355);
            txt_tongSoLuong.Name = "txt_tongSoLuong";
            txt_tongSoLuong.Size = new Size(142, 23);
            txt_tongSoLuong.TabIndex = 44;
            // 
            // txt_tongTienHang
            // 
            txt_tongTienHang.Location = new Point(122, 355);
            txt_tongTienHang.Name = "txt_tongTienHang";
            txt_tongTienHang.Size = new Size(142, 23);
            txt_tongTienHang.TabIndex = 43;
            // 
            // lb_ghiChu
            // 
            lb_ghiChu.AutoSize = true;
            lb_ghiChu.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ghiChu.ForeColor = Color.FromArgb(192, 130, 97);
            lb_ghiChu.Location = new Point(-15, 387);
            lb_ghiChu.Margin = new Padding(2, 0, 2, 0);
            lb_ghiChu.Name = "lb_ghiChu";
            lb_ghiChu.Size = new Size(72, 18);
            lb_ghiChu.TabIndex = 42;
            lb_ghiChu.Text = "Ghi Chú";
            // 
            // lb_tongSoLuong
            // 
            lb_tongSoLuong.AutoSize = true;
            lb_tongSoLuong.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_tongSoLuong.ForeColor = Color.FromArgb(192, 130, 97);
            lb_tongSoLuong.Location = new Point(270, 360);
            lb_tongSoLuong.Margin = new Padding(2, 0, 2, 0);
            lb_tongSoLuong.Name = "lb_tongSoLuong";
            lb_tongSoLuong.Size = new Size(130, 18);
            lb_tongSoLuong.TabIndex = 41;
            lb_tongSoLuong.Text = "Tổng Số Lượng";
            // 
            // lb_tongTienHang
            // 
            lb_tongTienHang.AutoSize = true;
            lb_tongTienHang.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_tongTienHang.ForeColor = Color.FromArgb(192, 130, 97);
            lb_tongTienHang.Location = new Point(-15, 360);
            lb_tongTienHang.Margin = new Padding(2, 0, 2, 0);
            lb_tongTienHang.Name = "lb_tongTienHang";
            lb_tongTienHang.Size = new Size(137, 18);
            lb_tongTienHang.TabIndex = 40;
            lb_tongTienHang.Text = "Tổng Tiền Hàng";
            // 
            // column_ma
            // 
            column_ma.HeaderText = "Mã";
            column_ma.Name = "column_ma";
            // 
            // column_tenBanh
            // 
            column_tenBanh.HeaderText = "Tên Bánh";
            column_tenBanh.Name = "column_tenBanh";
            // 
            // column_tong
            // 
            column_tong.HeaderText = "Tổng";
            column_tong.Name = "column_tong";
            // 
            // column_soLuong
            // 
            column_soLuong.HeaderText = "Số Lượng";
            column_soLuong.Name = "column_soLuong";
            // 
            // column_donVi
            // 
            column_donVi.HeaderText = "Đơn Vị";
            column_donVi.Name = "column_donVi";
            // 
            // btn_in
            // 
            btn_in.Location = new Point(391, 388);
            btn_in.Margin = new Padding(2);
            btn_in.Name = "btn_in";
            btn_in.Size = new Size(66, 57);
            btn_in.TabIndex = 49;
            btn_in.Text = "In";
            btn_in.UseVisualStyleBackColor = true;
            // 
            // column_gia
            // 
            column_gia.HeaderText = "Giá";
            column_gia.Name = "column_gia";
            // 
            // column_xoa
            // 
            column_xoa.HeaderText = "Xóa";
            column_xoa.Name = "column_xoa";
            column_xoa.Resizable = DataGridViewTriState.True;
            column_xoa.SortMode = DataGridViewColumnSortMode.Automatic;
            column_xoa.UseColumnTextForButtonValue = true;
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = Color.FromArgb(242, 236, 190);
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { column_ma, column_tenBanh, column_tong, column_soLuong, column_donVi, column_gia, column_thanhTien, column_xoa });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.Location = new Point(-3, 84);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(814, 265);
            dataGridView.TabIndex = 39;
            // 
            // column_thanhTien
            // 
            column_thanhTien.HeaderText = "Thành Tiền";
            column_thanhTien.Name = "column_thanhTien";
            // 
            // btn_after
            // 
            btn_after.BackgroundImage = Properties.Resources.rightArrow;
            btn_after.BackgroundImageLayout = ImageLayout.Zoom;
            btn_after.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_after.Location = new Point(306, 40);
            btn_after.Name = "btn_after";
            btn_after.Size = new Size(31, 24);
            btn_after.TabIndex = 38;
            btn_after.Text = " ";
            btn_after.TextAlign = ContentAlignment.MiddleLeft;
            btn_after.UseVisualStyleBackColor = true;
            btn_after.Click += btn_after_Click;
            // 
            // btn_before
            // 
            btn_before.BackgroundImage = Properties.Resources.leftArrow;
            btn_before.BackgroundImageLayout = ImageLayout.Zoom;
            btn_before.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_before.Location = new Point(275, 40);
            btn_before.Name = "btn_before";
            btn_before.Size = new Size(31, 24);
            btn_before.TabIndex = 37;
            btn_before.Text = " ";
            btn_before.TextAlign = ContentAlignment.MiddleLeft;
            btn_before.UseVisualStyleBackColor = true;
            btn_before.Click += btn_before_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(712, 40);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 36;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(441, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 23);
            textBox1.TabIndex = 35;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // txt_maPhieu
            // 
            txt_maPhieu.Location = new Point(127, 40);
            txt_maPhieu.Name = "txt_maPhieu";
            txt_maPhieu.Size = new Size(142, 23);
            txt_maPhieu.TabIndex = 34;
            txt_maPhieu.TextChanged += txt_maPhieu_TextChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.bread;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(560, 36);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(39, 28);
            pictureBox3.TabIndex = 33;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // lb_xuatCho
            // 
            lb_xuatCho.AutoSize = true;
            lb_xuatCho.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_xuatCho.ForeColor = Color.FromArgb(192, 130, 97);
            lb_xuatCho.Location = new Point(603, 46);
            lb_xuatCho.Margin = new Padding(2, 0, 2, 0);
            lb_xuatCho.Name = "lb_xuatCho";
            lb_xuatCho.Size = new Size(83, 18);
            lb_xuatCho.TabIndex = 32;
            lb_xuatCho.Text = "Xuất Cho";
            lb_xuatCho.Click += lb_xuatCho_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.bread;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(344, 35);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 28);
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // lb_ngay
            // 
            lb_ngay.AutoSize = true;
            lb_ngay.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ngay.ForeColor = Color.FromArgb(192, 130, 97);
            lb_ngay.Location = new Point(387, 45);
            lb_ngay.Margin = new Padding(2, 0, 2, 0);
            lb_ngay.Name = "lb_ngay";
            lb_ngay.Size = new Size(49, 18);
            lb_ngay.TabIndex = 30;
            lb_ngay.Text = "Ngày";
            lb_ngay.Click += lb_ngay_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.bread;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(-3, 35);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 28);
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btn_luuGhiChu
            // 
            btn_luuGhiChu.Location = new Point(127, 388);
            btn_luuGhiChu.Margin = new Padding(2);
            btn_luuGhiChu.Name = "btn_luuGhiChu";
            btn_luuGhiChu.Size = new Size(66, 57);
            btn_luuGhiChu.TabIndex = 28;
            btn_luuGhiChu.Text = "Lưu     Ghi Chú";
            btn_luuGhiChu.UseVisualStyleBackColor = true;
            // 
            // lb_maPhieu
            // 
            lb_maPhieu.AutoSize = true;
            lb_maPhieu.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_maPhieu.ForeColor = Color.FromArgb(192, 130, 97);
            lb_maPhieu.Location = new Point(40, 45);
            lb_maPhieu.Margin = new Padding(2, 0, 2, 0);
            lb_maPhieu.Name = "lb_maPhieu";
            lb_maPhieu.Size = new Size(82, 18);
            lb_maPhieu.TabIndex = 27;
            lb_maPhieu.Text = "Mã Phiếu";
            lb_maPhieu.Click += lb_maPhieu_Click;
            // 
            // lb_PhieuXuatHuy
            // 
            lb_PhieuXuatHuy.AutoSize = true;
            lb_PhieuXuatHuy.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_PhieuXuatHuy.Location = new Point(339, 9);
            lb_PhieuXuatHuy.Margin = new Padding(2, 0, 2, 0);
            lb_PhieuXuatHuy.Name = "lb_PhieuXuatHuy";
            lb_PhieuXuatHuy.Size = new Size(142, 18);
            lb_PhieuXuatHuy.TabIndex = 26;
            lb_PhieuXuatHuy.Text = "Phiếu Xuất Hủy";
            // 
            // form_xuatHuy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(226, 199, 153);
            ClientSize = new Size(815, 450);
            Controls.Add(button1);
            Controls.Add(btn_xuatBanhMan);
            Controls.Add(btn_xoaPhieu);
            Controls.Add(btn_themPhieu);
            Controls.Add(txt_ghiChu);
            Controls.Add(txt_tongSoLuong);
            Controls.Add(txt_tongTienHang);
            Controls.Add(lb_ghiChu);
            Controls.Add(lb_tongSoLuong);
            Controls.Add(lb_tongTienHang);
            Controls.Add(btn_in);
            Controls.Add(dataGridView);
            Controls.Add(btn_after);
            Controls.Add(btn_before);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txt_maPhieu);
            Controls.Add(pictureBox3);
            Controls.Add(lb_xuatCho);
            Controls.Add(pictureBox2);
            Controls.Add(lb_ngay);
            Controls.Add(pictureBox1);
            Controls.Add(btn_luuGhiChu);
            Controls.Add(lb_maPhieu);
            Controls.Add(lb_PhieuXuatHuy);
            Name = "form_xuatHuy";
            Text = "Xuất Hủy";
            Load += form_xuatHuy_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btn_xuatBanhMan;
        private Button btn_xoaPhieu;
        private Button btn_themPhieu;
        private TextBox txt_ghiChu;
        private TextBox txt_tongSoLuong;
        private TextBox txt_tongTienHang;
        private Label lb_ghiChu;
        private Label lb_tongSoLuong;
        private Label lb_tongTienHang;
        private DataGridViewTextBoxColumn column_ma;
        private DataGridViewTextBoxColumn column_tenBanh;
        private DataGridViewTextBoxColumn column_tong;
        private DataGridViewTextBoxColumn column_soLuong;
        private DataGridViewTextBoxColumn column_donVi;
        private Button btn_in;
        private DataGridViewTextBoxColumn column_gia;
        private DataGridViewButtonColumn column_xoa;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn column_thanhTien;
        private Button btn_after;
        private Button btn_before;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox txt_maPhieu;
        private PictureBox pictureBox3;
        private Label lb_xuatCho;
        private PictureBox pictureBox2;
        private Label lb_ngay;
        private PictureBox pictureBox1;
        private Button btn_luuGhiChu;
        private Label lb_maPhieu;
        private Label lb_PhieuXuatHuy;
    }
}