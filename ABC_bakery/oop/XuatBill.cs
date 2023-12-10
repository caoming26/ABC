using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_bakery.oop
{
    internal class XuatBill
    {
        public string IDBill { get; set; }
        public string DateXuat { get; set; }
        public Dictionary<SanPham, int> DSSanPhamXuat { get; set; }
        public int TongTien { get; set; }
        public string GhiChu { get; set; }
        public string MaSoNhanVien { get; set; }
        public string TypeBill { get; set; }
        public int GiamGia { get; set; }
        public bool Paid { get; set; }

        public XuatBill()
        {
        }

        public XuatBill(string iDBill, string dateXuat, Dictionary<SanPham, int> dSSanPhamXuat, int tongTien, string ghiChu, string maSoNhanVien, string typeBill, int giamGia, bool paid)
        {
            IDBill = iDBill;
            DateXuat = dateXuat;
            DSSanPhamXuat = dSSanPhamXuat;
            TongTien = tongTien;
            GhiChu = ghiChu;
            MaSoNhanVien = maSoNhanVien;
            TypeBill = typeBill;
            GiamGia = giamGia;
            Paid = paid;
        }
    }
}
