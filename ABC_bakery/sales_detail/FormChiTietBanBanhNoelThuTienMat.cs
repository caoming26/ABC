using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace ChiTietTonBanh
{
    public partial class FormChiTietBanBanhNoelThuTienMat : Form
    {
        public FormChiTietBanBanhNoelThuTienMat()
        {
            InitializeComponent();
        }

        private void FormChiTietBanBanhNoelThuTienMat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chiTietBanBanhNoelThuTienMat_DataSet.chiTietBanBanhNoelThuTienMat' table. You can move, or remove it, as needed.
            this.chiTietBanBanhNoelThuTienMatTableAdapter.Fill(this.chiTietBanBanhNoelThuTienMat_DataSet.chiTietBanBanhNoelThuTienMat);

        }

        //private void export_btn_Click(object sender, EventArgs e)
        //{
        //    SaveFileDialog saveFileDialog = new SaveFileDialog();
        //    saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
        //    saveFileDialog.Title = "Export to Excel";
        //    saveFileDialog.FileName = "ExportedData.xlsx";

        //    if (saveFileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        ExcelExporter.ExportToExcel(chiTietBanBanhNoelThuTienMat_dataGridView, saveFileDialog.FileName);
        //    }
        //}

        private void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Tạo một đối tượng Bitmap mới với kích thước của DataGridView.
            Bitmap bitmap = new Bitmap(chiTietBanBanhNoelThuTienMat_dataGridView.Width, chiTietBanBanhNoelThuTienMat_dataGridView.Height);

            // Tạo một đối tượng Rectangle mới với kích thước của DataGridView.
            Rectangle rectangle = new Rectangle(0, 0, chiTietBanBanhNoelThuTienMat_dataGridView.Width, chiTietBanBanhNoelThuTienMat_dataGridView.Height);

            // Gọi phương thức DrawToBitmap với các tham số phù hợp.
            chiTietBanBanhNoelThuTienMat_dataGridView.DrawToBitmap(bitmap, rectangle);

            // Vẽ Bitmap lên đối tượng Graphics của sự kiện PrintPage.
            e.Graphics.DrawImage(bitmap, new Point(0, 0));
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            // Tạo một đối tượng PrintDocument mới.
            PrintDocument pd = new PrintDocument();

            // Đặt sự kiện PrintPage.
            pd.PrintPage += new PrintPageEventHandler(this.pd_PrintPage);

            // Gọi phương thức Print của PrintDocument để bắt đầu in.
            pd.Print();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            
                int sum = 0;
                for (int i = 0; i < chiTietBanBanhNoelThuTienMat_dataGridView.Rows.Count; ++i)
                {
                    sum += Convert.ToInt32(chiTietBanBanhNoelThuTienMat_dataGridView.Rows[i].Cells[5].Value);
                }
                total_tb.Text = sum.ToString();
            
        }
    }
}
