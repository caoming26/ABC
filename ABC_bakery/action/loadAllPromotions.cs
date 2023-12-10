using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_bakery.action
{
    internal class loadAllPromotions
    {
        private string connectionString = "Data Source=DESKTOP-R7ME920\\MINH;Initial Catalog=ABC_bakery;Integrated Security=True";
        public ArrayList listPromotions = new ArrayList();
        public ArrayList loadData()
        {
            listPromotions.Clear();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("getAllPromotions", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    connection.Close();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        listPromotions.Add(row);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return this.listPromotions;
        }
    }
}
