namespace ABC
{
    partial class DanhMucBanh
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btn_sua = new Button();
            btn_them = new Button();
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
            txt_themDonVi = new TextBox();
            txt_themLoaiBanh = new TextBox();
            txt_themGiaBan = new TextBox();
            txt_themGiaMua = new TextBox();
            txt_themTenBanh = new TextBox();
            lb_themDonVi = new Label();
            dataGridView1 = new DataGridView();
            column_loaiBanh = new DataGridViewTextBoxColumn();
            column_ma = new DataGridViewTextBoxColumn();
            column_tenBanh = new DataGridViewTextBoxColumn();
            column_donVi = new DataGridViewTextBoxColumn();
            column_giaMua = new DataGridViewTextBoxColumn();
            column_giaBan = new DataGridViewTextBoxColumn();
            column_hien = new DataGridViewCheckBoxColumn();
            btn_inDanhSach = new Button();
            btn_xuatExcel = new Button();
            btn_timKiem = new Button();
            lb_danhMucBanh = new Label();
            lb_themLoaiBanh = new Label();
            lb_themGiaMua = new Label();
            lb_themTenBanh = new Label();
            lb_themBanh = new Label();
            lb_themGiaBan = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_sua
            // 
            btn_sua.BackColor = Color.FromArgb(226, 199, 153);
            btn_sua.FlatStyle = FlatStyle.Flat;
            btn_sua.Font = new Font("Verdana", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn_sua.ForeColor = Color.FromArgb(154, 59, 59);
            btn_sua.Location = new Point(715, 626);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(144, 80);
            btn_sua.TabIndex = 57;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = false;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_them
            // 
            btn_them.BackColor = Color.FromArgb(226, 199, 153);
            btn_them.FlatStyle = FlatStyle.Flat;
            btn_them.Font = new Font("Verdana", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn_them.ForeColor = Color.FromArgb(154, 59, 59);
            btn_them.Location = new Point(329, 622);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(144, 80);
            btn_them.TabIndex = 56;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = false;
            btn_them.Click += btn_them_Click;
            // 
            // txt_suaDonVi
            // 
            txt_suaDonVi.BackColor = Color.FromArgb(226, 199, 153);
            txt_suaDonVi.Location = new Point(797, 564);
            txt_suaDonVi.Name = "txt_suaDonVi";
            txt_suaDonVi.Size = new Size(83, 31);
            txt_suaDonVi.TabIndex = 55;
            txt_suaDonVi.TextChanged += txt_suaDonVi_TextChanged;
            // 
            // txt_suaLoaiBanh
            // 
            txt_suaLoaiBanh.BackColor = Color.FromArgb(226, 199, 153);
            txt_suaLoaiBanh.Location = new Point(997, 675);
            txt_suaLoaiBanh.Name = "txt_suaLoaiBanh";
            txt_suaLoaiBanh.Size = new Size(170, 31);
            txt_suaLoaiBanh.TabIndex = 54;
            txt_suaLoaiBanh.TextChanged += txt_suaLoaiBanh_TextChanged;
            // 
            // txt_suaGiaBan
            // 
            txt_suaGiaBan.BackColor = Color.FromArgb(226, 199, 153);
            txt_suaGiaBan.Location = new Point(997, 638);
            txt_suaGiaBan.Name = "txt_suaGiaBan";
            txt_suaGiaBan.Size = new Size(170, 31);
            txt_suaGiaBan.TabIndex = 53;
            txt_suaGiaBan.TextChanged += txt_suaGiaBan_TextChanged;
            // 
            // txt_suaGiaMua
            // 
            txt_suaGiaMua.BackColor = Color.FromArgb(226, 199, 153);
            txt_suaGiaMua.Location = new Point(997, 601);
            txt_suaGiaMua.Name = "txt_suaGiaMua";
            txt_suaGiaMua.Size = new Size(170, 31);
            txt_suaGiaMua.TabIndex = 52;
            txt_suaGiaMua.TextChanged += txt_suaGiaMua_TextChanged;
            // 
            // txt_suaTenBanh
            // 
            txt_suaTenBanh.BackColor = Color.FromArgb(226, 199, 153);
            txt_suaTenBanh.Location = new Point(997, 564);
            txt_suaTenBanh.Name = "txt_suaTenBanh";
            txt_suaTenBanh.Size = new Size(170, 31);
            txt_suaTenBanh.TabIndex = 51;
            txt_suaTenBanh.TextChanged += txt_suaTenBanh_TextChanged;
            // 
            // lb_suaDonVi
            // 
            lb_suaDonVi.AutoSize = true;
            lb_suaDonVi.BackColor = Color.FromArgb(226, 199, 153);
            lb_suaDonVi.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_suaDonVi.ForeColor = Color.FromArgb(154, 59, 59);
            lb_suaDonVi.Location = new Point(715, 573);
            lb_suaDonVi.Name = "lb_suaDonVi";
            lb_suaDonVi.Size = new Size(76, 22);
            lb_suaDonVi.TabIndex = 50;
            lb_suaDonVi.Text = "Đơn Vị";
            lb_suaDonVi.Click += lb_suaDonVi_Click;
            // 
            // lb_suaLoaiBanh
            // 
            lb_suaLoaiBanh.AutoSize = true;
            lb_suaLoaiBanh.BackColor = Color.FromArgb(226, 199, 153);
            lb_suaLoaiBanh.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_suaLoaiBanh.ForeColor = Color.FromArgb(154, 59, 59);
            lb_suaLoaiBanh.Location = new Point(882, 684);
            lb_suaLoaiBanh.Name = "lb_suaLoaiBanh";
            lb_suaLoaiBanh.Size = new Size(109, 22);
            lb_suaLoaiBanh.TabIndex = 49;
            lb_suaLoaiBanh.Text = "Loại Bánh";
            lb_suaLoaiBanh.Click += lb_suaLoaiBanh_Click;
            // 
            // lb_suaGiaBan
            // 
            lb_suaGiaBan.AutoSize = true;
            lb_suaGiaBan.BackColor = Color.FromArgb(226, 199, 153);
            lb_suaGiaBan.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_suaGiaBan.ForeColor = Color.FromArgb(154, 59, 59);
            lb_suaGiaBan.Location = new Point(900, 647);
            lb_suaGiaBan.Name = "lb_suaGiaBan";
            lb_suaGiaBan.Size = new Size(88, 22);
            lb_suaGiaBan.TabIndex = 48;
            lb_suaGiaBan.Text = "Giá Bán";
            lb_suaGiaBan.Click += lb_suaGiaBan_Click;
            // 
            // lb_suaGiaMua
            // 
            lb_suaGiaMua.AutoSize = true;
            lb_suaGiaMua.BackColor = Color.FromArgb(226, 199, 153);
            lb_suaGiaMua.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_suaGiaMua.ForeColor = Color.FromArgb(154, 59, 59);
            lb_suaGiaMua.Location = new Point(897, 610);
            lb_suaGiaMua.Name = "lb_suaGiaMua";
            lb_suaGiaMua.Size = new Size(91, 22);
            lb_suaGiaMua.TabIndex = 47;
            lb_suaGiaMua.Text = "Giá Mua";
            lb_suaGiaMua.Click += lb_suaGiaMua_Click;
            // 
            // lb_suaTenBanh
            // 
            lb_suaTenBanh.AutoSize = true;
            lb_suaTenBanh.BackColor = Color.FromArgb(226, 199, 153);
            lb_suaTenBanh.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_suaTenBanh.ForeColor = Color.FromArgb(154, 59, 59);
            lb_suaTenBanh.Location = new Point(886, 573);
            lb_suaTenBanh.Name = "lb_suaTenBanh";
            lb_suaTenBanh.Size = new Size(105, 22);
            lb_suaTenBanh.TabIndex = 46;
            lb_suaTenBanh.Text = "Tên Bánh";
            lb_suaTenBanh.Click += lb_suaTenBanh_Click;
            // 
            // lb_suaBanh
            // 
            lb_suaBanh.AutoSize = true;
            lb_suaBanh.BackColor = Color.FromArgb(226, 199, 153);
            lb_suaBanh.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_suaBanh.ForeColor = Color.FromArgb(154, 59, 59);
            lb_suaBanh.Location = new Point(897, 519);
            lb_suaBanh.Name = "lb_suaBanh";
            lb_suaBanh.Size = new Size(107, 22);
            lb_suaBanh.TabIndex = 45;
            lb_suaBanh.Text = "Sửa Bánh";
            lb_suaBanh.Click += lb_suaBanh_Click;
            // 
            // txt_themDonVi
            // 
            txt_themDonVi.BackColor = Color.FromArgb(226, 199, 153);
            txt_themDonVi.Location = new Point(392, 560);
            txt_themDonVi.Name = "txt_themDonVi";
            txt_themDonVi.Size = new Size(83, 31);
            txt_themDonVi.TabIndex = 44;
            txt_themDonVi.TextChanged += txt_themDonVi_TextChanged;
            // 
            // txt_themLoaiBanh
            // 
            txt_themLoaiBanh.BackColor = Color.FromArgb(226, 199, 153);
            txt_themLoaiBanh.Location = new Point(134, 671);
            txt_themLoaiBanh.Name = "txt_themLoaiBanh";
            txt_themLoaiBanh.Size = new Size(170, 31);
            txt_themLoaiBanh.TabIndex = 43;
            txt_themLoaiBanh.TextChanged += txt_themLoaiBanh_TextChanged;
            // 
            // txt_themGiaBan
            // 
            txt_themGiaBan.BackColor = Color.FromArgb(226, 199, 153);
            txt_themGiaBan.Location = new Point(134, 634);
            txt_themGiaBan.Name = "txt_themGiaBan";
            txt_themGiaBan.Size = new Size(170, 31);
            txt_themGiaBan.TabIndex = 42;
            txt_themGiaBan.TextChanged += txt_themGiaBan_TextChanged;
            // 
            // txt_themGiaMua
            // 
            txt_themGiaMua.BackColor = Color.FromArgb(226, 199, 153);
            txt_themGiaMua.Location = new Point(134, 597);
            txt_themGiaMua.Name = "txt_themGiaMua";
            txt_themGiaMua.Size = new Size(170, 31);
            txt_themGiaMua.TabIndex = 41;
            txt_themGiaMua.TextChanged += txt_themGiaMua_TextChanged;
            // 
            // txt_themTenBanh
            // 
            txt_themTenBanh.BackColor = Color.FromArgb(226, 199, 153);
            txt_themTenBanh.Location = new Point(134, 560);
            txt_themTenBanh.Name = "txt_themTenBanh";
            txt_themTenBanh.Size = new Size(170, 31);
            txt_themTenBanh.TabIndex = 40;
            txt_themTenBanh.TextChanged += txt_themTenBanh_TextChanged;
            // 
            // lb_themDonVi
            // 
            lb_themDonVi.AutoSize = true;
            lb_themDonVi.BackColor = Color.FromArgb(226, 199, 153);
            lb_themDonVi.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_themDonVi.ForeColor = Color.FromArgb(154, 59, 59);
            lb_themDonVi.Location = new Point(310, 569);
            lb_themDonVi.Name = "lb_themDonVi";
            lb_themDonVi.Size = new Size(76, 22);
            lb_themDonVi.TabIndex = 39;
            lb_themDonVi.Text = "Đơn Vị";
            lb_themDonVi.Click += lb_themDonVi_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(226, 199, 153);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(226, 199, 153);
            dataGridViewCellStyle1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { column_loaiBanh, column_ma, column_tenBanh, column_donVi, column_giaMua, column_giaBan, column_hien });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(226, 199, 153);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = Color.FromArgb(154, 59, 59);
            dataGridView1.Location = new Point(3, 111);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(226, 199, 153);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1183, 375);
            dataGridView1.TabIndex = 33;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // btn_inDanhSach
            // 
            btn_inDanhSach.BackColor = Color.FromArgb(226, 199, 153);
            btn_inDanhSach.FlatStyle = FlatStyle.Flat;
            btn_inDanhSach.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_inDanhSach.ForeColor = Color.FromArgb(154, 59, 59);
            btn_inDanhSach.Location = new Point(798, 56);
            btn_inDanhSach.Margin = new Padding(4, 5, 4, 5);
            btn_inDanhSach.Name = "btn_inDanhSach";
            btn_inDanhSach.Size = new Size(153, 37);
            btn_inDanhSach.TabIndex = 32;
            btn_inDanhSach.Text = "In Danh Sách";
            btn_inDanhSach.UseVisualStyleBackColor = false;
            btn_inDanhSach.Click += btn_inDanhSach_Click;
            // 
            // btn_xuatExcel
            // 
            btn_xuatExcel.BackColor = Color.FromArgb(226, 199, 153);
            btn_xuatExcel.FlatStyle = FlatStyle.Flat;
            btn_xuatExcel.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_xuatExcel.ForeColor = Color.FromArgb(154, 59, 59);
            btn_xuatExcel.Location = new Point(959, 56);
            btn_xuatExcel.Margin = new Padding(4, 5, 4, 5);
            btn_xuatExcel.Name = "btn_xuatExcel";
            btn_xuatExcel.Size = new Size(153, 37);
            btn_xuatExcel.TabIndex = 31;
            btn_xuatExcel.Text = "Xuất Excel";
            btn_xuatExcel.UseVisualStyleBackColor = false;
            btn_xuatExcel.Click += btn_xuatExcel_Click;
            // 
            // btn_timKiem
            // 
            btn_timKiem.BackColor = Color.FromArgb(226, 199, 153);
            btn_timKiem.FlatStyle = FlatStyle.Flat;
            btn_timKiem.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_timKiem.ForeColor = Color.FromArgb(154, 59, 59);
            btn_timKiem.Location = new Point(202, 56);
            btn_timKiem.Margin = new Padding(4, 5, 4, 5);
            btn_timKiem.Name = "btn_timKiem";
            btn_timKiem.Size = new Size(153, 37);
            btn_timKiem.TabIndex = 30;
            btn_timKiem.Text = "Tìm Kiếm";
            btn_timKiem.UseVisualStyleBackColor = false;
            btn_timKiem.Click += btn_timKiem_Click;
            // 
            // lb_danhMucBanh
            // 
            lb_danhMucBanh.AutoSize = true;
            lb_danhMucBanh.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_danhMucBanh.ForeColor = Color.FromArgb(154, 59, 59);
            lb_danhMucBanh.Location = new Point(505, 28);
            lb_danhMucBanh.Margin = new Padding(4, 0, 4, 0);
            lb_danhMucBanh.Name = "lb_danhMucBanh";
            lb_danhMucBanh.Size = new Size(211, 28);
            lb_danhMucBanh.TabIndex = 29;
            lb_danhMucBanh.Text = "Danh Mục Bánh";
            lb_danhMucBanh.Click += lb_danhMucBanh_Click;
            // 
            // lb_themLoaiBanh
            // 
            lb_themLoaiBanh.AutoSize = true;
            lb_themLoaiBanh.BackColor = Color.FromArgb(226, 199, 153);
            lb_themLoaiBanh.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_themLoaiBanh.ForeColor = Color.FromArgb(154, 59, 59);
            lb_themLoaiBanh.Location = new Point(19, 680);
            lb_themLoaiBanh.Name = "lb_themLoaiBanh";
            lb_themLoaiBanh.Size = new Size(109, 22);
            lb_themLoaiBanh.TabIndex = 38;
            lb_themLoaiBanh.Text = "Loại Bánh";
            lb_themLoaiBanh.Click += lb_themLoaiBanh_Click;
            // 
            // lb_themGiaMua
            // 
            lb_themGiaMua.AutoSize = true;
            lb_themGiaMua.BackColor = Color.FromArgb(226, 199, 153);
            lb_themGiaMua.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_themGiaMua.ForeColor = Color.FromArgb(154, 59, 59);
            lb_themGiaMua.Location = new Point(34, 606);
            lb_themGiaMua.Name = "lb_themGiaMua";
            lb_themGiaMua.Size = new Size(91, 22);
            lb_themGiaMua.TabIndex = 36;
            lb_themGiaMua.Text = "Giá Mua";
            lb_themGiaMua.Click += lb_themGiaMua_Click;
            // 
            // lb_themTenBanh
            // 
            lb_themTenBanh.AutoSize = true;
            lb_themTenBanh.BackColor = Color.FromArgb(226, 199, 153);
            lb_themTenBanh.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_themTenBanh.ForeColor = Color.FromArgb(154, 59, 59);
            lb_themTenBanh.Location = new Point(23, 569);
            lb_themTenBanh.Name = "lb_themTenBanh";
            lb_themTenBanh.Size = new Size(105, 22);
            lb_themTenBanh.TabIndex = 35;
            lb_themTenBanh.Text = "Tên Bánh";
            lb_themTenBanh.Click += lb_themTenBanh_Click;
            // 
            // lb_themBanh
            // 
            lb_themBanh.AutoSize = true;
            lb_themBanh.BackColor = Color.FromArgb(226, 199, 153);
            lb_themBanh.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_themBanh.ForeColor = Color.FromArgb(154, 59, 59);
            lb_themBanh.Location = new Point(134, 515);
            lb_themBanh.Name = "lb_themBanh";
            lb_themBanh.Size = new Size(124, 22);
            lb_themBanh.TabIndex = 34;
            lb_themBanh.Text = "Thêm Bánh";
            lb_themBanh.Click += lb_themBanh_Click;
            // 
            // lb_themGiaBan
            // 
            lb_themGiaBan.AutoSize = true;
            lb_themGiaBan.BackColor = Color.FromArgb(226, 199, 153);
            lb_themGiaBan.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_themGiaBan.ForeColor = Color.FromArgb(154, 59, 59);
            lb_themGiaBan.Location = new Point(37, 643);
            lb_themGiaBan.Name = "lb_themGiaBan";
            lb_themGiaBan.Size = new Size(88, 22);
            lb_themGiaBan.TabIndex = 37;
            lb_themGiaBan.Text = "Giá Bán";
            lb_themGiaBan.Click += lb_themGiaBan_Click;
            // 
            // DanhMucBanh
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 236, 190);
            ClientSize = new Size(1187, 713);
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
            Controls.Add(dataGridView1);
            Controls.Add(btn_inDanhSach);
            Controls.Add(btn_xuatExcel);
            Controls.Add(btn_timKiem);
            Controls.Add(lb_danhMucBanh);
            Controls.Add(lb_themLoaiBanh);
            Controls.Add(lb_themGiaMua);
            Controls.Add(lb_themTenBanh);
            Controls.Add(lb_themBanh);
            Controls.Add(lb_themGiaBan);
            Name = "DanhMucBanh";
            Text = "Danh Mục Bánh";
            Load += GetDanhMucBanh_Load();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private EventHandler GetDanhMucBanh_Load()
        {
            return null;
        }

        #endregion

        private Button btn_sua;
        private Button btn_them;
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
        private TextBox txt_themDonVi;
        private TextBox txt_themLoaiBanh;
        private TextBox txt_themGiaBan;
        private TextBox txt_themGiaMua;
        private TextBox txt_themTenBanh;
        private Label lb_themDonVi;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn column_loaiBanh;
        private DataGridViewTextBoxColumn column_ma;
        private DataGridViewTextBoxColumn column_tenBanh;
        private DataGridViewTextBoxColumn column_donVi;
        private DataGridViewTextBoxColumn column_giaMua;
        private DataGridViewTextBoxColumn column_giaBan;
        private DataGridViewCheckBoxColumn column_hien;
        private Button btn_inDanhSach;
        private Button btn_xuatExcel;
        private Button btn_timKiem;
        private Label lb_danhMucBanh;
        private Label lb_themLoaiBanh;
        private Label lb_themGiaMua;
        private Label lb_themTenBanh;
        private Label lb_themBanh;
        private Label lb_themGiaBan;
    }
}