using System;
using System.Windows.Forms;
using ABC_bakery.category;
using ABC_bakery.customer;
using ABC_bakery.export_cakes;
using ABC_bakery.import_cakes;
using ABC_bakery.revenue;
using BakeryABC.system;
using thongkemuahang;

namespace ABC_bakery.system
{
    public partial class FormABCSystem : Form
    {
        private string role;
        private bool permission;
        private string taiKhoan;
        public FormABCSystem()
        {
            InitializeComponent();

        }

        public FormABCSystem(string role, bool per, string tk)
        {
            InitializeComponent();
            this.role = role;
            this.permission = per;
            this.taiKhoan = tk;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (role == "Nhan vien ke toan" && permission == false)
            {
                btn_phanquyen.Visible = false;
            }
            label4.Text = role+","+permission;
        }

        private void btn_phanquyen_MouseEnter(object sender, EventArgs e)
        {
            btn_phanquyen.BackColor = System.Drawing.ColorTranslator.FromHtml("#f8efab");

        }

        private void button22_Click(object sender, EventArgs e)
        {
            FormNhapBanhNoiBo formNhapBanhNoiBo = new FormNhapBanhNoiBo(role, permission, taiKhoan);
            formNhapBanhNoiBo.ShowDialog();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            FormNhapBanhMuaNgoai form = new FormNhapBanhMuaNgoai(role, permission, taiKhoan);
            form.ShowDialog();
        }

        private void btn_phanquyen_Click(object sender, EventArgs e)
        {
            FormPhanQuyen form = new FormPhanQuyen();
            form.ShowDialog();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            PhieuThu form = new PhieuThu();
            form.ShowDialog();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            PhieuChi form = new PhieuChi();
            form.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ThongKeMuaHang thongKeMuaHang = new ThongKeMuaHang();
            thongKeMuaHang.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ThongKeXuatHang thongKeXuatHang = new ThongKeXuatHang();
            thongKeXuatHang.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm form = new LoginForm();
            form.ShowDialog();
            this.Close();        
        }

        private void button23_Click(object sender, EventArgs e)
        {
            form_XuatHuy form_XuatHuy = new form_XuatHuy();
            form_XuatHuy.ShowDialog();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            form_XuatDi form_XuatDi = new form_XuatDi();    
            form_XuatDi.ShowDialog();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            form_XuatKhac form_xuatkhac = new form_XuatKhac();
            form_xuatkhac.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DanhMucKhachHang danhMucKhachHang = new DanhMucKhachHang();
            danhMucKhachHang.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            form_danhMucBanh form_DanhMucBanh = new form_danhMucBanh();
            form_DanhMucBanh.ShowDialog();
        }
    }
}