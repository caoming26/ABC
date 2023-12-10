using ABC_bakery.revenue.DAO;
using ABC_bakery.revenue.DTO;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_bakery.revenue
{
    public partial class PhieuThu : Form
    {
        //private string connectString = "Data Source=DESKTOP-R7ME920\\MINH;Initial Catalog=ABC_bakery;Integrated Security=True;TrustServerCertificate=True";
        public PhieuThu()
        {
            InitializeComponent();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private List<DOANHTHU> DOANHTHUs {  get; set; }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void PhieuThu_Load(object sender, EventArgs e)
        {
            loadAllDataForOrders();
            loadDataforDataGirdView();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void loadDataforDataGirdView()
        {
            loadAllDataForOrders();
            dataGridViewDoanhThu.Controls.Clear();
            dataGridViewDoanhThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDoanhThu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewDoanhThu.DataSource = null;
            BindingList<DOANHTHU> list = new BindingList<DOANHTHU>(DOANHTHUs);
            dataGridViewDoanhThu.DataSource = list;
        }

        private void loadAllDataForOrders()
        {
            DOANHTHUs = DoanhThuDao.Instance.GetAllDoanhThu();
        }

        private void dataGridViewDoanhThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            lblidOrders.Text = dataGridViewDoanhThu.SelectedCells[0].OwningRow.Cells["id"].Value.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblidOrders.Text.ToString());
            DoanhThuDao.Instance.DeleteDoanhThu(id);
            loadAllDataForOrders();
            loadDataforDataGirdView();
            MessageBox.Show("Delete success!");
        }
    }
}
