namespace ABC
{
    partial class form_XuatDi
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lb_maPhieu = new Label();
            button1 = new Button();
            btn_xoaPhieu = new Button();
            btn_themPhieu = new Button();
            txt_ghiChu = new TextBox();
            txt_tongSoLuong = new TextBox();
            txt_tongTienHang = new TextBox();
            lb_ghiChu = new Label();
            lb_tongSoLuong = new Label();
            btn_in = new Button();
            column_xoa = new DataGridViewButtonColumn();
            column_gia = new DataGridViewTextBoxColumn();
            column_donVi = new DataGridViewTextBoxColumn();
            column_soLuong = new DataGridViewTextBoxColumn();
            column_tong = new DataGridViewTextBoxColumn();
            column_tenBanh = new DataGridViewTextBoxColumn();
            column_ma = new DataGridViewTextBoxColumn();
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
            lb_PhieuXuatDi = new Label();
            lb_tongTienHang = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lb_maPhieu
            // 
            lb_maPhieu.AutoSize = true;
            lb_maPhieu.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_maPhieu.ForeColor = Color.FromArgb(192, 130, 97);
            lb_maPhieu.Location = new Point(51, 73);
            lb_maPhieu.Name = "lb_maPhieu";
            lb_maPhieu.Size = new Size(119, 29);
            lb_maPhieu.TabIndex = 77;
            lb_maPhieu.Text = "Mã Phiếu";
            // 
            // button1
            // 
            button1.ForeColor = Color.FromArgb(226, 199, 153);
            button1.Location = new Point(1030, 6);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(117, 48);
            button1.TabIndex = 99;
            button1.Text = "Đổi Ngày";
            button1.UseVisualStyleBackColor = true;
            // 
            // btn_xoaPhieu
            // 
            btn_xoaPhieu.Location = new Point(451, 650);
            btn_xoaPhieu.Name = "btn_xoaPhieu";
            btn_xoaPhieu.Size = new Size(94, 95);
            btn_xoaPhieu.TabIndex = 97;
            btn_xoaPhieu.Text = "Xóa Phiếu";
            btn_xoaPhieu.UseVisualStyleBackColor = true;
            // 
            // btn_themPhieu
            // 
            btn_themPhieu.Location = new Point(327, 650);
            btn_themPhieu.Name = "btn_themPhieu";
            btn_themPhieu.Size = new Size(94, 95);
            btn_themPhieu.TabIndex = 96;
            btn_themPhieu.Text = "Thêm Phiếu";
            btn_themPhieu.UseVisualStyleBackColor = true;
            // 
            // txt_ghiChu
            // 
            txt_ghiChu.Location = new Point(0, 705);
            txt_ghiChu.Margin = new Padding(4, 5, 4, 5);
            txt_ghiChu.Name = "txt_ghiChu";
            txt_ghiChu.Size = new Size(187, 31);
            txt_ghiChu.TabIndex = 95;
            // 
            // txt_tongSoLuong
            // 
            txt_tongSoLuong.Location = new Point(604, 595);
            txt_tongSoLuong.Margin = new Padding(4, 5, 4, 5);
            txt_tongSoLuong.Name = "txt_tongSoLuong";
            txt_tongSoLuong.Size = new Size(201, 31);
            txt_tongSoLuong.TabIndex = 94;
            // 
            // txt_tongTienHang
            // 
            txt_tongTienHang.Location = new Point(195, 595);
            txt_tongTienHang.Margin = new Padding(4, 5, 4, 5);
            txt_tongTienHang.Name = "txt_tongTienHang";
            txt_tongTienHang.Size = new Size(201, 31);
            txt_tongTienHang.TabIndex = 93;
            // 
            // lb_ghiChu
            // 
            lb_ghiChu.AutoSize = true;
            lb_ghiChu.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ghiChu.ForeColor = Color.FromArgb(192, 130, 97);
            lb_ghiChu.Location = new Point(0, 648);
            lb_ghiChu.Name = "lb_ghiChu";
            lb_ghiChu.Size = new Size(108, 29);
            lb_ghiChu.TabIndex = 92;
            lb_ghiChu.Text = "Ghi Chú";
            // 
            // lb_tongSoLuong
            // 
            lb_tongSoLuong.AutoSize = true;
            lb_tongSoLuong.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_tongSoLuong.ForeColor = Color.FromArgb(192, 130, 97);
            lb_tongSoLuong.Location = new Point(407, 603);
            lb_tongSoLuong.Name = "lb_tongSoLuong";
            lb_tongSoLuong.Size = new Size(194, 29);
            lb_tongSoLuong.TabIndex = 91;
            lb_tongSoLuong.Text = "Tổng Số Lượng";
            // 
            // btn_in
            // 
            btn_in.Location = new Point(580, 650);
            btn_in.Name = "btn_in";
            btn_in.Size = new Size(94, 95);
            btn_in.TabIndex = 98;
            btn_in.Text = "In";
            btn_in.UseVisualStyleBackColor = true;
            // 
            // column_xoa
            // 
            column_xoa.HeaderText = "Xóa";
            column_xoa.MinimumWidth = 8;
            column_xoa.Name = "column_xoa";
            column_xoa.Resizable = DataGridViewTriState.True;
            column_xoa.SortMode = DataGridViewColumnSortMode.Automatic;
            column_xoa.UseColumnTextForButtonValue = true;
            column_xoa.Width = 150;
            // 
            // column_gia
            // 
            column_gia.HeaderText = "Giá";
            column_gia.MinimumWidth = 8;
            column_gia.Name = "column_gia";
            column_gia.Width = 150;
            // 
            // column_donVi
            // 
            column_donVi.HeaderText = "Đơn Vị";
            column_donVi.MinimumWidth = 8;
            column_donVi.Name = "column_donVi";
            column_donVi.Width = 150;
            // 
            // column_soLuong
            // 
            column_soLuong.HeaderText = "Số Lượng";
            column_soLuong.MinimumWidth = 8;
            column_soLuong.Name = "column_soLuong";
            column_soLuong.Width = 150;
            // 
            // column_tong
            // 
            column_tong.HeaderText = "Tổng";
            column_tong.MinimumWidth = 8;
            column_tong.Name = "column_tong";
            column_tong.Width = 150;
            // 
            // column_tenBanh
            // 
            column_tenBanh.HeaderText = "Tên Bánh";
            column_tenBanh.MinimumWidth = 8;
            column_tenBanh.Name = "column_tenBanh";
            column_tenBanh.Width = 150;
            // 
            // column_ma
            // 
            column_ma.HeaderText = "Mã";
            column_ma.MinimumWidth = 8;
            column_ma.Name = "column_ma";
            column_ma.Width = 150;
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = Color.FromArgb(242, 236, 190);
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { column_ma, column_tenBanh, column_tong, column_soLuong, column_donVi, column_gia, column_thanhTien, column_xoa });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.Location = new Point(-10, 143);
            dataGridView.Margin = new Padding(4, 5, 4, 5);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(1163, 442);
            dataGridView.TabIndex = 89;
            // 
            // column_thanhTien
            // 
            column_thanhTien.HeaderText = "Thành Tiền";
            column_thanhTien.MinimumWidth = 8;
            column_thanhTien.Name = "column_thanhTien";
            column_thanhTien.Width = 150;
            // 
            // btn_after
            // 
            btn_after.BackgroundImage = Properties.Resources.rightArrow;
            btn_after.BackgroundImageLayout = ImageLayout.Zoom;
            btn_after.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_after.Location = new Point(431, 65);
            btn_after.Margin = new Padding(4, 5, 4, 5);
            btn_after.Name = "btn_after";
            btn_after.Size = new Size(44, 40);
            btn_after.TabIndex = 88;
            btn_after.Text = " ";
            btn_after.TextAlign = ContentAlignment.MiddleLeft;
            btn_after.UseVisualStyleBackColor = true;
            // 
            // btn_before
            // 
            btn_before.BackgroundImage = Properties.Resources.leftArrow;
            btn_before.BackgroundImageLayout = ImageLayout.Zoom;
            btn_before.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_before.Location = new Point(387, 65);
            btn_before.Margin = new Padding(4, 5, 4, 5);
            btn_before.Name = "btn_before";
            btn_before.Size = new Size(44, 40);
            btn_before.TabIndex = 87;
            btn_before.Text = " ";
            btn_before.TextAlign = ContentAlignment.MiddleLeft;
            btn_before.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1011, 65);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(141, 31);
            textBox2.TabIndex = 86;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(624, 65);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 31);
            textBox1.TabIndex = 85;
            // 
            // txt_maPhieu
            // 
            txt_maPhieu.Location = new Point(175, 65);
            txt_maPhieu.Margin = new Padding(4, 5, 4, 5);
            txt_maPhieu.Name = "txt_maPhieu";
            txt_maPhieu.Size = new Size(201, 31);
            txt_maPhieu.TabIndex = 84;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.bread;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(794, 58);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(56, 47);
            pictureBox3.TabIndex = 83;
            pictureBox3.TabStop = false;
            // 
            // lb_xuatCho
            // 
            lb_xuatCho.AutoSize = true;
            lb_xuatCho.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_xuatCho.ForeColor = Color.FromArgb(192, 130, 97);
            lb_xuatCho.Location = new Point(855, 75);
            lb_xuatCho.Name = "lb_xuatCho";
            lb_xuatCho.Size = new Size(122, 29);
            lb_xuatCho.TabIndex = 82;
            lb_xuatCho.Text = "Xuất Cho";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.bread;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(485, 56);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 47);
            pictureBox2.TabIndex = 81;
            pictureBox2.TabStop = false;
            // 
            // lb_ngay
            // 
            lb_ngay.AutoSize = true;
            lb_ngay.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ngay.ForeColor = Color.FromArgb(192, 130, 97);
            lb_ngay.Location = new Point(547, 73);
            lb_ngay.Name = "lb_ngay";
            lb_ngay.Size = new Size(74, 29);
            lb_ngay.TabIndex = 80;
            lb_ngay.Text = "Ngày";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.bread;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(-10, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 47);
            pictureBox1.TabIndex = 79;
            pictureBox1.TabStop = false;
            // 
            // btn_luuGhiChu
            // 
            btn_luuGhiChu.Location = new Point(202, 650);
            btn_luuGhiChu.Name = "btn_luuGhiChu";
            btn_luuGhiChu.Size = new Size(94, 95);
            btn_luuGhiChu.TabIndex = 78;
            btn_luuGhiChu.Text = "Lưu     Ghi Chú";
            btn_luuGhiChu.UseVisualStyleBackColor = true;
            // 
            // lb_PhieuXuatDi
            // 
            lb_PhieuXuatDi.AutoSize = true;
            lb_PhieuXuatDi.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_PhieuXuatDi.Location = new Point(478, 13);
            lb_PhieuXuatDi.Name = "lb_PhieuXuatDi";
            lb_PhieuXuatDi.Size = new Size(195, 29);
            lb_PhieuXuatDi.TabIndex = 76;
            lb_PhieuXuatDi.Text = "Phiếu Xuất Đi";
            // 
            // lb_tongTienHang
            // 
            lb_tongTienHang.AutoSize = true;
            lb_tongTienHang.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_tongTienHang.ForeColor = Color.FromArgb(192, 130, 97);
            lb_tongTienHang.Location = new Point(0, 603);
            lb_tongTienHang.Name = "lb_tongTienHang";
            lb_tongTienHang.Size = new Size(201, 29);
            lb_tongTienHang.TabIndex = 90;
            lb_tongTienHang.Text = "Tổng Tiền Hàng";
            // 
            // form_XuatDi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(226, 199, 153);
            ClientSize = new Size(1181, 750);
            Controls.Add(lb_maPhieu);
            Controls.Add(button1);
            Controls.Add(btn_xoaPhieu);
            Controls.Add(btn_themPhieu);
            Controls.Add(txt_ghiChu);
            Controls.Add(txt_tongSoLuong);
            Controls.Add(txt_tongTienHang);
            Controls.Add(lb_ghiChu);
            Controls.Add(lb_tongSoLuong);
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
            Controls.Add(lb_PhieuXuatDi);
            Controls.Add(lb_tongTienHang);
            Margin = new Padding(4, 5, 4, 5);
            Name = "form_XuatDi";
            Text = "Xuất Đi";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_maPhieu;
        private Button button1;
        private Button btn_xoaPhieu;
        private Button btn_themPhieu;
        private TextBox txt_ghiChu;
        private TextBox txt_tongSoLuong;
        private TextBox txt_tongTienHang;
        private Label lb_ghiChu;
        private Label lb_tongSoLuong;
        private Button btn_in;
        private DataGridViewButtonColumn column_xoa;
        private DataGridViewTextBoxColumn column_gia;
        private DataGridViewTextBoxColumn column_donVi;
        private DataGridViewTextBoxColumn column_soLuong;
        private DataGridViewTextBoxColumn column_tong;
        private DataGridViewTextBoxColumn column_tenBanh;
        private DataGridViewTextBoxColumn column_ma;
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
        private Label lb_PhieuXuatDi;
        private Label lb_tongTienHang;
    }
}