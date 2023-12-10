using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABC_bakery.action;


namespace ABC_bakery.export_cakes
{
    public partial class form_XuatKhac : Form
    {
        private string connectionString = "Data Source=DESKTOP-R7ME920\\MINH;Initial Catalog=ABC_bakery;Integrated Security=True";
        private List<int> listCurrentShowinhID = new List<int>();
        private int currentShowinhID = 0;
        ArrayList listOrder = new ArrayList();

        public form_XuatKhac()
        {
            InitializeComponent();
            LoadData();
            displayOrder();
            //loadTime();
            //loadTongSoLuong();
            //loadTongTienHang();
        }
        public DateTime getChooesedDate()
        {
            return dateTimePicker.Value.Date;
        }


        public void LoadData()
        {
            try
            {
                // lấy danh sách phiếu xuất trong ngày
                string date = dateTimePicker.Value.ToString("dd/MM/yyyy");
                loadFormXuatKhac listBill = new loadFormXuatKhac();
                this.listOrder = listBill.LoadData(date);

                // lấy danh sách id phiếu xuất trong ngày, sử dụng hash 
                HashSet<int> hashSetOrderID = listBill.getOrderID();
                this.listCurrentShowinhID.Clear();

                foreach (int id in hashSetOrderID)
                {
                    this.listCurrentShowinhID.Add(id);
                }

                // reset vị trí xét duyệt danh sách phiếu
                this.currentShowinhID = 0;

                //return listOrder;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                //return listOrder;
            }
        }

        public void displayOrder()
        {
            dataGridView.Rows.Clear();
            txt_maPhieu.Clear();
            txt_tongSoLuong.Clear();
            txt_tongTienHang.Clear();
            txt_xuatCho.Clear();
            txt_ghiChu.Clear();
            if (listOrder.Count > 0 || listOrder != null)
            {
                if (listCurrentShowinhID.Count > 0)
                {
                    int sumOfTotal = 0; //Tổng số lượng bánh bán ra của bill
                    float sumOfBill = 0;//Tổng Tiền Hàng
                    foreach (var item in listOrder)
                    {
                        //lấy danh sách sản phẩm theo id phiếu
                        DataRow row = item as DataRow;
                        if (row["order_id"].ToString() == listCurrentShowinhID[currentShowinhID].ToString())
                        {
                            string orderID = row["order_id"].ToString();
                            string id = row["id"].ToString();
                            string name = row["name"].ToString();
                            string amount = row["amount"].ToString();
                            string total = row["total"].ToString();
                            string price = row["price"].ToString();
                            string amount_total = row["total_amount"].ToString();
                            string customerName = row["customerName"].ToString();
                            string note = row["note"].ToString();

                            sumOfTotal += Convert.ToInt32(total);
                            sumOfBill += Convert.ToInt32(amount_total);


                            // in vào bảng
                            dataGridView.Rows.Add(id, name, amount, total, price, amount_total);
                            txt_maPhieu.Text = orderID;
                            txt_xuatCho.Text = customerName;
                            txt_tongSoLuong.Text = sumOfTotal.ToString();
                            txt_tongTienHang.Text = sumOfBill.ToString();
                            txt_ghiChu.Text = note.ToString();
                        }
                    }
                }
            }
        }


        private void order_delete(int iDDelete)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("order_delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("ID", iDDelete);
                    MessageBox.Show("HI");


                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Phiếu đã xóa thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Phiếu không tồn tại");
                    }
                    conn.Close();

                }
                LoadData();
                displayOrder();
                //loadTime();
            }
            catch
            {

            }
        }


        /* Xóa Phiếu */
        private void btn_xoaPhieu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txt_maPhieu.Text);
                order_delete(id);
                //}
            }

        }


        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView.Rows[e.RowIndex].Selected = true;
            int selectedIndex = dataGridView.SelectedRows[0].Index;
            int id = Convert.ToInt32(dataGridView.Rows[selectedIndex].Cells["id"].Value);
        }





        private void btn_doiNgay_Click(object sender, EventArgs e)
        {
            LoadData();
            displayOrder();
        }

        private void btn_before_Click(object sender, EventArgs e)
        {
            if ((currentShowinhID - 1) > 0 && (listCurrentShowinhID.Count > 0))
            {
                currentShowinhID--;
            }
            else
            {
                // Lấy giá trị ngày đã chọn từ DateTimePicker
                DateTime selectedDate = dateTimePicker.Value;

                // Cộng thêm một ngày vào giá trị ngày đã chọn
                DateTime newDate = selectedDate.AddDays(-1);

                // Gáng thời gian mới lại cho dateTimePicker
                dateTimePicker.Value = newDate;
                listCurrentShowinhID.Clear();
                currentShowinhID = 0;
                LoadData();
            }

            displayOrder();

        }

        private void btn_after_Click(object sender, EventArgs e)
        {
            if ((currentShowinhID + 1) < listCurrentShowinhID.Count && (listCurrentShowinhID.Count > 0))
            {
                currentShowinhID++;
            }
            else
            {
                // Lấy giá trị ngày đã chọn từ DateTimePicker
                DateTime selectedDate = dateTimePicker.Value;

                // Cộng thêm một ngày vào giá trị ngày đã chọn
                DateTime newDate = selectedDate.AddDays(1);

                // Gáng thời gian mới lại cho dateTimePicker
                dateTimePicker.Value = newDate;
                listCurrentShowinhID.Clear();
                currentShowinhID = 0;
                LoadData();
            }

            displayOrder();
        }

        private void btn_themPhieu_Click(object sender, EventArgs e)
        {
            FormThemPhieuXuatKhac form = new FormThemPhieuXuatKhac();
            form.ShowDialog();
        }

        private void btn_luuGhiChu_Click(object sender, EventArgs e)
        {

            int orderID = Convert.ToInt32(txt_maPhieu.Text);

            string note = txt_ghiChu.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("UpdateNoteInOrder", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số và truyền giá trị
                        command.Parameters.AddWithValue("@Note", note);
                        command.Parameters.AddWithValue("@OrderID", orderID);

                        // Thực thi stored procedure
                        command.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }
    }
}
