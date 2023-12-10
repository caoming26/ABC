using System.Drawing;
using System.Windows.Forms;

namespace ABC_bakery.import_cakes
{
    partial class FormThemPhieuNoiBo
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
            this.txtTenBanh = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbCategories = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtTenBanh
            // 
            this.txtTenBanh.Location = new System.Drawing.Point(273, 41);
            this.txtTenBanh.Name = "txtTenBanh";
            this.txtTenBanh.Size = new System.Drawing.Size(280, 26);
            this.txtTenBanh.TabIndex = 0;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(273, 99);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(280, 26);
            this.txtSoLuong.TabIndex = 2;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(273, 170);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(280, 26);
            this.txtGia.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(73, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên bánh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(73, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(73, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số lượng:";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.btnThem.Location = new System.Drawing.Point(423, 293);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(130, 40);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(73, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Loại bánh";
            // 
            // cbbCategories
            // 
            this.cbbCategories.FormattingEnabled = true;
            this.cbbCategories.Location = new System.Drawing.Point(273, 236);
            this.cbbCategories.Name = "cbbCategories";
            this.cbbCategories.Size = new System.Drawing.Size(226, 28);
            this.cbbCategories.TabIndex = 11;
            // 
            // FormThemPhieuNoiBo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(808, 525);
            this.Controls.Add(this.cbbCategories);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtTenBanh);
            this.Name = "FormThemPhieuNoiBo";
            this.Text = "FormThemPhieu";
            this.Load += new System.EventHandler(this.FormThemPhieu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtTenBanh;
        private TextBox txtSoLuong;
        private TextBox txtGia;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnThem;
        private Label label5;
        private ComboBox cbbCategories;
    }
}