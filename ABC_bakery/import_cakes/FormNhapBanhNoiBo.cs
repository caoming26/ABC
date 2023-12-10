using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Numerics;
using System.Data.Common;


namespace ABC_bakery.import_cakes
{
    public partial class FormNhapBanhNoiBo : Form
    {
        string connectString = "Data Source=DESKTOP-R7ME920\\MINH;Initial Catalog=ABC_bakery;Integrated Security=True;TrustServerCertificate=True";
        private string role;
        private string taiKhoan;
        private bool permission;

        public FormNhapBanhNoiBo()
        {
            InitializeComponent();
            connectDB();
        }

        public FormNhapBanhNoiBo(string role, bool permission, string tk)
        {
            InitializeComponent();
            this.role = role;
            this.permission = permission;
            this.taiKhoan = tk;
        }
        private DateTime getExpirationTime()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string query = "SELECT expirationTime FROM Users WHERE name = @Name AND role_id = 2";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", taiKhoan);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Lấy giá trị expirationTime từ cột đầu tiên (0)
                    DateTime expirationTime = reader.GetDateTime(0);
                    //MessageBox.Show($"Giá trị expirationTime: {expirationTime}", "Thông báo");
                    return expirationTime;

                }
                return DateTime.MinValue;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(role == "Nhan vien ke toan")
            {
                disableButton();
            } else
            {
                enableButton();
            }
            
            timer1.Start();
        }

        private void disableButton()
        {
            button2.Enabled = false;
            button4.Enabled = false;
        }

        private void enableButton()
        {
            button2.Enabled = true;
            button4.Enabled = true;
        }


        private void connectDB()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectString);
                conn.Open();
                string loadProcedureName = "ImportInToNhapBanhNoiBo";
                SqlCommand cmd = new SqlCommand(loadProcedureName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                int total = totalSumPrice(dt);
                string formatTotal = total.ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("vi-VN")) + " đ";
                txtTotal.Text = formatTotal;
                conn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormThemPhieuNoiBo form = new FormThemPhieuNoiBo();
            form.ShowDialog();
            string dateTime = dateTimePicker.Value.ToString("dd/MM/yyyy");
            setTotalPriceOnDate(dateTime);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)

            {

                dataGridView1.Rows[e.RowIndex].Selected = true;
                SqlConnection conn = new SqlConnection(connectString);
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                int id = (int)(long)dataGridView1.Rows[selectedIndex].Cells["MaBanh"].Value;
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT dbo.CalculateEachProduct(@ProductID)", conn);
                SqlCommand cmd1 = new SqlCommand("SELECT note FROM products WHERE id = @ProductId", conn);
                cmd.Parameters.AddWithValue("@ProductID", id);
                cmd1.Parameters.AddWithValue("@ProductID", id);

                int priceProduct = (int)cmd.ExecuteScalar();
                string priceProductString = priceProduct.ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("vi-VN")) + " đ";
                txtPriceProduct.Text = priceProductString;

                SqlDataReader myReader = cmd1.ExecuteReader();
                if (myReader.Read())
                {
                    if (!myReader.IsDBNull(0))
                    {
                        string note = myReader.GetString(0);

                        // Hiển thị giá trị trên textbox
                        txtGhiChu.Text = note;
                    }
                    else
                    {
                        txtGhiChu.Text = "";
                    }


                }
                conn.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int selectedIndex = dataGridView1.SelectedRows[0].Index;
                    SqlConnection conn = new SqlConnection(connectString);
                    conn.Open();
                    int id = (int)(long)dataGridView1.Rows[selectedIndex].Cells["MaBanh"].Value;
                    SqlCommand cmd = new SqlCommand("DeleteProductRow", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProductID", id);
                    cmd.ExecuteNonQuery();

                    string dateTime = dateTimePicker.Value.ToString("dd/MM/yyyy");
                    setTotalPriceOnDate(dateTime);
                    conn.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                SqlConnection conn = new SqlConnection(connectString);
                conn.Open();
                int id = (int)(long)dataGridView1.Rows[selectedIndex].Cells["MaBanh"].Value;
                string query = "UPDATE products SET note = @Note WHERE id = @ProductId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Note", txtGhiChu.Text);
                cmd.Parameters.AddWithValue("@ProductID", id);
                cmd.ExecuteNonQuery();

                string dateTime = dateTimePicker.Value.ToString("dd/MM/yyyy");
                setTotalPriceOnDate(dateTime);
                conn.Close();
            }
        }

        private void btnChangeDate_Click(object sender, EventArgs e)
        {
            string dateTime = dateTimePicker.Value.ToString("dd/MM/yyyy");
            SqlConnection conn = new SqlConnection(connectString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.GetProductsByDate", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TargetDate", dateTime);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            int total = totalSumPrice(dt);
            string formatTotal = total.ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("vi-VN")) + " đ";
            txtTotal.Text = formatTotal;
            conn.Close();
        }

        private int totalSumPrice(DataTable dt)
        {
            int total = 0;
            SqlConnection conn = new SqlConnection(connectString);
            conn.Open();
            foreach (DataRow row in dt.Rows)
            {

                int id = int.Parse(row["MaBanh"].ToString());
                SqlCommand cmd = new SqlCommand("SELECT dbo.CalculateEachProduct(@ProductID)", conn);
                cmd.Parameters.AddWithValue("@ProductID", id);
                int priceProduct = (int)cmd.ExecuteScalar();
                total += priceProduct;

            }
            conn.Close();

            return total;
        }

        private void setTotalPriceOnDate(string dateTime)
        {
            SqlConnection conn = new SqlConnection(connectString);
            conn.Open();
            dateTime = dateTimePicker.Value.ToString("dd/MM/yyyy");
            SqlCommand cmd1 = new SqlCommand("dbo.GetProductsByDate", conn);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@TargetDate", dateTime);
            cmd1.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            int total = totalSumPrice(dt);
            string formatTotal = total.ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("vi-VN")) + " đ";
            txtTotal.Text = formatTotal;
            conn.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime expirationTime = getExpirationTime();
            if(DateTime.Now < expirationTime && role == "Nhan vien ke toan") {
                button2.Enabled = true;
                button4.Enabled = true;
            } else if(DateTime.Now > expirationTime && role == "Nhan vien ke toan")
            {
                disableButton();
                timer1.Stop();
                MessageBox.Show("Quyền hạn đã hết hạn.", "Thông báo");
            } 
        }
    }
}