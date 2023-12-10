using System.Drawing;
using System.Windows.Forms;

namespace ABC_bakery.category
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_danhMucBanh = new System.Windows.Forms.Label();
            this.btn_timKiem = new System.Windows.Forms.Button();
            this.btn_xuatExcel = new System.Windows.Forms.Button();
            this.btn_inDanhSach = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.categories_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_bought = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_sell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txt_suaDonVi = new System.Windows.Forms.TextBox();
            this.txt_suaLoaiBanh = new System.Windows.Forms.TextBox();
            this.txt_suaGiaBan = new System.Windows.Forms.TextBox();
            this.txt_suaGiaMua = new System.Windows.Forms.TextBox();
            this.txt_suaTenBanh = new System.Windows.Forms.TextBox();
            this.lb_suaDonVi = new System.Windows.Forms.Label();
            this.lb_suaLoaiBanh = new System.Windows.Forms.Label();
            this.lb_suaGiaBan = new System.Windows.Forms.Label();
            this.lb_suaGiaMua = new System.Windows.Forms.Label();
            this.lb_suaTenBanh = new System.Windows.Forms.Label();
            this.lb_suaBanh = new System.Windows.Forms.Label();
            this.btn_sua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_danhMucBanh
            // 
            this.lb_danhMucBanh.AutoSize = true;
            this.lb_danhMucBanh.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.lb_danhMucBanh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lb_danhMucBanh.Location = new System.Drawing.Point(426, 12);
            this.lb_danhMucBanh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_danhMucBanh.Name = "lb_danhMucBanh";
            this.lb_danhMucBanh.Size = new System.Drawing.Size(211, 28);
            this.lb_danhMucBanh.TabIndex = 0;
            this.lb_danhMucBanh.Text = "Danh Mục Bánh";
            // 
            // btn_timKiem
            // 
            this.btn_timKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.btn_timKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timKiem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btn_timKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_timKiem.Location = new System.Drawing.Point(174, 41);
            this.btn_timKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_timKiem.Name = "btn_timKiem";
            this.btn_timKiem.Size = new System.Drawing.Size(138, 30);
            this.btn_timKiem.TabIndex = 1;
            this.btn_timKiem.Text = "Tìm Kiếm";
            this.btn_timKiem.UseVisualStyleBackColor = false;
            // 
            // btn_xuatExcel
            // 
            this.btn_xuatExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.btn_xuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xuatExcel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btn_xuatExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_xuatExcel.Location = new System.Drawing.Point(1069, 41);
            this.btn_xuatExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xuatExcel.Name = "btn_xuatExcel";
            this.btn_xuatExcel.Size = new System.Drawing.Size(210, 36);
            this.btn_xuatExcel.TabIndex = 2;
            this.btn_xuatExcel.Text = "Xuất Excel";
            this.btn_xuatExcel.UseVisualStyleBackColor = false;
            // 
            // btn_inDanhSach
            // 
            this.btn_inDanhSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.btn_inDanhSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inDanhSach.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btn_inDanhSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_inDanhSach.Location = new System.Drawing.Point(792, 41);
            this.btn_inDanhSach.Margin = new System.Windows.Forms.Padding(4);
            this.btn_inDanhSach.Name = "btn_inDanhSach";
            this.btn_inDanhSach.Size = new System.Drawing.Size(240, 36);
            this.btn_inDanhSach.TabIndex = 3;
            this.btn_inDanhSach.Text = "In Danh Sách";
            this.btn_inDanhSach.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categories_name,
            this.id,
            this.name,
            this.price_bought,
            this.price_sell,
            this.is_active});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.dataGridView1.Location = new System.Drawing.Point(-5, 85);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1445, 438);
            this.dataGridView1.TabIndex = 4;
            // 
            // categories_name
            // 
            this.categories_name.FillWeight = 200F;
            this.categories_name.HeaderText = "Loại Bánh";
            this.categories_name.MinimumWidth = 8;
            this.categories_name.Name = "categories_name";
            this.categories_name.Width = 200;
            // 
            // id
            // 
            this.id.HeaderText = "Mã";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Width = 150;
            // 
            // name
            // 
            this.name.HeaderText = "Tên Bánh";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.Width = 200;
            // 
            // price_bought
            // 
            this.price_bought.HeaderText = "Giá Mua";
            this.price_bought.MinimumWidth = 8;
            this.price_bought.Name = "price_bought";
            this.price_bought.Width = 150;
            // 
            // price_sell
            // 
            this.price_sell.HeaderText = "Giá Bán";
            this.price_sell.MinimumWidth = 8;
            this.price_sell.Name = "price_sell";
            this.price_sell.Width = 150;
            // 
            // is_active
            // 
            this.is_active.HeaderText = "Hiện";
            this.is_active.MinimumWidth = 8;
            this.is_active.Name = "is_active";
            this.is_active.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.is_active.Width = 50;
            // 
            // txt_suaDonVi
            // 
            this.txt_suaDonVi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.txt_suaDonVi.Location = new System.Drawing.Point(892, 565);
            this.txt_suaDonVi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_suaDonVi.Name = "txt_suaDonVi";
            this.txt_suaDonVi.Size = new System.Drawing.Size(83, 26);
            this.txt_suaDonVi.TabIndex = 26;
            // 
            // txt_suaLoaiBanh
            // 
            this.txt_suaLoaiBanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.txt_suaLoaiBanh.Location = new System.Drawing.Point(1118, 653);
            this.txt_suaLoaiBanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_suaLoaiBanh.Name = "txt_suaLoaiBanh";
            this.txt_suaLoaiBanh.Size = new System.Drawing.Size(273, 26);
            this.txt_suaLoaiBanh.TabIndex = 25;
            // 
            // txt_suaGiaBan
            // 
            this.txt_suaGiaBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.txt_suaGiaBan.Location = new System.Drawing.Point(1118, 623);
            this.txt_suaGiaBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_suaGiaBan.Name = "txt_suaGiaBan";
            this.txt_suaGiaBan.Size = new System.Drawing.Size(273, 26);
            this.txt_suaGiaBan.TabIndex = 24;
            // 
            // txt_suaGiaMua
            // 
            this.txt_suaGiaMua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.txt_suaGiaMua.Location = new System.Drawing.Point(1118, 594);
            this.txt_suaGiaMua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_suaGiaMua.Name = "txt_suaGiaMua";
            this.txt_suaGiaMua.Size = new System.Drawing.Size(273, 26);
            this.txt_suaGiaMua.TabIndex = 23;
            // 
            // txt_suaTenBanh
            // 
            this.txt_suaTenBanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.txt_suaTenBanh.Location = new System.Drawing.Point(1118, 564);
            this.txt_suaTenBanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_suaTenBanh.Name = "txt_suaTenBanh";
            this.txt_suaTenBanh.Size = new System.Drawing.Size(273, 26);
            this.txt_suaTenBanh.TabIndex = 22;
            // 
            // lb_suaDonVi
            // 
            this.lb_suaDonVi.AutoSize = true;
            this.lb_suaDonVi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.lb_suaDonVi.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lb_suaDonVi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lb_suaDonVi.Location = new System.Drawing.Point(797, 569);
            this.lb_suaDonVi.Name = "lb_suaDonVi";
            this.lb_suaDonVi.Size = new System.Drawing.Size(76, 22);
            this.lb_suaDonVi.TabIndex = 21;
            this.lb_suaDonVi.Text = "Đơn Vị";
            // 
            // lb_suaLoaiBanh
            // 
            this.lb_suaLoaiBanh.AutoSize = true;
            this.lb_suaLoaiBanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.lb_suaLoaiBanh.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lb_suaLoaiBanh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lb_suaLoaiBanh.Location = new System.Drawing.Point(978, 654);
            this.lb_suaLoaiBanh.Name = "lb_suaLoaiBanh";
            this.lb_suaLoaiBanh.Size = new System.Drawing.Size(109, 22);
            this.lb_suaLoaiBanh.TabIndex = 20;
            this.lb_suaLoaiBanh.Text = "Loại Bánh";
            // 
            // lb_suaGiaBan
            // 
            this.lb_suaGiaBan.AutoSize = true;
            this.lb_suaGiaBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.lb_suaGiaBan.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lb_suaGiaBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lb_suaGiaBan.Location = new System.Drawing.Point(994, 624);
            this.lb_suaGiaBan.Name = "lb_suaGiaBan";
            this.lb_suaGiaBan.Size = new System.Drawing.Size(88, 22);
            this.lb_suaGiaBan.TabIndex = 19;
            this.lb_suaGiaBan.Text = "Giá Bán";
            // 
            // lb_suaGiaMua
            // 
            this.lb_suaGiaMua.AutoSize = true;
            this.lb_suaGiaMua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.lb_suaGiaMua.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lb_suaGiaMua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lb_suaGiaMua.Location = new System.Drawing.Point(991, 595);
            this.lb_suaGiaMua.Name = "lb_suaGiaMua";
            this.lb_suaGiaMua.Size = new System.Drawing.Size(91, 22);
            this.lb_suaGiaMua.TabIndex = 18;
            this.lb_suaGiaMua.Text = "Giá Mua";
            // 
            // lb_suaTenBanh
            // 
            this.lb_suaTenBanh.AutoSize = true;
            this.lb_suaTenBanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.lb_suaTenBanh.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lb_suaTenBanh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lb_suaTenBanh.Location = new System.Drawing.Point(981, 565);
            this.lb_suaTenBanh.Name = "lb_suaTenBanh";
            this.lb_suaTenBanh.Size = new System.Drawing.Size(105, 22);
            this.lb_suaTenBanh.TabIndex = 17;
            this.lb_suaTenBanh.Text = "Tên Bánh";
            // 
            // lb_suaBanh
            // 
            this.lb_suaBanh.AutoSize = true;
            this.lb_suaBanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.lb_suaBanh.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lb_suaBanh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lb_suaBanh.Location = new System.Drawing.Point(1114, 527);
            this.lb_suaBanh.Name = "lb_suaBanh";
            this.lb_suaBanh.Size = new System.Drawing.Size(107, 22);
            this.lb_suaBanh.TabIndex = 16;
            this.lb_suaBanh.Text = "Sửa Bánh";
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sua.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.btn_sua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_sua.Location = new System.Drawing.Point(801, 608);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(130, 64);
            this.btn_sua.TabIndex = 28;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            // 
            // form_danhMucBanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(1438, 709);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.txt_suaDonVi);
            this.Controls.Add(this.txt_suaLoaiBanh);
            this.Controls.Add(this.txt_suaGiaBan);
            this.Controls.Add(this.txt_suaGiaMua);
            this.Controls.Add(this.txt_suaTenBanh);
            this.Controls.Add(this.lb_suaDonVi);
            this.Controls.Add(this.lb_suaLoaiBanh);
            this.Controls.Add(this.lb_suaGiaBan);
            this.Controls.Add(this.lb_suaGiaMua);
            this.Controls.Add(this.lb_suaTenBanh);
            this.Controls.Add(this.lb_suaBanh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_inDanhSach);
            this.Controls.Add(this.btn_xuatExcel);
            this.Controls.Add(this.btn_timKiem);
            this.Controls.Add(this.lb_danhMucBanh);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_danhMucBanh";
            this.Text = "Danh Mục Bánh";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_danhMucBanh;
        private Button btn_timKiem;
        private Button btn_xuatExcel;
        private Button btn_inDanhSach;
        private DataGridView dataGridView1;
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
        private Button btn_sua;
        private DataGridViewTextBoxColumn categories_name;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn price_bought;
        private DataGridViewTextBoxColumn price_sell;
        private DataGridViewCheckBoxColumn is_active;
    }
}