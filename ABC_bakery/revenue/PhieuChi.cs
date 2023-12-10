using ABC_bakery.revenue.DAO;
using ABC_bakery.revenue.DTO;
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
    public partial class PhieuChi : Form
    {
        private List<Chi> Chis { get; set; }
        public PhieuChi()
        {
            InitializeComponent();
        }
        private void loadAllDataForOrders()
        {
            Chis = DoanhThuDao.Instance.GetAllChi();
        }
        private void PhieuChi_Load(object sender, EventArgs e)
        {
            loadAllDataForOrders();
            loadDataforDataGirdView();
        }

        private void loadDataforDataGirdView()
        {
            loadAllDataForOrders();
            dataGridViewChi.Controls.Clear();
            dataGridViewChi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewChi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewChi.DataSource = null;
            BindingList<Chi> list = new BindingList<Chi>(Chis);
            dataGridViewChi.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tbxName.Text)
                || !string.IsNullOrEmpty(tbxQuantity.Text) || !string.IsNullOrEmpty(tbxPrice.Text)
                )
            {
                if (!string.IsNullOrEmpty(tbxPrice.Text) && double.TryParse(tbxPrice.Text, out _))
                {
                    Chi chi = new Chi(
                            tbxName.Text.ToString(),
                            Convert.ToInt32(tbxQuantity.Text.ToString()),
                            (double)Convert.ToDecimal(tbxPrice.Text.ToString())
                        );
                    DoanhThuDao.Instance.AddChi(chi);
                    MessageBox.Show("Thêm thành công!");
                    loadAllDataForOrders();
                    loadDataforDataGirdView();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng!");
                }
            } else
            {
                MessageBox.Show("Vui lòng nhập thông tin!");

            }
        }

        private void dataGridViewChi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewChi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblIdChi.Text = dataGridViewChi.SelectedCells[0].OwningRow.Cells["id"].Value.ToString();
            tbxName.Text = dataGridViewChi.SelectedCells[0].OwningRow.Cells["name"].Value.ToString();
            tbxQuantity.Text = dataGridViewChi.SelectedCells[0].OwningRow.Cells["quantity"].Value.ToString();
            tbxPrice.Text = dataGridViewChi.SelectedCells[0].OwningRow.Cells["price"].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxName.Text))
            {
                DoanhThuDao.Instance.DeleteChi(Convert.ToInt32(lblIdChi.Text));
                MessageBox.Show("Xóa thành công!");
                loadAllDataForOrders();
                loadDataforDataGirdView();
                tbxName.Text = "";
                tbxQuantity.Text = "";
                tbxPrice.Text = "";
            } else
            {
                MessageBox.Show("Chọn thứ cần xóa");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxName.Text))
            {
                Chi chi = new Chi(
                        tbxName.Text.ToString(),
                            Convert.ToInt32(tbxQuantity.Text.ToString()),
                            (double)Convert.ToDecimal(tbxPrice.Text.ToString())
                    );

                chi.id = Convert.ToInt32(lblIdChi.Text);
                DoanhThuDao.Instance.UpdateChi(chi);
                MessageBox.Show("Sửa thành công!");
                loadAllDataForOrders();
                loadDataforDataGirdView();
                tbxName.Text = "";
                tbxQuantity.Text = "";
                tbxPrice.Text = "";
            }
            else
            {
                MessageBox.Show("Chọn thứ cần xóa");
            }
        }
    }
}
