using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_bakery.category
{
    public partial class form_danhMucBanh : Form
    {
        private string connectionString = "Data Source=DESKTOP-R7ME920\\MINH;Initial Catalog=ABC_bakery;Integrated Security=True";
        public form_danhMucBanh()
        {
            InitializeComponent();
            LoadData();
        }

        //Data Source=DESKTOP-R7ME920\MINH;Initial Catalog=ABC_bakery;Integrated Security=True

        

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    

                    SqlCommand command = new SqlCommand("danhMucBanh_select", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    connection.Close();



                    // Đổ dữ liệu vào DataTable
                    //DataColumnCollection dataColumns = dataTable.Columns;
                    //DataGridViewColumnCollection dataGridViewColumns = dataGridView1.Columns;

                    //for (int i = 0; i < dataColumns.Count; i++)
                    //{

                    //    dataGridViewColumns[i].DataPropertyName = dataColumns[i].ColumnName;
                    //    // MessageBox.Show(dataColumns[i].ColumnName);
                    //}
                    dataGridView1.Rows.Clear();

                    foreach (DataRow item in dataTable.Rows)
                    {
                        string categories_name = item["categories_name"].ToString();
                        string id = item["id"].ToString();
                        string name = item["name"].ToString();
                        string price_bought = item["price_bought"].ToString();
                        string price_sell = item["price_sell"].ToString();
                        string is_active = item["is_active"].ToString();
                        dataGridView1.Rows.Add(categories_name, id, name, price_bought, price_sell, is_active);
                    }

                   // dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {

        }
    }
}

