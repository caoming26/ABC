using System.Drawing;
using System.Windows.Forms;

namespace ABC_bakery.system
{
    partial class LoginForm
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
            txtMatKhau = new TextBox();
            txtTaiKhoan = new TextBox();
            lbl_login = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(316, 198);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(228, 27);
            txtMatKhau.TabIndex = 2;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(316, 131);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(228, 27);
            txtTaiKhoan.TabIndex = 3;
            // 
            // lbl_login
            // 
            lbl_login.AutoSize = true;
            lbl_login.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_login.Location = new Point(294, 28);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(207, 34);
            lbl_login.TabIndex = 5;
            lbl_login.Text = "ĐĂNG NHẬP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(142, 131);
            label3.Name = "label3";
            label3.Size = new Size(136, 28);
            label3.TabIndex = 6;
            label3.Text = "Tài khoản:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(142, 194);
            label4.Name = "label4";
            label4.Size = new Size(130, 28);
            label4.TabIndex = 7;
            label4.Text = "Mật khẩu:";
            // 
            // button1
            // 
            button1.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(392, 321);
            button1.Name = "button1";
            button1.Size = new Size(152, 47);
            button1.TabIndex = 8;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(316, 257);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(213, 33);
            comboBox1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(201, 257);
            label1.Name = "label1";
            label1.Size = new Size(71, 28);
            label1.TabIndex = 10;
            label1.Text = "Role:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(226, 199, 153);
            ClientSize = new Size(759, 396);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbl_login);
            Controls.Add(txtTaiKhoan);
            Controls.Add(txtMatKhau);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtMatKhau;
        private TextBox txtTaiKhoan;
        private Label lbl_login;
        private Label label3;
        private Label label4;
        private Button button1;
        private ComboBox comboBox1;
        private Label label1;
    }
}