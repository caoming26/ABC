using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABC_bakery.oop;
using ABC_bakery;


namespace ABC_bakery.action
{
    internal class loadFormXuatKhac
    {
        private string connectionString = "Data Source=DESKTOP-R7ME920\\MINH;Initial Catalog=ABC_bakery;Integrated Security=True";
        string date = "";


        public ArrayList LoadData(string currentDate) //DataGridView
        {
            var listBill = new ArrayList();
            this.date = currentDate;
            //Console.WriteLine(date1);

            if (string.IsNullOrEmpty(date))
            {
                throw new ArgumentException($"'{nameof(date)}' cannot be null or empty.", nameof(date));
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Nhận giá trị date trong datatimePicker hiện tại
                    //kết nối datapase và thực hiện xuất phiếu theo ngày
                    SqlCommand command = new SqlCommand("xuat_khac", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("date", date);
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    connection.Close();

                    // Duyệt qua từng dòng trong DataTable
                    if (dataTable.Rows.Count > 0)
                    {
                        foreach (DataRow row in dataTable.Rows)
                        {
                            // Lấy giá trị từng cột 
                            listBill.Add(row);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return listBill;
        }

        public HashSet<int> getOrderID()
        {
            HashSet<int> result = new HashSet<int>();

            ArrayList listBill = LoadData(date);
            foreach (DataRow row in listBill)
            {
                if (row != null)
                {
                    result.Add(Convert.ToInt32(row["order_id"].ToString()));
                }
            }
            return result;
        }
    }
}
