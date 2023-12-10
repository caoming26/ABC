using System.Drawing;
using System.Windows.Forms;

namespace ABC_bakery.import_cakes
{
    partial class FormThemPhieuMuaNgoai
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
            this.btnThem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenBanh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.cbSuppliers = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.btnThem.Location = new System.Drawing.Point(477, 342);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(130, 40);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(127, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Số lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(127, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Giá:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(127, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tên bánh:";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(327, 173);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(280, 26);
            this.txtGia.TabIndex = 12;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(327, 102);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(280, 26);
            this.txtSoLuong.TabIndex = 11;
            // 
            // txtTenBanh
            // 
            this.txtTenBanh.Location = new System.Drawing.Point(327, 39);
            this.txtTenBanh.Name = "txtTenBanh";
            this.txtTenBanh.Size = new System.Drawing.Size(280, 26);
            this.txtTenBanh.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(127, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "Loại bánh";
            // 
            // cbCategories
            // 
            this.cbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbCategories.Location = new System.Drawing.Point(327, 231);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(213, 28);
            this.cbCategories.Sorted = true;
            this.cbCategories.TabIndex = 20;
            // 
            // cbSuppliers
            // 
            this.cbSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSuppliers.FormattingEnabled = true;
            this.cbSuppliers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbSuppliers.Location = new System.Drawing.Point(327, 287);
            this.cbSuppliers.Name = "cbSuppliers";
            this.cbSuppliers.Size = new System.Drawing.Size(213, 28);
            this.cbSuppliers.Sorted = true;
            this.cbSuppliers.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(127, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 29);
            this.label6.TabIndex = 21;
            this.label6.Text = "Nhà cung cấp";
            // 
            // FormThemPhieuMuaNgoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(749, 502);
            this.Controls.Add(this.cbSuppliers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbCategories);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtTenBanh);
            this.Name = "FormThemPhieuMuaNgoai";
            this.Text = "FormThemPhieu";
            this.Load += new System.EventHandler(this.FormThemPhieu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnThem;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtGia;
        private TextBox txtSoLuong;
        private TextBox txtTenBanh;
        private Label label5;
        private ComboBox cbCategories;
        private ComboBox cbSuppliers;
        private Label label6;
    }
}