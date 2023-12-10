using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thongkemuahang
{
    public partial class ThongKeMuaHang : Form
    {
        public ThongKeMuaHang()
        {
            InitializeComponent();
        }

        private void ThongKeMuaHang_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {

        }

        private void btnInDanhSach_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
         //   string tuKhoa = textBoxTuKhoa.Text;
         //   TimKiem(tuKhoa);
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        private void XuatExcel()
        {
            // Sử dụng thư viện Excel Interop hoặc OpenXML để xuất file Excel
            // Ví dụ:
          //  var excelApp = new Microsoft.Office.Interop.Excel.Application();
          //  var workbook = excelApp.Workbooks.Add();
           // var worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];
            // ... thêm dữ liệu từ danh sách mua hàng vào worksheet ...
          //   workbook.SaveAs("DuongDanFileExcel.xlsx");
         //    excelApp.Quit();
        }
        private void TimKiem(string tuKhoa)
        {
            // Thực hiện tìm kiếm trong danh sách mua hàng
       //     var ketQuaTimKiem = danhSachMuaHang.Where(item => item.TenSanPham.Contains(tuKhoa)).ToList();

            // Hiển thị kết quả tìm kiếm lên DataGridView hoặc ListBox tương ứng
            // Ví dụ: dataGridView1.DataSource = ketQuaTimKiem;
        }
        private void label30_Click(object sender, EventArgs e)
        {

        }
        private class MuaHangItem
        {
            public string TenSanPham { get; set; }
            public decimal DonGia { get; set; }
            public int SoLuong { get; set; }

            public decimal ThanhTien
            {
                get { return DonGia * SoLuong; }
            }
        }
        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label54_Click(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void label68_Click(object sender, EventArgs e)
        {

        }

        private void lbTien_Click(object sender, EventArgs e)
        {

        }
    }
}