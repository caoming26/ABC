﻿using System.Drawing;
using System.Windows.Forms;

namespace ABC_bakery.export_cakes
{
    partial class form_XuatKhac
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_maPhieu = new System.Windows.Forms.Label();
            this.btn_doiNgay = new System.Windows.Forms.Button();
            this.btn_xoaPhieu = new System.Windows.Forms.Button();
            this.btn_themPhieu = new System.Windows.Forms.Button();
            this.txt_ghiChu = new System.Windows.Forms.TextBox();
            this.txt_tongSoLuong = new System.Windows.Forms.TextBox();
            this.txt_tongTienHang = new System.Windows.Forms.TextBox();
            this.lb_ghiChu = new System.Windows.Forms.Label();
            this.lb_tongSoLuong = new System.Windows.Forms.Label();
            this.btn_in = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btn_after = new System.Windows.Forms.Button();
            this.btn_before = new System.Windows.Forms.Button();
            this.txt_xuatCho = new System.Windows.Forms.TextBox();
            this.txt_maPhieu = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lb_xuatCho = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lb_ngay = new System.Windows.Forms.Label();
            this.btn_luuGhiChu = new System.Windows.Forms.Button();
            this.lb_PhieuXuatDi = new System.Windows.Forms.Label();
            this.lb_tongTienHang = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_maPhieu
            // 
            this.lb_maPhieu.AutoSize = true;
            this.lb_maPhieu.Font = new System.Drawing.Font("Verdana", 12F);
            this.lb_maPhieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(130)))), ((int)(((byte)(97)))));
            this.lb_maPhieu.Location = new System.Drawing.Point(90, 67);
            this.lb_maPhieu.Name = "lb_maPhieu";
            this.lb_maPhieu.Size = new System.Drawing.Size(119, 29);
            this.lb_maPhieu.TabIndex = 127;
            this.lb_maPhieu.Text = "Mã Phiếu";
            // 
            // btn_doiNgay
            // 
            this.btn_doiNgay.BackColor = System.Drawing.Color.White;
            this.btn_doiNgay.ForeColor = System.Drawing.Color.Black;
            this.btn_doiNgay.Location = new System.Drawing.Point(676, 19);
            this.btn_doiNgay.Margin = new System.Windows.Forms.Padding(4);
            this.btn_doiNgay.Name = "btn_doiNgay";
            this.btn_doiNgay.Size = new System.Drawing.Size(105, 38);
            this.btn_doiNgay.TabIndex = 148;
            this.btn_doiNgay.Text = "Đổi Ngày";
            this.btn_doiNgay.UseVisualStyleBackColor = false;
            this.btn_doiNgay.Click += new System.EventHandler(this.btn_doiNgay_Click);
            // 
            // btn_xoaPhieu
            // 
            this.btn_xoaPhieu.Location = new System.Drawing.Point(414, 576);
            this.btn_xoaPhieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoaPhieu.Name = "btn_xoaPhieu";
            this.btn_xoaPhieu.Size = new System.Drawing.Size(85, 76);
            this.btn_xoaPhieu.TabIndex = 146;
            this.btn_xoaPhieu.Text = "Xóa Phiếu";
            this.btn_xoaPhieu.UseVisualStyleBackColor = true;
            this.btn_xoaPhieu.Click += new System.EventHandler(this.btn_xoaPhieu_Click);
            // 
            // btn_themPhieu
            // 
            this.btn_themPhieu.Location = new System.Drawing.Point(302, 576);
            this.btn_themPhieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_themPhieu.Name = "btn_themPhieu";
            this.btn_themPhieu.Size = new System.Drawing.Size(85, 76);
            this.btn_themPhieu.TabIndex = 145;
            this.btn_themPhieu.Text = "Thêm Phiếu";
            this.btn_themPhieu.UseVisualStyleBackColor = true;
            this.btn_themPhieu.Click += new System.EventHandler(this.btn_themPhieu_Click);
            // 
            // txt_ghiChu
            // 
            this.txt_ghiChu.Location = new System.Drawing.Point(13, 576);
            this.txt_ghiChu.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ghiChu.Multiline = true;
            this.txt_ghiChu.Name = "txt_ghiChu";
            this.txt_ghiChu.Size = new System.Drawing.Size(170, 76);
            this.txt_ghiChu.TabIndex = 144;
            // 
            // txt_tongSoLuong
            // 
            this.txt_tongSoLuong.Location = new System.Drawing.Point(610, 493);
            this.txt_tongSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tongSoLuong.Name = "txt_tongSoLuong";
            this.txt_tongSoLuong.Size = new System.Drawing.Size(181, 26);
            this.txt_tongSoLuong.TabIndex = 143;
            this.txt_tongSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_tongTienHang
            // 
            this.txt_tongTienHang.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongTienHang.Location = new System.Drawing.Point(206, 491);
            this.txt_tongTienHang.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tongTienHang.Name = "txt_tongTienHang";
            this.txt_tongTienHang.Size = new System.Drawing.Size(181, 27);
            this.txt_tongTienHang.TabIndex = 142;
            this.txt_tongTienHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lb_ghiChu
            // 
            this.lb_ghiChu.AutoSize = true;
            this.lb_ghiChu.Font = new System.Drawing.Font("Verdana", 12F);
            this.lb_ghiChu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(130)))), ((int)(((byte)(97)))));
            this.lb_ghiChu.Location = new System.Drawing.Point(8, 524);
            this.lb_ghiChu.Name = "lb_ghiChu";
            this.lb_ghiChu.Size = new System.Drawing.Size(108, 29);
            this.lb_ghiChu.TabIndex = 141;
            this.lb_ghiChu.Text = "Ghi Chú";
            // 
            // lb_tongSoLuong
            // 
            this.lb_tongSoLuong.AutoSize = true;
            this.lb_tongSoLuong.Font = new System.Drawing.Font("Verdana", 12F);
            this.lb_tongSoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(130)))), ((int)(((byte)(97)))));
            this.lb_tongSoLuong.Location = new System.Drawing.Point(409, 488);
            this.lb_tongSoLuong.Name = "lb_tongSoLuong";
            this.lb_tongSoLuong.Size = new System.Drawing.Size(194, 29);
            this.lb_tongSoLuong.TabIndex = 140;
            this.lb_tongSoLuong.Text = "Tổng Số Lượng";
            // 
            // btn_in
            // 
            this.btn_in.Location = new System.Drawing.Point(530, 576);
            this.btn_in.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(85, 76);
            this.btn_in.TabIndex = 147;
            this.btn_in.Text = "In";
            this.btn_in.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ABC_bakery.Properties.Resources.bread;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(34, 58);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 38);
            this.pictureBox1.TabIndex = 129;
            this.pictureBox1.TabStop = false;
            // 
            // id
            // 
            this.id.HeaderText = "Mã";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Width = 70;
            // 
            // name
            // 
            this.name.HeaderText = "Tên Bánh";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.Width = 300;
            // 
            // amount
            // 
            this.amount.HeaderText = "Tồn";
            this.amount.MinimumWidth = 8;
            this.amount.Name = "amount";
            this.amount.Width = 70;
            // 
            // total
            // 
            this.total.HeaderText = "Số Lượng";
            this.total.MinimumWidth = 8;
            this.total.Name = "total";
            this.total.Width = 150;
            // 
            // price
            // 
            this.price.HeaderText = "Giá";
            this.price.MinimumWidth = 8;
            this.price.Name = "price";
            this.price.Width = 150;
            // 
            // total_amount
            // 
            this.total_amount.HeaderText = "Thành Tiền";
            this.total_amount.MinimumWidth = 8;
            this.total_amount.Name = "total_amount";
            this.total_amount.Width = 150;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(676, 64);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShowUpDown = true;
            this.dateTimePicker.Size = new System.Drawing.Size(213, 34);
            this.dateTimePicker.TabIndex = 149;
            // 
            // btn_after
            // 
            this.btn_after.BackgroundImage = global::ABC_bakery.Properties.Resources.rightArrow;
            this.btn_after.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_after.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btn_after.Location = new System.Drawing.Point(467, 64);
            this.btn_after.Margin = new System.Windows.Forms.Padding(4);
            this.btn_after.Name = "btn_after";
            this.btn_after.Size = new System.Drawing.Size(40, 32);
            this.btn_after.TabIndex = 137;
            this.btn_after.Text = " ";
            this.btn_after.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_after.UseVisualStyleBackColor = true;
            this.btn_after.Click += new System.EventHandler(this.btn_after_Click);
            // 
            // btn_before
            // 
            this.btn_before.BackgroundImage = global::ABC_bakery.Properties.Resources.leftArrow;
            this.btn_before.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_before.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btn_before.Location = new System.Drawing.Point(419, 65);
            this.btn_before.Margin = new System.Windows.Forms.Padding(4);
            this.btn_before.Name = "btn_before";
            this.btn_before.Size = new System.Drawing.Size(40, 32);
            this.btn_before.TabIndex = 136;
            this.btn_before.Text = " ";
            this.btn_before.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_before.UseVisualStyleBackColor = true;
            this.btn_before.Click += new System.EventHandler(this.btn_before_Click);
            // 
            // txt_xuatCho
            // 
            this.txt_xuatCho.Location = new System.Drawing.Point(1055, 72);
            this.txt_xuatCho.Margin = new System.Windows.Forms.Padding(4);
            this.txt_xuatCho.Name = "txt_xuatCho";
            this.txt_xuatCho.Size = new System.Drawing.Size(127, 26);
            this.txt_xuatCho.TabIndex = 135;
            // 
            // txt_maPhieu
            // 
            this.txt_maPhieu.Location = new System.Drawing.Point(220, 72);
            this.txt_maPhieu.Margin = new System.Windows.Forms.Padding(4);
            this.txt_maPhieu.Name = "txt_maPhieu";
            this.txt_maPhieu.Size = new System.Drawing.Size(181, 26);
            this.txt_maPhieu.TabIndex = 134;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::ABC_bakery.Properties.Resources.bread;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(804, 21);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(85, 38);
            this.pictureBox3.TabIndex = 133;
            this.pictureBox3.TabStop = false;
            // 
            // lb_xuatCho
            // 
            this.lb_xuatCho.AutoSize = true;
            this.lb_xuatCho.Font = new System.Drawing.Font("Verdana", 12F);
            this.lb_xuatCho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(130)))), ((int)(((byte)(97)))));
            this.lb_xuatCho.Location = new System.Drawing.Point(911, 69);
            this.lb_xuatCho.Name = "lb_xuatCho";
            this.lb_xuatCho.Size = new System.Drawing.Size(122, 29);
            this.lb_xuatCho.TabIndex = 132;
            this.lb_xuatCho.Text = "Xuất Cho";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ABC_bakery.Properties.Resources.bread;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(530, 64);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 38);
            this.pictureBox2.TabIndex = 131;
            this.pictureBox2.TabStop = false;
            // 
            // lb_ngay
            // 
            this.lb_ngay.AutoSize = true;
            this.lb_ngay.Font = new System.Drawing.Font("Verdana", 12F);
            this.lb_ngay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(130)))), ((int)(((byte)(97)))));
            this.lb_ngay.Location = new System.Drawing.Point(596, 69);
            this.lb_ngay.Name = "lb_ngay";
            this.lb_ngay.Size = new System.Drawing.Size(74, 29);
            this.lb_ngay.TabIndex = 130;
            this.lb_ngay.Text = "Ngày";
            // 
            // btn_luuGhiChu
            // 
            this.btn_luuGhiChu.Location = new System.Drawing.Point(190, 576);
            this.btn_luuGhiChu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_luuGhiChu.Name = "btn_luuGhiChu";
            this.btn_luuGhiChu.Size = new System.Drawing.Size(85, 76);
            this.btn_luuGhiChu.TabIndex = 128;
            this.btn_luuGhiChu.Text = "Lưu     Ghi Chú";
            this.btn_luuGhiChu.UseVisualStyleBackColor = true;
            this.btn_luuGhiChu.Click += new System.EventHandler(this.btn_luuGhiChu_Click);
            // 
            // lb_PhieuXuatDi
            // 
            this.lb_PhieuXuatDi.AutoSize = true;
            this.lb_PhieuXuatDi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lb_PhieuXuatDi.Location = new System.Drawing.Point(409, 19);
            this.lb_PhieuXuatDi.Name = "lb_PhieuXuatDi";
            this.lb_PhieuXuatDi.Size = new System.Drawing.Size(233, 29);
            this.lb_PhieuXuatDi.TabIndex = 126;
            this.lb_PhieuXuatDi.Text = "Phiếu Xuất Khác";
            // 
            // lb_tongTienHang
            // 
            this.lb_tongTienHang.AutoSize = true;
            this.lb_tongTienHang.Font = new System.Drawing.Font("Verdana", 12F);
            this.lb_tongTienHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(130)))), ((int)(((byte)(97)))));
            this.lb_tongTienHang.Location = new System.Drawing.Point(8, 488);
            this.lb_tongTienHang.Name = "lb_tongTienHang";
            this.lb_tongTienHang.Size = new System.Drawing.Size(201, 29);
            this.lb_tongTienHang.TabIndex = 139;
            this.lb_tongTienHang.Text = "Tổng Tiền Hàng";
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(130)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.amount,
            this.total,
            this.price,
            this.total_amount});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(130)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.Location = new System.Drawing.Point(-1, 120);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(1213, 354);
            this.dataGridView.TabIndex = 138;
            // 
            // form_XuatKhac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1211, 669);
            this.Controls.Add(this.lb_maPhieu);
            this.Controls.Add(this.btn_doiNgay);
            this.Controls.Add(this.btn_xoaPhieu);
            this.Controls.Add(this.btn_themPhieu);
            this.Controls.Add(this.txt_ghiChu);
            this.Controls.Add(this.txt_tongSoLuong);
            this.Controls.Add(this.txt_tongTienHang);
            this.Controls.Add(this.lb_ghiChu);
            this.Controls.Add(this.lb_tongSoLuong);
            this.Controls.Add(this.btn_in);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.btn_after);
            this.Controls.Add(this.btn_before);
            this.Controls.Add(this.txt_xuatCho);
            this.Controls.Add(this.txt_maPhieu);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lb_xuatCho);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lb_ngay);
            this.Controls.Add(this.btn_luuGhiChu);
            this.Controls.Add(this.lb_PhieuXuatDi);
            this.Controls.Add(this.lb_tongTienHang);
            this.Controls.Add(this.dataGridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_XuatKhac";
            this.Text = "Xuất Khác";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_maPhieu;
        private Button btn_doiNgay;
        private Button btn_xoaPhieu;
        private Button btn_themPhieu;
        private TextBox txt_ghiChu;
        private TextBox txt_tongSoLuong;
        private TextBox txt_tongTienHang;
        private Label lb_ghiChu;
        private Label lb_tongSoLuong;
        private Button btn_in;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewTextBoxColumn total;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn total_amount;
        private DateTimePicker dateTimePicker;
        private Button btn_after;
        private Button btn_before;
        private TextBox txt_xuatCho;
        private TextBox txt_maPhieu;
        private PictureBox pictureBox3;
        private Label lb_xuatCho;
        private PictureBox pictureBox2;
        private Label lb_ngay;
        private Button btn_luuGhiChu;
        private Label lb_PhieuXuatDi;
        private Label lb_tongTienHang;
        private DataGridView dataGridView;
    }
}