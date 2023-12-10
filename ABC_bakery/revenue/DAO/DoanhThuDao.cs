using ABC_bakery.revenue.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_bakery.revenue.DAO
{
    public class DoanhThuDao
    {
        private static DoanhThuDao instance;

        public static DoanhThuDao Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DoanhThuDao();
                }
                return instance;
            }
        }

        public List<DOANHTHU> GetAllDoanhThu()
        {
            List<DOANHTHU> e = new List<DOANHTHU>();
            string query = "Select * from orders "; 
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                DOANHTHU f = new DOANHTHU(dr);
                e.Add(f);
            }
            return e;
        }

        public void DeleteDoanhThu(int id)
        {
            string query = "DeleteOrders @id ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] {id});

        }

        public List<Chi> GetAllChi()
        {
            List<Chi> e = new List<Chi>();
            string query = "Select * from Chi ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                Chi f = new Chi(dr);
                e.Add(f);
            }
            return e;
        }

        public void AddChi(Chi chi)
        {
            string query = "AddChi @Name , @Quantity , @Price ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[]
            {
                chi.name, chi.quantity, chi.price
            });


        }

        public void DeleteChi(int v)
        {
            string query = "DeleteChi @id ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { v });
        }

        public void UpdateChi(Chi chi)
        {
            string query = "UpdateChi  @id , @Name , @Quantity , @Price ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[]
            {
                chi.id, chi.name, chi.quantity, chi.price
            });
        }
    }
}
