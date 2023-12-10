
namespace ABC_bakery.customer

{
    partial class DanhMucKhachHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.search_box = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.print_btn = new System.Windows.Forms.Button();
            this.exportExcel_btn = new System.Windows.Forms.Button();
            this.danhMucKhachHangDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.danhMucKhachHang_DataSet = new DanhMucKhachHang_DataSet();
            this.selectDanhMucKhachHangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.selectDanhMucKhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectDanhMucKhachHangTableAdapter = new DanhMucKhachHang_DataSetTableAdapters.SelectDanhMucKhachHangTableAdapter();
            this.save_btn = new System.Windows.Forms.Button();
            this.DanhMucKhachHang_dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.prefixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectDanhMucKhachHangBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.danhMucKhachHang_DataSet2 = new DanhMucKhachHang_DataSet2();
            this.selectDanhMucKhachHangTableAdapter1 = new DanhMucKhachHang_DataSet2TableAdapters.SelectDanhMucKhachHangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucKhachHangDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucKhachHang_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDanhMucKhachHangBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDanhMucKhachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DanhMucKhachHang_dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDanhMucKhachHangBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucKhachHang_DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(354, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC KHÁCH HÀNG";
            // 
            // search_box
            // 
            this.search_box.Location = new System.Drawing.Point(12, 43);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(240, 22);
            this.search_box.TabIndex = 1;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(258, 43);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 2;
            this.search_btn.Text = "Tìm kiếm";
            this.search_btn.UseVisualStyleBackColor = true;
            // 
            // print_btn
            // 
            this.print_btn.Location = new System.Drawing.Point(818, 43);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(113, 23);
            this.print_btn.TabIndex = 3;
            this.print_btn.Text = "In Danh Sách";
            this.print_btn.UseVisualStyleBackColor = true;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // exportExcel_btn
            // 
            this.exportExcel_btn.Location = new System.Drawing.Point(937, 43);
            this.exportExcel_btn.Name = "exportExcel_btn";
            this.exportExcel_btn.Size = new System.Drawing.Size(113, 23);
            this.exportExcel_btn.TabIndex = 4;
            this.exportExcel_btn.Text = "Xuất Excel";
            this.exportExcel_btn.UseVisualStyleBackColor = true;
            //this.exportExcel_btn.Click += new System.EventHandler(this.exportExcel_btn_Click);
            // 
            // danhMucKhachHangDataSetBindingSource
            // 
            this.danhMucKhachHangDataSetBindingSource.DataSource = this.danhMucKhachHang_DataSet;
            this.danhMucKhachHangDataSetBindingSource.Position = 0;
            // 
            // danhMucKhachHang_DataSet
            // 
            this.danhMucKhachHang_DataSet.DataSetName = "DanhMucKhachHang_DataSet";
            this.danhMucKhachHang_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectDanhMucKhachHangBindingSource1
            // 
            this.selectDanhMucKhachHangBindingSource1.DataMember = "SelectDanhMucKhachHang";
            this.selectDanhMucKhachHangBindingSource1.DataSource = this.danhMucKhachHang_DataSet;
            // 
            // selectDanhMucKhachHangBindingSource
            // 
            this.selectDanhMucKhachHangBindingSource.DataMember = "SelectDanhMucKhachHang";
            this.selectDanhMucKhachHangBindingSource.DataSource = this.danhMucKhachHang_DataSet;
            // 
            // selectDanhMucKhachHangTableAdapter
            // 
            this.selectDanhMucKhachHangTableAdapter.ClearBeforeFill = true;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(12, 12);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 6;
            this.save_btn.Text = "Lưu";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // DanhMucKhachHang_dataGridView2
            // 
            this.DanhMucKhachHang_dataGridView2.AllowUserToOrderColumns = true;
            this.DanhMucKhachHang_dataGridView2.AutoGenerateColumns = false;
            this.DanhMucKhachHang_dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DanhMucKhachHang_dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DanhMucKhachHang_dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.createdatDataGridViewTextBoxColumn,
            this.updatedatDataGridViewTextBoxColumn,
            this.showDataGridViewCheckBoxColumn,
            this.prefixDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.DanhMucKhachHang_dataGridView2.DataSource = this.selectDanhMucKhachHangBindingSource2;
            this.DanhMucKhachHang_dataGridView2.Location = new System.Drawing.Point(12, 72);
            this.DanhMucKhachHang_dataGridView2.Name = "DanhMucKhachHang_dataGridView2";
            this.DanhMucKhachHang_dataGridView2.RowHeadersWidth = 51;
            this.DanhMucKhachHang_dataGridView2.RowTemplate.Height = 24;
            this.DanhMucKhachHang_dataGridView2.Size = new System.Drawing.Size(1038, 589);
            this.DanhMucKhachHang_dataGridView2.TabIndex = 7;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            this.createdatDataGridViewTextBoxColumn.DataPropertyName = "created_at";
            this.createdatDataGridViewTextBoxColumn.HeaderText = "created_at";
            this.createdatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            // 
            // updatedatDataGridViewTextBoxColumn
            // 
            this.updatedatDataGridViewTextBoxColumn.DataPropertyName = "updated_at";
            this.updatedatDataGridViewTextBoxColumn.HeaderText = "updated_at";
            this.updatedatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.updatedatDataGridViewTextBoxColumn.Name = "updatedatDataGridViewTextBoxColumn";
            // 
            // showDataGridViewCheckBoxColumn
            // 
            this.showDataGridViewCheckBoxColumn.DataPropertyName = "show";
            this.showDataGridViewCheckBoxColumn.HeaderText = "show";
            this.showDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.showDataGridViewCheckBoxColumn.Name = "showDataGridViewCheckBoxColumn";
            // 
            // prefixDataGridViewTextBoxColumn
            // 
            this.prefixDataGridViewTextBoxColumn.DataPropertyName = "prefix";
            this.prefixDataGridViewTextBoxColumn.HeaderText = "prefix";
            this.prefixDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prefixDataGridViewTextBoxColumn.Name = "prefixDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // selectDanhMucKhachHangBindingSource2
            // 
            this.selectDanhMucKhachHangBindingSource2.DataMember = "SelectDanhMucKhachHang";
            this.selectDanhMucKhachHangBindingSource2.DataSource = this.danhMucKhachHang_DataSet2;
            // 
            // danhMucKhachHang_DataSet2
            // 
            this.danhMucKhachHang_DataSet2.DataSetName = "DanhMucKhachHang_DataSet2";
            this.danhMucKhachHang_DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectDanhMucKhachHangTableAdapter1
            // 
            this.selectDanhMucKhachHangTableAdapter1.ClearBeforeFill = true;
            // 
            // DanhMucKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.DanhMucKhachHang_dataGridView2);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.exportExcel_btn);
            this.Controls.Add(this.print_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.label1);
            this.Name = "DanhMucKhachHang";
            this.Text = "DanhMucKhachHang";
            this.Load += new System.EventHandler(this.DanhMucKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.danhMucKhachHangDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucKhachHang_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDanhMucKhachHangBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDanhMucKhachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DanhMucKhachHang_dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDanhMucKhachHangBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucKhachHang_DataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button print_btn;
        private System.Windows.Forms.Button exportExcel_btn;
        private System.Windows.Forms.BindingSource selectDanhMucKhachHangBindingSource;
        private DanhMucKhachHang_DataSet danhMucKhachHang_DataSet;
        private DanhMucKhachHang_DataSetTableAdapters.SelectDanhMucKhachHangTableAdapter selectDanhMucKhachHangTableAdapter;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.BindingSource selectDanhMucKhachHangBindingSource1;
        private System.Windows.Forms.BindingSource danhMucKhachHangDataSetBindingSource;
        private System.Windows.Forms.DataGridView DanhMucKhachHang_dataGridView2;
        private DanhMucKhachHang_DataSet2 danhMucKhachHang_DataSet2;
        private System.Windows.Forms.BindingSource selectDanhMucKhachHangBindingSource2;
        private DanhMucKhachHang_DataSet2TableAdapters.SelectDanhMucKhachHangTableAdapter selectDanhMucKhachHangTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn showDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prefixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
    }
}