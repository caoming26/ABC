using System.Drawing;
using System.Windows.Forms;

namespace ABC_bakery.import_cakes
{
    partial class FormNhapBanhNoiBo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtPriceProduct = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnChangeDate = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(631, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập bánh nội bộ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F);
            this.label3.Location = new System.Drawing.Point(147, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(147, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1300, 453);
            this.dataGridView1.TabIndex = 5;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(243, 99);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShowUpDown = true;
            this.dateTimePicker.Size = new System.Drawing.Size(213, 34);
            this.dateTimePicker.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(120, 662);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ghi chú";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(1161, 719);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tổng tiền";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(610, 662);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tổng tiền hàng";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.txtGhiChu.Location = new System.Drawing.Point(120, 716);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(452, 224);
            this.txtGhiChu.TabIndex = 13;
            // 
            // txtPriceProduct
            // 
            this.txtPriceProduct.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.txtPriceProduct.Location = new System.Drawing.Point(830, 663);
            this.txtPriceProduct.Name = "txtPriceProduct";
            this.txtPriceProduct.ReadOnly = true;
            this.txtPriceProduct.Size = new System.Drawing.Size(205, 32);
            this.txtPriceProduct.TabIndex = 14;
            this.txtPriceProduct.Text = "0 đ";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.txtTotal.Location = new System.Drawing.Point(1320, 716);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(205, 32);
            this.txtTotal.TabIndex = 15;
            this.txtTotal.Text = "0 đ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(631, 766);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 93);
            this.button1.TabIndex = 16;
            this.button1.Text = "Lưu ghi chú";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(757, 766);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 93);
            this.button2.TabIndex = 17;
            this.button2.Text = "Thêm phiếu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1027, 766);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 93);
            this.button3.TabIndex = 18;
            this.button3.Text = "In";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(899, 766);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 93);
            this.button4.TabIndex = 19;
            this.button4.Text = "Xóa phiếu";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnChangeDate
            // 
            this.btnChangeDate.Font = new System.Drawing.Font("Verdana", 12F);
            this.btnChangeDate.Location = new System.Drawing.Point(243, 12);
            this.btnChangeDate.Name = "btnChangeDate";
            this.btnChangeDate.Size = new System.Drawing.Size(200, 44);
            this.btnChangeDate.TabIndex = 20;
            this.btnChangeDate.Text = "Đổi ngày";
            this.btnChangeDate.UseVisualStyleBackColor = true;
            this.btnChangeDate.Click += new System.EventHandler(this.btnChangeDate_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(ABC_bakery.import_cakes.FormNhapBanhNoiBo);
            // 
            // FormNhapBanhNoiBo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1573, 952);
            this.Controls.Add(this.btnChangeDate);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtPriceProduct);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormNhapBanhNoiBo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label3;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker;
        private Label label4;
        private Label label6;
        private Label label7;
        private TextBox txtGhiChu;
        private TextBox txtPriceProduct;
        private TextBox txtTotal;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button btnChangeDate;
        private BindingSource form1BindingSource;
        private System.Windows.Forms.Timer timer1;
    }
}