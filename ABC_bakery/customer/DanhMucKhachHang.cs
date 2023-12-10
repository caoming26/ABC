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
using System.Data.SqlClient;

namespace ABC_bakery.customer
{
    public partial class DanhMucKhachHang : Form
    {
        private String connectionString = "Data Source=DESKTOP-R7ME920\\MINH;Initial Catalog=ABC_bakery;Integrated Security=True";
        public DanhMucKhachHang()
        {
            InitializeComponent();
        }

        private void DanhMucKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'danhMucKhachHang_DataSet2.SelectDanhMucKhachHang' table. You can move, or remove it, as needed.
            this.selectDanhMucKhachHangTableAdapter1.Fill(this.danhMucKhachHang_DataSet2.SelectDanhMucKhachHang);
            // TODO: This line of code loads data into the 'danhMucKhachHang_DataSet.SelectDanhMucKhachHang' table. You can move, or remove it, as needed.
            // this.selectDanhMucKhachHangTableAdapter.Fill(this.danhMucKhachHang_DataSet.SelectDanhMucKhachHang);

        }

        private void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Tạo một đối tượng Bitmap mới với kích thước của DataGridView.
            Bitmap bitmap = new Bitmap(DanhMucKhachHang_dataGridView2.Width, DanhMucKhachHang_dataGridView2.Height);

            // Tạo một đối tượng Rectangle mới với kích thước của DataGridView.
            Rectangle rectangle = new Rectangle(0, 0, DanhMucKhachHang_dataGridView2.Width, DanhMucKhachHang_dataGridView2.Height);

            // Gọi phương thức DrawToBitmap với các tham số phù hợp.
            DanhMucKhachHang_dataGridView2.DrawToBitmap(bitmap, rectangle);

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

        //private void exportExcel_btn_Click(object sender, EventArgs e)
        //{
        //    SaveFileDialog saveFileDialog = new SaveFileDialog();
        //    saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
        //    saveFileDialog.Title = "Export to Excel";
        //    saveFileDialog.FileName = "ExportedData.xlsx";

        //    if (saveFileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        ExcelExporter.ExportToExcel(DanhMucKhachHang_dataGridView2, saveFileDialog.FileName);
        //        ExcelExporter.ExportToExcel(DanhMucKhachHang_dataGridView2, saveFileDialog.FileName);
        //    }
        //}

        private void save_btn_Click(object sender, EventArgs e)
        {
            // Tạo một DataTable mới
            DataTable dt = new DataTable();

            // Thêm các cột/dòng tương ứng với các cột trong DataGridView
            foreach (DataGridViewColumn column in DanhMucKhachHang_dataGridView2.Columns)
            {
                dt.Columns.Add(column.Name, typeof(string));
            }

            foreach (DataGridViewRow row in DanhMucKhachHang_dataGridView2.Rows)
            {
                DataRow dr = dt.NewRow();

                foreach (DataGridViewCell cell in row.Cells)
                {
                    dr[cell.ColumnIndex] = cell.Value;
                }

                dt.Rows.Add(dr);
            }

            // Lưu DataTable vào cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [ABC_bakery].[dbo].[suppliers]", connection))
                {
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    adapter.Update(dt);
                }
            }

        }
    }
}
