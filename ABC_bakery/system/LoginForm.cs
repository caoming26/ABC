using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BakeryABC.system;

namespace ABC_bakery.system

{
    public partial class LoginForm : Form
    {
        private string connectString = "Data Source=DESKTOP-R7ME920\\MINH;Initial Catalog=ABC_bakery;Integrated Security=True;TrustServerCertificate=True";
        private bool permission = false;
        private string taiKhoan;


        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT name FROM roles", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string name = reader["name"].ToString();
                comboBox1.Items.Add(name);
            }
            reader.Close();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                SqlConnection conn = new SqlConnection(connectString);
                conn.Open();
                string tk = txtTaiKhoan.Text;
                taiKhoan = txtTaiKhoan.Text;
                string mk = txtMatKhau.Text;
                string selectedCbb = comboBox1.Text;
                int id = 0;
                if (selectedCbb == "Giam doc")
                {
                    id = 1;
                }
                else if (selectedCbb == "Nhan vien ke toan")
                {
                    id = 2;
                }
                string query = "SELECT * FROM users WHERE name = '" + tk + "' AND password = '" + mk + "' AND role_id = '" + id + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    this.Hide();

                    DateTime expirationTime = getExpirationTime();
                    if (expirationTime > DateTime.Now)
                    {
                        permission = true;
                        
                    }
                    FormABCSystem formABCSystem = new FormABCSystem(selectedCbb, permission, tk);
                    formABCSystem.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại tài khoản, mật khẩu hoặc quyền truy cập");
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private DateTime getExpirationTime()
        {
            DateTime expirationTime = new DateTime();
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string query = "SELECT expirationTime FROM Users WHERE name = @Name AND role_id = 2";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", txtTaiKhoan.Text);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Lấy giá trị expirationTime từ cột đầu tiên (0)
                    expirationTime = reader.GetDateTime(0);
                    //MessageBox.Show($"Giá trị expirationTime: {expirationTime}", "Thông báo");
                    return expirationTime;

                }
                return expirationTime;
            }
        }
    }
}
