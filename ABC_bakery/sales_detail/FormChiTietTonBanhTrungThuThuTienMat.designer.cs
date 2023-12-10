
using ABC_bakery.sales_detail;

namespace ChiTietTonBanh
{
    partial class FormChiTietTonBanhTrungThuThuTienMat
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChiTietTonBanhTrungThuThuTienMat));
            this.total_lb = new System.Windows.Forms.Label();
            this.total_tb = new System.Windows.Forms.TextBox();
            this.export_btn = new System.Windows.Forms.Button();
            this.print_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.search_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chiTietBanBanhTrungThuThuTienMat_dataGridView = new System.Windows.Forms.DataGridView();
            this.orderedatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiTietBanBanhTrungThuThuTienMatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chiTietBanBanhTrungThuThuTienMat_DataSet = new ChiTietBanBanhTrungThuThuTienMat_DataSet();
            this.chiTietBanBanhTrungThuThuTienMatTableAdapter = new ABC_bakery.sales_detail.ChiTietBanBanhTrungThuThuTienMat_DataSetTableAdapters.chiTietBanBanhTrungThuThuTienMatTableAdapter();
            this.refresh_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietBanBanhTrungThuThuTienMat_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietBanBanhTrungThuThuTienMatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietBanBanhTrungThuThuTienMat_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // total_lb
            // 
            this.total_lb.AutoSize = true;
            this.total_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_lb.ForeColor = System.Drawing.Color.SaddleBrown;
            this.total_lb.Location = new System.Drawing.Point(1094, 675);
            this.total_lb.Name = "total_lb";
            this.total_lb.Size = new System.Drawing.Size(82, 17);
            this.total_lb.TabIndex = 15;
            this.total_lb.Text = "Tổng tiền:";
            // 
            // total_tb
            // 
            this.total_tb.Location = new System.Drawing.Point(1182, 672);
            this.total_tb.Name = "total_tb";
            this.total_tb.Size = new System.Drawing.Size(189, 22);
            this.total_tb.TabIndex = 14;
            // 
            // export_btn
            // 
            this.export_btn.Location = new System.Drawing.Point(1259, 39);
            this.export_btn.Name = "export_btn";
            this.export_btn.Size = new System.Drawing.Size(112, 23);
            this.export_btn.TabIndex = 12;
            this.export_btn.Text = "Xuất Excel";
            this.export_btn.UseVisualStyleBackColor = true;
            //this.export_btn.Click += new System.EventHandler(this.export_btn_Click);
            // 
            // print_btn
            // 
            this.print_btn.Location = new System.Drawing.Point(1141, 39);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(112, 23);
            this.print_btn.TabIndex = 11;
            this.print_btn.Text = "In Danh Sách";
            this.print_btn.UseVisualStyleBackColor = true;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(195, 40);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 10;
            this.search_btn.Text = "Tìm kiếm";
            this.search_btn.UseVisualStyleBackColor = true;
            // 
            // search_box
            // 
            this.search_box.Location = new System.Drawing.Point(12, 40);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(177, 22);
            this.search_box.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PapayaWhip;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(402, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(603, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "CHI TIẾT BÁN BÁNH TRUNG THU THU TIỀN MẶT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chiTietBanBanhTrungThuThuTienMat_dataGridView
            // 
            this.chiTietBanBanhTrungThuThuTienMat_dataGridView.AutoGenerateColumns = false;
            this.chiTietBanBanhTrungThuThuTienMat_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.chiTietBanBanhTrungThuThuTienMat_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chiTietBanBanhTrungThuThuTienMat_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderedatDataGridViewTextBoxColumn,
            this.productidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.chiTietBanBanhTrungThuThuTienMat_dataGridView.DataSource = this.chiTietBanBanhTrungThuThuTienMatBindingSource;
            this.chiTietBanBanhTrungThuThuTienMat_dataGridView.Location = new System.Drawing.Point(12, 69);
            this.chiTietBanBanhTrungThuThuTienMat_dataGridView.Name = "chiTietBanBanhTrungThuThuTienMat_dataGridView";
            this.chiTietBanBanhTrungThuThuTienMat_dataGridView.ReadOnly = true;
            this.chiTietBanBanhTrungThuThuTienMat_dataGridView.RowHeadersWidth = 51;
            this.chiTietBanBanhTrungThuThuTienMat_dataGridView.RowTemplate.Height = 24;
            this.chiTietBanBanhTrungThuThuTienMat_dataGridView.Size = new System.Drawing.Size(1359, 597);
            this.chiTietBanBanhTrungThuThuTienMat_dataGridView.TabIndex = 16;
            // 
            // orderedatDataGridViewTextBoxColumn
            // 
            this.orderedatDataGridViewTextBoxColumn.DataPropertyName = "ordered_at";
            this.orderedatDataGridViewTextBoxColumn.HeaderText = "ordered_at";
            this.orderedatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderedatDataGridViewTextBoxColumn.Name = "orderedatDataGridViewTextBoxColumn";
            this.orderedatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "product_id";
            this.productidDataGridViewTextBoxColumn.HeaderText = "product_id";
            this.productidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chiTietBanBanhTrungThuThuTienMatBindingSource
            // 
            this.chiTietBanBanhTrungThuThuTienMatBindingSource.DataMember = "chiTietBanBanhTrungThuThuTienMat";
            this.chiTietBanBanhTrungThuThuTienMatBindingSource.DataSource = this.chiTietBanBanhTrungThuThuTienMat_DataSet;
            // 
            // chiTietBanBanhTrungThuThuTienMat_DataSet
            // 
            this.chiTietBanBanhTrungThuThuTienMat_DataSet.DataSetName = "ChiTietBanBanhTrungThuThuTienMat_DataSet";
            this.chiTietBanBanhTrungThuThuTienMat_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chiTietBanBanhTrungThuThuTienMatTableAdapter
            // 
            this.chiTietBanBanhTrungThuThuTienMatTableAdapter.ClearBeforeFill = true;
            // 
            // refresh_btn
            // 
            this.refresh_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refresh_btn.BackgroundImage")));
            this.refresh_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refresh_btn.Location = new System.Drawing.Point(12, 8);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(23, 23);
            this.refresh_btn.TabIndex = 17;
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // FormChiTietTonBanhTrungThuThuTienMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1383, 717);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.chiTietBanBanhTrungThuThuTienMat_dataGridView);
            this.Controls.Add(this.total_lb);
            this.Controls.Add(this.total_tb);
            this.Controls.Add(this.export_btn);
            this.Controls.Add(this.print_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.label1);
            this.Name = "FormChiTietTonBanhTrungThuThuTienMat";
            this.Text = "FormChiTietTonBanhTrungThuThuTienMat";
            this.Load += new System.EventHandler(this.FormChiTietTonBanhTrungThuThuTienMat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chiTietBanBanhTrungThuThuTienMat_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietBanBanhTrungThuThuTienMatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietBanBanhTrungThuThuTienMat_DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label total_lb;
        private System.Windows.Forms.TextBox total_tb;
        private System.Windows.Forms.Button export_btn;
        private System.Windows.Forms.Button print_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView chiTietBanBanhTrungThuThuTienMat_dataGridView;
        private System.Windows.Forms.BindingSource chiTietBanBanhTrungThuThuTienMatBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderedatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button refresh_btn;
        private ChiTietBanBanhTrungThuThuTienMat_DataSet chiTietBanBanhTrungThuThuTienMat_DataSet;
        private ABC_bakery.sales_detail.ChiTietBanBanhTrungThuThuTienMat_DataSetTableAdapters.chiTietBanBanhTrungThuThuTienMatTableAdapter chiTietBanBanhTrungThuThuTienMatTableAdapter;
    }
}