
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakeryABC.system
{
    public partial class FormPhanQuyen : Form
    {
        private string connectString = "Data Source=DESKTOP-R7ME920\\MINH;Initial Catalog=ABC_bakery;Integrated Security=True;TrustServerCertificate=True";
        public FormPhanQuyen()
        {
            InitializeComponent();
        }

        private void FormPhanQuyen_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT name FROM users WHERE role_id = 2", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string name = reader["name"].ToString();
                cbbTaiKhoan.Items.Add(name);
            }
            reader.Close();
            conn.Close();
        }

        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            string tk = cbbTaiKhoan.SelectedItem.ToString();
            string per = cbbQuyen.SelectedItem.ToString();
            DateTime expirationTime = dateTimePicker2.Value;
            SqlConnection conn = new SqlConnection(connectString);
            conn.Open();
            string query = "UPDATE users SET permission = '" + per + "', expirationTime = '" + expirationTime + "' WHERE name = '" + tk + "';";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) { }
            conn.Close() ;
            MessageBox.Show("Thành công");
        }
    }
}
