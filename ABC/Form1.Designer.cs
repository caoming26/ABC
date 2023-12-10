namespace ABC
{
    partial class form_danhMucBanh
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            lb_danhMucBanh = new Label();
            btn_timKiem = new Button();
            btn_xuatExcel = new Button();
            btn_inDanhSach = new Button();
            dataGridView1 = new DataGridView();
            column_loaiBanh = new DataGridViewTextBoxColumn();
            column_ma = new DataGridViewTextBoxColumn();
            column_tenBanh = new DataGridViewTextBoxColumn();
            column_donVi = new DataGridViewTextBoxColumn();
            column_giaMua = new DataGridViewTextBoxColumn();
            column_giaBan = new DataGridViewTextBoxColumn();
            column_hien = new DataGridViewCheckBoxColumn();
            lb_themBanh = new Label();
            lb_themTenBanh = new Label();
            lb_themGiaMua = new Label();
            lb_themGiaBan = new Label();
            lb_themLoaiBanh = new Label();
            lb_themDonVi = new Label();
            txt_themTenBanh = new TextBox();
            txt_themGiaMua = new TextBox();
            txt_themGiaBan = new TextBox();
            txt_themLoaiBanh = new TextBox();
            txt_themDonVi = new TextBox();
            txt_suaDonVi = new TextBox();
            txt_suaLoaiBanh = new TextBox();
            txt_suaGiaBan = new TextBox();
            txt_suaGiaMua = new TextBox();
            txt_suaTenBanh = new TextBox();
            lb_suaDonVi = new Label();
            lb_suaLoaiBanh = new Label();
            lb_suaGiaBan = new Label();
            lb_suaGiaMua = new Label();
            lb_suaTenBanh = new Label();
            lb_suaBanh = new Label();
            btn_them = new Button();
            btn_sua = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lb_danhMucBanh
            // 
            lb_danhMucBanh.AutoSize = true;
            lb_danhMucBanh.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_danhMucBanh.ForeColor = Color.FromArgb(154, 59, 59);
            lb_danhMucBanh.Location = new Point(473, 15);
            lb_danhMucBanh.Margin = new Padding(4, 0, 4, 0);
            lb_danhMucBanh.Name = "lb_danhMucBanh";
            lb_danhMucBanh.Size = new Size(211, 28);
            lb_danhMucBanh.TabIndex = 0;
            lb_danhMucBanh.Text = "Danh Mục Bánh";
            // 
            // btn_timKiem
            // 
            btn_timKiem.BackColor = Color.FromArgb(226, 199, 153);
            btn_timKiem.FlatStyle = FlatStyle.Flat;
            btn_timKiem.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_timKiem.ForeColor = Color.FromArgb(154, 59, 59);
            btn_timKiem.Location = new Point(193, 51);
            btn_timKiem.Margin = new Padding(4, 5, 4, 5);
            btn_timKiem.Name = "btn_timKiem";
            btn_timKiem.Size = new Size(153, 37);
            btn_timKiem.TabIndex = 1;
            btn_timKiem.Text = "Tìm Kiếm";
            btn_timKiem.UseVisualStyleBackColor = false;
            // 
            // btn_xuatExcel
            // 
            btn_xuatExcel.BackColor = Color.FromArgb(226, 199, 153);
            btn_xuatExcel.FlatStyle = FlatStyle.Flat;
            btn_xuatExcel.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_xuatExcel.ForeColor = Color.FromArgb(154, 59, 59);
            btn_xuatExcel.Location = new Point(950, 51);
            btn_xuatExcel.Margin = new Padding(4, 5, 4, 5);
            btn_xuatExcel.Name = "btn_xuatExcel";
            btn_xuatExcel.Size = new Size(153, 37);
            btn_xuatExcel.TabIndex = 2;
            btn_xuatExcel.Text = "Xuất Excel";
            btn_xuatExcel.UseVisualStyleBackColor = false;
            // 
            // btn_inDanhSach
            // 
            btn_inDanhSach.BackColor = Color.FromArgb(226, 199, 153);
            btn_inDanhSach.FlatStyle = FlatStyle.Flat;
            btn_inDanhSach.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_inDanhSach.ForeColor = Color.FromArgb(154, 59, 59);
            btn_inDanhSach.Location = new Point(789, 51);
            btn_inDanhSach.Margin = new Padding(4, 5, 4, 5);
            btn_inDanhSach.Name = "btn_inDanhSach";
            btn_inDanhSach.Size = new Size(153, 37);
            btn_inDanhSach.TabIndex = 3;
            btn_inDanhSach.Text = "In Danh Sách";
            btn_inDanhSach.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(226, 199, 153);
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(226, 199, 153);
            dataGridViewCellStyle4.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { column_loaiBanh, column_ma, column_tenBanh, column_donVi, column_giaMua, column_giaBan, column_hien });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(226, 199, 153);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.GridColor = Color.FromArgb(154, 59, 59);
            dataGridView1.Location = new Point(-6, 106);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(226, 199, 153);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1205, 375);
            dataGridView1.TabIndex = 4;
            // 
            // column_loaiBanh
            // 
            column_loaiBanh.HeaderText = "Loại Bánh";
            column_loaiBanh.MinimumWidth = 8;
            column_loaiBanh.Name = "column_loaiBanh";
            column_loaiBanh.Width = 150;
            // 
            // column_ma
            // 
            column_ma.HeaderText = "Mã";
            column_ma.MinimumWidth = 8;
            column_ma.Name = "column_ma";
            column_ma.Width = 150;
            // 
            // column_tenBanh
            // 
            column_tenBanh.HeaderText = "Tên Bánh";
            column_tenBanh.MinimumWidth = 8;
            column_tenBanh.Name = "column_tenBanh";
            column_tenBanh.Width = 300;
            // 
            // column_donVi
            // 
            column_donVi.HeaderText = "Đơn Vị";
            column_donVi.MinimumWidth = 8;
            column_donVi.Name = "column_donVi";
            column_donVi.Width = 150;
            // 
            // column_giaMua
            // 
            column_giaMua.HeaderText = "Giá Mua";
            column_giaMua.MinimumWidth = 8;
            column_giaMua.Name = "column_giaMua";
            column_giaMua.Width = 150;
            // 
            // column_giaBan
            // 
            column_giaBan.HeaderText = "Giá Bán";
            column_giaBan.MinimumWidth = 8;
            column_giaBan.Name = "column_giaBan";
            column_giaBan.Width = 150;
            // 
            // column_hien
            // 
            column_hien.HeaderText = "Hiện";
            column_hien.MinimumWidth = 8;
            column_hien.Name = "column_hien";
            column_hien.Width = 60;
            // 
            // lb_themBanh
            // 
            lb_themBanh.AutoSize = true;
            lb_themBanh.BackColor = Color.FromArgb(226, 199, 153);
            lb_themBanh.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_themBanh.ForeColor = Color.FromArgb(154, 59, 59);
            lb_themBanh.Location = new Point(125, 510);
            lb_themBanh.Name = "lb_themBanh";
            lb_themBanh.Size = new Size(124, 22);
            lb_themBanh.TabIndex = 5;
            lb_themBanh.Text = "Thêm Bánh";
            // 
            // lb_themTenBanh
            // 
            lb_themTenBanh.AutoSize = true;
            lb_themTenBanh.BackColor = Color.FromArgb(226, 199, 153);
            lb_themTenBanh.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_themTenBanh.ForeColor = Color.FromArgb(154, 59, 59);
            lb_themTenBanh.Location = new Point(14, 564);
            lb_themTenBanh.Name = "lb_themTenBanh";
            lb_themTenBanh.Size = new Size(105, 22);
            lb_themTenBanh.TabIndex = 6;
            lb_themTenBanh.Text = "Tên Bánh";
            // 
            // lb_themGiaMua
            // 
            lb_themGiaMua.AutoSize = true;
            lb_themGiaMua.BackColor = Color.FromArgb(226, 199, 153);
            lb_themGiaMua.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_themGiaMua.ForeColor = Color.FromArgb(154, 59, 59);
            lb_themGiaMua.Location = new Point(25, 601);
            lb_themGiaMua.Name = "lb_themGiaMua";
            lb_themGiaMua.Size = new Size(91, 22);
            lb_themGiaMua.TabIndex = 7;
            lb_themGiaMua.Text = "Giá Mua";
            // 
            // lb_themGiaBan
            // 
            lb_themGiaBan.AutoSize = true;
            lb_themGiaBan.BackColor = Color.FromArgb(226, 199, 153);
            lb_themGiaBan.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_themGiaBan.ForeColor = Color.FromArgb(154, 59, 59);
            lb_themGiaBan.Location = new Point(28, 638);
            lb_themGiaBan.Name = "lb_themGiaBan";
            lb_themGiaBan.Size = new Size(88, 22);
            lb_themGiaBan.TabIndex = 8;
            lb_themGiaBan.Text = "Giá Bán";
            // 
            // lb_themLoaiBanh
            // 
            lb_themLoaiBanh.AutoSize = true;
            lb_themLoaiBanh.BackColor = Color.FromArgb(226, 199, 153);
            lb_themLoaiBanh.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_themLoaiBanh.ForeColor = Color.FromArgb(154, 59, 59);
            lb_themLoaiBanh.Location = new Point(10, 675);
            lb_themLoaiBanh.Name = "lb_themLoaiBanh";
            lb_themLoaiBanh.Size = new Size(109, 22);
            lb_themLoaiBanh.TabIndex = 9;
            lb_themLoaiBanh.Text = "Loại Bánh";
            // 
            // lb_themDonVi
            // 
            lb_themDonVi.AutoSize = true;
            lb_themDonVi.BackColor = Color.FromArgb(226, 199, 153);
            lb_themDonVi.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_themDonVi.ForeColor = Color.FromArgb(154, 59, 59);
            lb_themDonVi.Location = new Point(301, 564);
            lb_themDonVi.Name = "lb_themDonVi";
            lb_themDonVi.Size = new Size(76, 22);
            lb_themDonVi.TabIndex = 10;
            lb_themDonVi.Text = "Đơn Vị";
            // 
            // txt_themTenBanh
            // 
            txt_themTenBanh.BackColor = Color.FromArgb(226, 199, 153);
            txt_themTenBanh.Location = new Point(125, 555);
            txt_themTenBanh.Name = "txt_themTenBanh";
            txt_themTenBanh.Size = new Size(170, 31);
            txt_themTenBanh.TabIndex = 11;
            // 
            // txt_themGiaMua
            // 
            txt_themGiaMua.BackColor = Color.FromArgb(226, 199, 153);
            txt_themGiaMua.Location = new Point(125, 592);
            txt_themGiaMua.Name = "txt_themGiaMua";
            txt_themGiaMua.Size = new Size(170, 31);
            txt_themGiaMua.TabIndex = 12;
            // 
            // txt_themGiaBan
            // 
            txt_themGiaBan.BackColor = Color.FromArgb(226, 199, 153);
            txt_themGiaBan.Location = new Point(125, 629);
            txt_themGiaBan.Name = "txt_themGiaBan";
            txt_themGiaBan.Size = new Size(170, 31);
            txt_themGiaBan.TabIndex = 13;
            // 
            // txt_themLoaiBanh
            // 
            txt_themLoaiBanh.BackColor = Color.FromArgb(226, 199, 153);
            txt_themLoaiBanh.Location = new Point(125, 666);
            txt_themLoaiBanh.Name = "txt_themLoaiBanh";
            txt_themLoaiBanh.Size = new Size(170, 31);
            txt_themLoaiBanh.TabIndex = 14;
            // 
            // txt_themDonVi
            // 
            txt_themDonVi.BackColor = Color.FromArgb(226, 199, 153);
            txt_themDonVi.Location = new Point(383, 555);
            txt_themDonVi.Name = "txt_themDonVi";
            txt_themDonVi.Size = new Size(83, 31);
            txt_themDonVi.TabIndex = 15;
            // 
            // txt_suaDonVi
            // 
            txt_suaDonVi.BackColor = Color.FromArgb(226, 199, 153);
            txt_suaDonVi.Location = new Point(829, 555);
            txt_suaDonVi.Name = "txt_suaDonVi";
            txt_suaDonVi.Size = new Size(83, 31);
            txt_suaDonVi.TabIndex = 26;
            // 
            // txt_suaLoaiBanh
            // 
            txt_suaLoaiBanh.BackColor = Color.FromArgb(226, 199, 153);
            txt_suaLoaiBanh.Location = new Point(1029, 666);
            txt_suaLoaiBanh.Name = "txt_suaLoaiBanh";
            txt_suaLoaiBanh.Size = new Size(170, 31);
            txt_suaLoaiBanh.TabIndex = 25;
            // 
            // txt_suaGiaBan
            // 
            txt_suaGiaBan.BackColor = Color.FromArgb(226, 199, 153);
            txt_suaGiaBan.Location = new Point(1029, 629);
            txt_suaGiaBan.Name = "txt_suaGiaBan";
            txt_suaGiaBan.Size = new Size(170, 31);
            txt_suaGiaBan.TabIndex = 24;
            // 
            // txt_suaGiaMua
            // 
            txt_suaGiaMua.BackColor = Color.FromArgb(226, 199, 153);
            txt_suaGiaMua.Location = new Point(1029, 592);
            txt_suaGiaMua.Name = "txt_suaGiaMua";
            txt_suaGiaMua.Size = new Size(170, 31);
            txt_suaGiaMua.TabIndex = 23;
            // 
            // txt_suaTenBanh
            // 
            txt_suaTenBanh.BackColor = Color.FromArgb(226, 199, 153);
            txt_suaTenBanh.Location = new Point(1029, 555);
            txt_suaTenBanh.Name = "txt_suaTenBanh";
            txt_suaTenBanh.Size = new Size(170, 31);
            txt_suaTenBanh.TabIndex = 22;
            // 
            // lb_suaDonVi
            // 
            lb_suaDonVi.AutoSize = true;
            lb_suaDonVi.BackColor = Color.FromArgb(226, 199, 153);
            lb_suaDonVi.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_suaDonVi.ForeColor = Color.FromArgb(154, 59, 59);
            lb_suaDonVi.Location = new Point(747, 564);
            lb_suaDonVi.Name = "lb_suaDonVi";
            lb_suaDonVi.Size = new Size(76, 22);
            lb_suaDonVi.TabIndex = 21;
            lb_suaDonVi.Text = "Đơn Vị";
            // 
            // lb_suaLoaiBanh
            // 
            lb_suaLoaiBanh.AutoSize = true;
            lb_suaLoaiBanh.BackColor = Color.FromArgb(226, 199, 153);
            lb_suaLoaiBanh.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_suaLoaiBanh.ForeColor = Color.FromArgb(154, 59, 59);
            lb_suaLoaiBanh.Location = new Point(914, 675);
            lb_suaLoaiBanh.Name = "lb_suaLoaiBanh";
            lb_suaLoaiBanh.Size = new Size(109, 22);
            lb_suaLoaiBanh.TabIndex = 20;
            lb_suaLoaiBanh.Text = "Loại Bánh";
            // 
            // lb_suaGiaBan
            // 
            lb_suaGiaBan.AutoSize = true;
            lb_suaGiaBan.BackColor = Color.FromArgb(226, 199, 153);
            lb_suaGiaBan.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_suaGiaBan.ForeColor = Color.FromArgb(154, 59, 59);
            lb_suaGiaBan.Location = new Point(932, 638);
            lb_suaGiaBan.Name = "lb_suaGiaBan";
            lb_suaGiaBan.Size = new Size(88, 22);
            lb_suaGiaBan.TabIndex = 19;
            lb_suaGiaBan.Text = "Giá Bán";
            // 
            // lb_suaGiaMua
            // 
            lb_suaGiaMua.AutoSize = true;
            lb_suaGiaMua.BackColor = Color.FromArgb(226, 199, 153);
            lb_suaGiaMua.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_suaGiaMua.ForeColor = Color.FromArgb(154, 59, 59);
            lb_suaGiaMua.Location = new Point(929, 601);
            lb_suaGiaMua.Name = "lb_suaGiaMua";
            lb_suaGiaMua.Size = new Size(91, 22);
            lb_suaGiaMua.TabIndex = 18;
            lb_suaGiaMua.Text = "Giá Mua";
            // 
            // lb_suaTenBanh
            // 
            lb_suaTenBanh.AutoSize = true;
            lb_suaTenBanh.BackColor = Color.FromArgb(226, 199, 153);
            lb_suaTenBanh.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_suaTenBanh.ForeColor = Color.FromArgb(154, 59, 59);
            lb_suaTenBanh.Location = new Point(918, 564);
            lb_suaTenBanh.Name = "lb_suaTenBanh";
            lb_suaTenBanh.Size = new Size(105, 22);
            lb_suaTenBanh.TabIndex = 17;
            lb_suaTenBanh.Text = "Tên Bánh";
            // 
            // lb_suaBanh
            // 
            lb_suaBanh.AutoSize = true;
            lb_suaBanh.BackColor = Color.FromArgb(226, 199, 153);
            lb_suaBanh.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_suaBanh.ForeColor = Color.FromArgb(154, 59, 59);
            lb_suaBanh.Location = new Point(929, 510);
            lb_suaBanh.Name = "lb_suaBanh";
            lb_suaBanh.Size = new Size(107, 22);
            lb_suaBanh.TabIndex = 16;
            lb_suaBanh.Text = "Sửa Bánh";
            // 
            // btn_them
            // 
            btn_them.BackColor = Color.FromArgb(226, 199, 153);
            btn_them.FlatStyle = FlatStyle.Flat;
            btn_them.Font = new Font("Verdana", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn_them.ForeColor = Color.FromArgb(154, 59, 59);
            btn_them.Location = new Point(320, 617);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(144, 80);
            btn_them.TabIndex = 27;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = false;
            // 
            // btn_sua
            // 
            btn_sua.BackColor = Color.FromArgb(226, 199, 153);
            btn_sua.FlatStyle = FlatStyle.Flat;
            btn_sua.Font = new Font("Verdana", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn_sua.ForeColor = Color.FromArgb(154, 59, 59);
            btn_sua.Location = new Point(747, 617);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(144, 80);
            btn_sua.TabIndex = 28;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = false;
            // 
            // form_danhMucBanh
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 236, 190);
            ClientSize = new Size(1211, 711);
            Controls.Add(btn_sua);
            Controls.Add(btn_them);
            Controls.Add(txt_suaDonVi);
            Controls.Add(txt_suaLoaiBanh);
            Controls.Add(txt_suaGiaBan);
            Controls.Add(txt_suaGiaMua);
            Controls.Add(txt_suaTenBanh);
            Controls.Add(lb_suaDonVi);
            Controls.Add(lb_suaLoaiBanh);
            Controls.Add(lb_suaGiaBan);
            Controls.Add(lb_suaGiaMua);
            Controls.Add(lb_suaTenBanh);
            Controls.Add(lb_suaBanh);
            Controls.Add(txt_themDonVi);
            Controls.Add(txt_themLoaiBanh);
            Controls.Add(txt_themGiaBan);
            Controls.Add(txt_themGiaMua);
            Controls.Add(txt_themTenBanh);
            Controls.Add(lb_themDonVi);
            Controls.Add(lb_themLoaiBanh);
            Controls.Add(lb_themGiaBan);
            Controls.Add(lb_themGiaMua);
            Controls.Add(lb_themTenBanh);
            Controls.Add(lb_themBanh);
            Controls.Add(dataGridView1);
            Controls.Add(btn_inDanhSach);
            Controls.Add(btn_xuatExcel);
            Controls.Add(btn_timKiem);
            Controls.Add(lb_danhMucBanh);
            Margin = new Padding(4, 5, 4, 5);
            Name = "form_danhMucBanh";
            Text = "Danh Mục Bánh";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_danhMucBanh;
        private Button btn_timKiem;
        private Button btn_xuatExcel;
        private Button btn_inDanhSach;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn column_loaiBanh;
        private DataGridViewTextBoxColumn column_ma;
        private DataGridViewTextBoxColumn column_tenBanh;
        private DataGridViewTextBoxColumn column_donVi;
        private DataGridViewTextBoxColumn column_giaMua;
        private DataGridViewTextBoxColumn column_giaBan;
        private DataGridViewCheckBoxColumn column_hien;
        private Label lb_themBanh;
        private Label lb_themTenBanh;
        private Label lb_themGiaMua;
        private Label lb_themGiaBan;
        private Label lb_themLoaiBanh;
        private Label lb_themDonVi;
        private TextBox txt_themTenBanh;
        private TextBox txt_themGiaMua;
        private TextBox txt_themGiaBan;
        private TextBox txt_themLoaiBanh;
        private TextBox txt_themDonVi;
        private TextBox txt_suaDonVi;
        private TextBox txt_suaLoaiBanh;
        private TextBox txt_suaGiaBan;
        private TextBox txt_suaGiaMua;
        private TextBox txt_suaTenBanh;
        private Label lb_suaDonVi;
        private Label lb_suaLoaiBanh;
        private Label lb_suaGiaBan;
        private Label lb_suaGiaMua;
        private Label lb_suaTenBanh;
        private Label lb_suaBanh;
        private Button btn_them;
        private Button btn_sua;
    }
}