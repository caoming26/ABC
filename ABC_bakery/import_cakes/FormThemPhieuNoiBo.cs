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


namespace ABC_bakery.import_cakes
{
    public partial class FormThemPhieuNoiBo : Form
    {
        string tenBanh;
        int ton, soLuong, gia;
        string connectString = "Data Source=DESKTOP-R7ME920\\MINH;Initial Catalog=ABC_bakery;Integrated Security=True;TrustServerCertificate=True";
        public FormThemPhieuNoiBo()
        {
            InitializeComponent();
            
        }

        private void FormThemPhieu_Load(object sender, EventArgs e)
        {
            loadCbbCategories();
        }

       

        private void loadCbbCategories()
        {
            SqlConnection conn = new SqlConnection(connectString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT name FROM categories", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string name = reader["name"].ToString();
                cbbCategories.Items.Add(name);
            }
            reader.Close();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tenBanh = txtTenBanh.Text;
            soLuong = int.Parse(txtSoLuong.Text);

            gia = int.Parse(txtGia.Text);
            DateTime ex = DateTime.Now;
            DateTime cr = DateTime.Now;
            DateTime up = DateTime.Parse("2023-10-29");

            SqlConnection conn = new SqlConnection(connectString);
            conn.Open();
            string query1 = "SELECT id FROM categories WHERE name = '" + cbbCategories.SelectedItem.ToString() + "'";
            string query = "INSERT INTO products (category_id, name, price, is_active, amount, expiration_date, created_at, updated_at, prefix) VALUES (@Category_id, @Name, @Price, @Is_active, @Amount, @Expiration_date, @Created_at, @Updated_at, @Prefix)";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlCommand cmd1 = new SqlCommand(query1, conn);
            int id = (int)(long)cmd1.ExecuteScalar();
            cmd.Parameters.AddWithValue("@Category_id", id);
            cmd.Parameters.AddWithValue("@Name", tenBanh);
            cmd.Parameters.AddWithValue("@Price", gia);
            cmd.Parameters.AddWithValue("@Is_active", 1);
            cmd.Parameters.AddWithValue("@Amount", soLuong);
            cmd.Parameters.AddWithValue("@Expiration_date", ex);
            cmd.Parameters.AddWithValue("@Created_at", cr);
            cmd.Parameters.AddWithValue("@Updated_at", up);
            cmd.Parameters.AddWithValue("@Prefix", "SP");

            SqlDataReader myReader = cmd.ExecuteReader();
            MessageBox.Show("Save");
            while (myReader.Read())
            {

            }
            conn.Close();
            this.Close();

        }
    }
}
