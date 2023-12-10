namespace ABC_bakery.export_cakes
{
    partial class FormThemPhieuXuatKhac
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            this.label11 = new System.Windows.Forms.Label();
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.categoriesName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.promotion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total_amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnHoanThanh = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_tongTienHang = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txt_tongSoLuong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_ghiChu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_thanhTien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_tenKhachHang = new System.Windows.Forms.TextBox();
            this.comboBox_maGiam = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_loaiBanh = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_tenBanh = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTon = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(584, 625);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(211, 29);
            this.label11.TabIndex = 99;
            this.label11.Text = "Tổng số lượng:";
            // 
            // listViewProducts
            // 
            this.listViewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.categoriesName,
            this.id,
            this.name,
            this.amount,
            this.total,
            this.price,
            this.promotion,
            this.total_amount,
            this.customer});
            this.listViewProducts.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewProducts.HideSelection = false;
            this.listViewProducts.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.listViewProducts.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.listViewProducts.Location = new System.Drawing.Point(52, 320);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(1304, 221);
            this.listViewProducts.TabIndex = 92;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            this.listViewProducts.View = System.Windows.Forms.View.Details;
            this.listViewProducts.SelectedIndexChanged += new System.EventHandler(this.listViewProducts_SelectedIndexChanged);
            // 
            // categoriesName
            // 
            this.categoriesName.Text = "Loại";
            this.categoriesName.Width = 114;
            // 
            // id
            // 
            this.id.Text = "Mã";
            this.id.Width = 54;
            // 
            // name
            // 
            this.name.Text = "Tên bánh";
            this.name.Width = 189;
            // 
            // amount
            // 
            this.amount.Text = "Tồn";
            // 
            // total
            // 
            this.total.Text = "Số lượng";
            this.total.Width = 99;
            // 
            // price
            // 
            this.price.Text = "Giá";
            this.price.Width = 90;
            // 
            // promotion
            // 
            this.promotion.Text = "Giảm";
            // 
            // total_amount
            // 
            this.total_amount.Text = "Thành tiền";
            this.total_amount.Width = 128;
            // 
            // customer
            // 
            this.customer.Text = "Khách hàng";
            this.customer.Width = 83;
            // 
            // btnHoanThanh
            // 
            this.btnHoanThanh.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanThanh.Location = new System.Drawing.Point(1213, 572);
            this.btnHoanThanh.Name = "btnHoanThanh";
            this.btnHoanThanh.Size = new System.Drawing.Size(143, 94);
            this.btnHoanThanh.TabIndex = 97;
            this.btnHoanThanh.Text = "OK";
            this.btnHoanThanh.UseVisualStyleBackColor = true;
            this.btnHoanThanh.Click += new System.EventHandler(this.btnHoanThanh_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(584, 575);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(224, 29);
            this.label10.TabIndex = 96;
            this.label10.Text = "Tổng tiền hàng:";
            // 
            // txt_tongTienHang
            // 
            this.txt_tongTienHang.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongTienHang.Location = new System.Drawing.Point(814, 572);
            this.txt_tongTienHang.Multiline = true;
            this.txt_tongTienHang.Name = "txt_tongTienHang";
            this.txt_tongTienHang.Size = new System.Drawing.Size(280, 44);
            this.txt_tongTienHang.TabIndex = 95;
            this.txt_tongTienHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(1213, 201);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(143, 79);
            this.btnSua.TabIndex = 94;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(1213, 116);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(143, 79);
            this.btnXoa.TabIndex = 93;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txt_tongSoLuong
            // 
            this.txt_tongSoLuong.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongSoLuong.Location = new System.Drawing.Point(814, 622);
            this.txt_tongSoLuong.Multiline = true;
            this.txt_tongSoLuong.Name = "txt_tongSoLuong";
            this.txt_tongSoLuong.Size = new System.Drawing.Size(280, 44);
            this.txt_tongSoLuong.TabIndex = 98;
            this.txt_tongSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(77, 622);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 29);
            this.label9.TabIndex = 91;
            this.label9.Text = "Ghi chú:";
            // 
            // txt_ghiChu
            // 
            this.txt_ghiChu.Location = new System.Drawing.Point(213, 572);
            this.txt_ghiChu.Multiline = true;
            this.txt_ghiChu.Name = "txt_ghiChu";
            this.txt_ghiChu.Size = new System.Drawing.Size(280, 94);
            this.txt_ghiChu.TabIndex = 90;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(641, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 29);
            this.label8.TabIndex = 89;
            this.label8.Text = "Thành tiền:";
            // 
            // txt_thanhTien
            // 
            this.txt_thanhTien.Location = new System.Drawing.Point(814, 259);
            this.txt_thanhTien.Name = "txt_thanhTien";
            this.txt_thanhTien.Size = new System.Drawing.Size(280, 26);
            this.txt_thanhTien.TabIndex = 88;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(574, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 29);
            this.label7.TabIndex = 87;
            this.label7.Text = "Tên khách hàng:";
            // 
            // txt_tenKhachHang
            // 
            this.txt_tenKhachHang.Location = new System.Drawing.Point(814, 183);
            this.txt_tenKhachHang.Name = "txt_tenKhachHang";
            this.txt_tenKhachHang.Size = new System.Drawing.Size(280, 26);
            this.txt_tenKhachHang.TabIndex = 86;
            // 
            // comboBox_maGiam
            // 
            this.comboBox_maGiam.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_maGiam.FormattingEnabled = true;
            this.comboBox_maGiam.Location = new System.Drawing.Point(814, 31);
            this.comboBox_maGiam.Name = "comboBox_maGiam";
            this.comboBox_maGiam.Size = new System.Drawing.Size(280, 33);
            this.comboBox_maGiam.TabIndex = 85;
            this.comboBox_maGiam.SelectedIndexChanged += new System.EventHandler(this.comboBox_maGiam_SelectedIndexChanged);
            this.comboBox_maGiam.TextUpdate += new System.EventHandler(this.comboBox_maGiam_TextUpdate);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(669, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 29);
            this.label6.TabIndex = 84;
            this.label6.Text = "Mã Giảm:";
            // 
            // comboBox_loaiBanh
            // 
            this.comboBox_loaiBanh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_loaiBanh.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_loaiBanh.FormattingEnabled = true;
            this.comboBox_loaiBanh.Location = new System.Drawing.Point(213, 31);
            this.comboBox_loaiBanh.Name = "comboBox_loaiBanh";
            this.comboBox_loaiBanh.Size = new System.Drawing.Size(280, 33);
            this.comboBox_loaiBanh.Sorted = true;
            this.comboBox_loaiBanh.TabIndex = 83;
            this.comboBox_loaiBanh.SelectedIndexChanged += new System.EventHandler(this.comboBox_loaiBanh_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(47, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 29);
            this.label5.TabIndex = 82;
            this.label5.Text = "Loại bánh:";
            // 
            // comboBox_tenBanh
            // 
            this.comboBox_tenBanh.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_tenBanh.FormattingEnabled = true;
            this.comboBox_tenBanh.Location = new System.Drawing.Point(213, 104);
            this.comboBox_tenBanh.Name = "comboBox_tenBanh";
            this.comboBox_tenBanh.Size = new System.Drawing.Size(280, 33);
            this.comboBox_tenBanh.TabIndex = 81;
            this.comboBox_tenBanh.SelectedIndexChanged += new System.EventHandler(this.comboBox_tenBanh_SelectedIndexChanged);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(1213, 31);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(143, 79);
            this.btnThem.TabIndex = 80;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(128, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 29);
            this.label4.TabIndex = 79;
            this.label4.Text = "Tồn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(669, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 29);
            this.label3.TabIndex = 78;
            this.label3.Text = "Số lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(134, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 29);
            this.label2.TabIndex = 77;
            this.label2.Text = "Giá:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(53, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 76;
            this.label1.Text = "Tên bánh:";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(213, 259);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(280, 26);
            this.txtGia.TabIndex = 75;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(814, 104);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(280, 26);
            this.txtSoLuong.TabIndex = 74;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // txtTon
            // 
            this.txtTon.Location = new System.Drawing.Point(213, 178);
            this.txtTon.Name = "txtTon";
            this.txtTon.Size = new System.Drawing.Size(280, 26);
            this.txtTon.TabIndex = 73;
            // 
            // FormThemPhieuXuatKhac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1403, 696);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.listViewProducts);
            this.Controls.Add(this.btnHoanThanh);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_tongTienHang);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txt_tongSoLuong);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_ghiChu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_thanhTien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_tenKhachHang);
            this.Controls.Add(this.comboBox_maGiam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_loaiBanh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_tenBanh);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtTon);
            this.Name = "FormThemPhieuXuatKhac";
            this.Text = "Thêm Phiếu Xuất Khác";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.ListView listViewProducts;
        private System.Windows.Forms.ColumnHeader categoriesName;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.ColumnHeader total;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader promotion;
        private System.Windows.Forms.ColumnHeader total_amount;
        private System.Windows.Forms.ColumnHeader customer;
        private System.Windows.Forms.Button btnHoanThanh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_tongTienHang;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txt_tongSoLuong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ghiChu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_thanhTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_tenKhachHang;
        private System.Windows.Forms.ComboBox comboBox_maGiam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_loaiBanh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_tenBanh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTon;
    }
}