using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_bakery.oop
{
    public class SanPham
    {
        public int MaSo { get; set; }
        public string TenSanPham { get; set; }
        public decimal DonGia { get; set; }
        public  int SoLuong { get; set; }
        public string GhiChu { get; set; }


        public SanPham()
        {
        }

        public SanPham(int maSo, string tenSanPham, decimal donGa, int Soluong, string ghiChu)
        {
            MaSo = maSo;
            TenSanPham = tenSanPham;
            DonGia = donGa;
            GhiChu = ghiChu;
        }

        public override string ToString()
        {
            return $"MaSo: {MaSo}, TenSanPham: {TenSanPham}, DonGa: {DonGia}, Soluong: {SoLuong}, GhiChu: {GhiChu}";
        }
    }
}