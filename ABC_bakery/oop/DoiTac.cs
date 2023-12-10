using System;

namespace ABC_bakery.oop
{
    internal class DoiTac
    {
        public string SDTDoiTac { get; set; }
        public string TenDoiTac { get; set; }
        public string GhiChu { get; set; }

        public DoiTac()
        {
            GhiChu = "";
            TenDoiTac = "";
            SDTDoiTac = "";
        }

        public DoiTac(string sDTDoiTac, string tenDoiTac, string ghiChu)
        {
            SDTDoiTac = sDTDoiTac;
            TenDoiTac = tenDoiTac;
            GhiChu = ghiChu;
        }
    }
}