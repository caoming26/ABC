using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABC_bakery.action;
using ABC_bakery.oop;
using ABC_bakery;

namespace ABC_bakery.export_cakes
{
    public partial class FormThemPhieuXuatHuy : Form
    {
        private string connectionString = "Data Source=DESKTOP-R7ME920\\MINH;Initial Catalog=ABC_bakery;Integrated Security=True";

        ArrayList listProducts = new ArrayList();
        ArrayList listPromotions = new ArrayList();
        string idProduct = "";
        float ratio = 0;
        int count = 0;
        private form_XuatHuy xuatHuy;
        public FormThemPhieuXuatHuy()
        {
            xuatHuy = new form_XuatHuy();
            InitializeComponent();
            getListProducts();
            getListPromotions();
        }

        public void getListProducts()
        {
            // Xóa các dữ liệu cũ
            comboBox_loaiBanh.Items.Clear();
            comboBox_loaiBanh.Text = "";
            comboBox_tenBanh.Items.Clear();
            comboBox_tenBanh.Text = "";
            txtGia.Text = "";
            txtTon.Text = "";
            txt_thanhTien.Text = "";
            txtSoLuong.Text = "";

            // Thêm dữ liệu mới
            loadAllProducts products = new loadAllProducts();
            this.listProducts = products.loadData();
            foreach (DataRow item in listProducts)
            {
                comboBox_loaiBanh.Items.Add(item["categoriesName"].ToString());
            }
        }
        public void getListPromotions()
        {
            comboBox_maGiam.Items.Clear();
            loadAllPromotions promotions = new loadAllPromotions();
            this.listPromotions = promotions.loadData();
            comboBox_maGiam.Items.Add("Khong Giam");
            foreach (DataRow item in listPromotions)
            {
                comboBox_maGiam.Items.Add(item["name"].ToString() + " - " + item["ratio"].ToString() + "%");
            }
        }

        private void loadTotalCost()
        {
            decimal totalAmount = 0;
            decimal total = 0;

            foreach (ListViewItem item in listViewProducts.Items)
            {
                if (item.SubItems.Count > 7)
                {
                    string totalAmountText = item.SubItems[7].Text;
                    if (decimal.TryParse(totalAmountText, out decimal amount))
                    {
                        totalAmount += amount;
                    }
                    else
                    {
                        // Xử lý khi giá trị không thể chuyển đổi thành kiểu decimal
                    }

                    string totalText = item.SubItems[4].Text;
                    if (decimal.TryParse(totalText, out decimal quantity))
                    {
                        total += quantity;
                    }
                    else
                    {
                        // Xử lý khi giá trị không thể chuyển đổi thành kiểu decimal
                    }
                }
                else
                {
                    // Xử lý khi chỉ mục subitem không hợp lệ
                }
            }

            txt_tongTienHang.Text = totalAmount.ToString();
            txt_tongSoLuong.Text = total.ToString();
        }

        private void clearAll()
        {
            comboBox_loaiBanh.Text = "";
            comboBox_tenBanh.Text = "";
            comboBox_maGiam.Text = "";
            txtGia.Text = "";
            txtSoLuong.Text = "";
            txtTon.Text = "";
            txt_thanhTien.Text = "";
        }

        private void comboBox_loaiBanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            //xóa sữ liệu cũ
            comboBox_tenBanh.Items.Clear();
            comboBox_tenBanh.Text = "";
            idProduct = "";
            txtGia.Text = "";
            txtTon.Text = "";
            txt_thanhTien.Text = "";
            txtSoLuong.Text = "";

            // Thêm Dữ liệu mới

            string catergory = comboBox_loaiBanh.SelectedItem.ToString();
            foreach (DataRow item in listProducts)
            {
                if (item["categoriesName"].ToString() == catergory)
                {
                    comboBox_tenBanh.Items.Add(item["name"]);
                }
            }
        }

        private void comboBox_tenBanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtGia.Text = "";
            txtTon.Text = "";
            txt_thanhTien.Text = "";
            txtSoLuong.Text = "";

            string name = comboBox_tenBanh.SelectedItem.ToString();
            foreach (DataRow item in listProducts)
            {
                if (item["name"].ToString() == name)
                {
                    txtGia.Text = item["price"].ToString();
                    txtTon.Text = item["amount"].ToString();
                    idProduct = item["id"].ToString();
                }
            }
        }
        private void comboBox_maGiam_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ratio = 0;
            foreach (DataRow item in listPromotions)
            {
                if ((item["name"].ToString() + " - " + item["ratio"].ToString() + "%") == comboBox_maGiam.Text)
                {
                    if (item["ratio"].ToString() != "0")
                    {
                        this.ratio = float.Parse(item["ratio"].ToString()) / 100;
                    }
                    if (float.Parse(item["ratio"].ToString()) != 0)
                    {
                        this.ratio = float.Parse(item["ratio"].ToString()) / 100;
                    }

                }

                if (txtSoLuong.Text == "")
                {
                    // khong lam gi
                }
                else if (comboBox_maGiam.Text == "Khong Giam - 0%" || comboBox_maGiam.Text == "" || comboBox_maGiam.Text == "Khong Giam")
                {
                    txt_thanhTien.Text = (Convert.ToInt32(txtGia.Text) * Convert.ToInt32(txtSoLuong.Text)).ToString();
                }
                else
                {
                    MessageBox.Show(this.ratio.ToString());
                    txt_thanhTien.Text = ((Convert.ToInt32(txtGia.Text) * Convert.ToInt32(txtSoLuong.Text)) - (Convert.ToInt32(txtGia.Text) * Convert.ToInt32(txtSoLuong.Text) * this.ratio)).ToString();
                }

            }
        }
        private void comboBox_maGiam_TextUpdate(object sender, EventArgs e)
        {
            if (comboBox_maGiam.Text == "")
            {
                this.ratio = 1;
                if (txtSoLuong.Text == "")
                {
                    // Không làm gì
                }
                else
                {
                    txt_thanhTien.Text = (Convert.ToInt32(txtGia.Text) * Convert.ToInt32(txtSoLuong.Text) * this.ratio).ToString();
                }
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            txt_thanhTien.Text = ""; // xóa giá trị thành tiền hiện tại
            string input = txtSoLuong.Text;
            bool containsNonNumeric = false;

            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    containsNonNumeric = true;
                    break;
                }
            }
            // Chuỗi đầu vào chứa ký tự không phải số
            if (containsNonNumeric)
            {
                MessageBox.Show("Chỉ được nhập số!! Mời nhập lại!!!");
                txtSoLuong.Text = "";
            }
            // Không nhập gì cả
            else if (txtSoLuong.Text == "")
            {

            }
            // Nhập số lượng > số tồn
            else if (Convert.ToInt32(txtSoLuong.Text) > Convert.ToInt32(txtTon.Text))
            {
                MessageBox.Show("Số lượng bánh không đủ!! Mời nhập lại!!!");
                txtSoLuong.Text = "";
            }
            // Chuỗi đầu vào chỉ chứa các ký tự số
            else
            {
                txt_thanhTien.Text = ((Convert.ToInt32(txtGia.Text) * Convert.ToInt32(txtSoLuong.Text)) - (Convert.ToInt32(txtGia.Text) * Convert.ToInt32(txtSoLuong.Text) * this.ratio)).ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            string categoriesName = comboBox_loaiBanh.Text.ToString();
            string id = this.idProduct;
            string name = comboBox_tenBanh.Text.ToString();
            string amount = txtTon.Text.ToString();
            string total = txtSoLuong.Text.ToString();
            string price = txtGia.Text.ToString();
            string promotion = comboBox_maGiam.Text.ToString();
            string total_amount = txt_thanhTien.Text.ToString();
            string customer = "";


            if (txt_tenKhachHang.Text.ToString() == "")
            {
                customer = "Khong";
            }
            else
            {
                customer = txt_tenKhachHang.Text.ToString();
            }



            ListViewItem newItem = new ListViewItem(categoriesName);
            newItem.SubItems.Add(id);
            newItem.SubItems.Add(name);
            newItem.SubItems.Add(amount);
            newItem.SubItems.Add(total);
            newItem.SubItems.Add(price);
            newItem.SubItems.Add(promotion);
            newItem.SubItems.Add(total_amount);
            newItem.SubItems.Add(customer);

            listViewProducts.Items.Insert(0, newItem);
            listViewProducts.FullRowSelect = true;
            listViewProducts.GridLines = true;
            count += 1;
            loadTotalCost();

        }

        private void listViewProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProducts.SelectedItems.Count > 0 && listViewProducts.SelectedIndices[0] < count)
            {
                ListViewItem selectedItem = listViewProducts.SelectedItems[0];
                MessageBox.Show(count.ToString());
                MessageBox.Show(listViewProducts.SelectedIndices[0].ToString());
                comboBox_loaiBanh.Text = selectedItem.SubItems[0].Text;
                comboBox_tenBanh.Text = selectedItem.SubItems[2].Text;
                txtTon.Text = selectedItem.SubItems[3].Text;
                txtSoLuong.Text = selectedItem.SubItems[4].Text;
                txtGia.Text = selectedItem.SubItems[5].Text;
                comboBox_maGiam.Text = selectedItem.SubItems[6].Text;
                txt_thanhTien.Text = selectedItem.SubItems[7].Text;
                txt_tenKhachHang.Text = selectedItem.SubItems[8].Text;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listViewProducts.SelectedItems.Count > 0)
            {
                // Lặp qua từng mục được chọn và xóa chúng từ ListView
                foreach (ListViewItem selectedItem in listViewProducts.SelectedItems)
                {
                    listViewProducts.Items.Remove(selectedItem);
                    loadTotalCost();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listViewProducts.SelectedItems.Count > 0)
            {
                // Chỉnh sửa mục đầu tiên được chọn
                ListViewItem selectedItem = listViewProducts.SelectedItems[0];

                foreach (DataRow row in listProducts)
                {
                    if (comboBox_tenBanh.Text == row["name"].ToString())
                    {
                        this.idProduct = row["id"].ToString();
                    }
                }
                // Sau khi chỉnh sửa, cập nhật thông tin của mục trong ListView
                selectedItem.SubItems[0].Text = comboBox_loaiBanh.Text;
                selectedItem.SubItems[1].Text = this.idProduct;
                selectedItem.SubItems[2].Text = comboBox_tenBanh.Text;
                selectedItem.SubItems[3].Text = txtTon.Text;
                selectedItem.SubItems[4].Text = txtSoLuong.Text;
                selectedItem.SubItems[5].Text = txtGia.Text;
                selectedItem.SubItems[6].Text = comboBox_maGiam.Text;
                selectedItem.SubItems[7].Text = txt_thanhTien.Text;
                selectedItem.SubItems[8].Text = txt_tenKhachHang.Text;
                loadTotalCost();

            }
        }
        public int GetLatestOrderId(string connectionString)
        {
            int latestOrderId = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("GetLatestOrderId", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            latestOrderId = Convert.ToInt32(reader["LatestOrderId"]);
                        }
                    }
                }
            }

            return latestOrderId;
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Tạo DataTable chứa thông tin chi tiết sản phẩm
                DataTable productDetailsTable = new DataTable();
                productDetailsTable.Columns.Add("id_product", typeof(long));
                productDetailsTable.Columns.Add("OD_total", typeof(float));
                productDetailsTable.Columns.Add("OD_price", typeof(float));

                long idProduct;
                float odTotal;
                float odPrice;



                // Thêm dữ liệu vào DataTable
                foreach (ListViewItem item in listViewProducts.Items)
                {
                    if (item.SubItems.Count >= 5) // Kiểm tra số lượng phần tử con
                    {
                        if (long.TryParse(item.SubItems[1].Text, out idProduct) && float.TryParse(item.SubItems[4].Text, out odTotal) && float.TryParse(item.SubItems[5].Text, out odPrice))
                        {
                            productDetailsTable.Rows.Add(idProduct, odPrice, odTotal);
                        }
                        else
                        {
                            // Xử lý lỗi hoặc thông báo cho người dùng
                        }
                    }
                    else
                    {
                        // Xử lý lỗi hoặc thông báo cho người dùng
                    }
                }



                using (SqlCommand command = new SqlCommand("AddOrder", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;



                    // Thêm các tham số cho stored procedure
                    long promotionID = 0;
                    foreach (DataRow row in listPromotions)
                    {
                        if ((row["name"].ToString() + " - " + row["ratio"].ToString() + "%") == comboBox_maGiam.Text)
                        {
                            promotionID = long.Parse(row["id"].ToString());
                        }
                        else
                        {
                            promotionID = 22;
                        }
                    }
                    command.Parameters.AddWithValue("@promotionID", promotionID);
                    command.Parameters.AddWithValue("@receipt_id", long.Parse("1"));
                    command.Parameters.AddWithValue("@cashier_id", long.Parse("1"));
                    command.Parameters.AddWithValue("@price", float.Parse(txt_tongTienHang.Text));

                    if (txt_tenKhachHang.Text == "")
                    {
                        command.Parameters.AddWithValue("@name", "Khong");
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@name", txt_tenKhachHang.Text);
                    }

                    command.Parameters.AddWithValue("@address", "Khong");

                    if (comboBox_maGiam.Text == "Khong Giam" || comboBox_maGiam.Text == "")
                    {
                        command.Parameters.AddWithValue("@status", 0);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@status", 1);
                    }

                    command.Parameters.AddWithValue("@type", 2);
                    command.Parameters.AddWithValue("@total", Convert.ToInt32(txt_tongSoLuong.Text));
                    command.Parameters.AddWithValue("@ship_fee", 1);
                    command.Parameters.AddWithValue("@payment_method", 1);
                    command.Parameters.AddWithValue("@is_paid", 1);
                    command.Parameters.AddWithValue("@prepay", 0);
                    DateTime currentDate = DateTime.Now;
                    string dateParameter = xuatHuy.getChooesedDate().ToString("yyyy-MM-dd");
                    command.Parameters.AddWithValue("@ordered_at", dateParameter);
                    command.Parameters.AddWithValue("@note", txt_ghiChu.Text);
                    command.Parameters.AddWithValue("@change", 1);
                    command.Parameters.AddWithValue("@receieved", txt_tongTienHang.Text);
                    command.Parameters.AddWithValue("@prefix", "OD");
                    command.Parameters.AddWithValue("@productDetails", productDetailsTable);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) { }
                    xuatHuy.LoadData();
                    xuatHuy.displayOrder();

                    this.Close();
                }
            }
        }


        private void FormThemPhieuXuatDi_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kiểm tra nếu form đóng hoàn toàn
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Gọi hàm LoadData của FormA
                xuatHuy.LoadData();
                xuatHuy.displayOrder();
            }
        }
    }
}
