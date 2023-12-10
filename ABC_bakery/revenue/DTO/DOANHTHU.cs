using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_bakery.revenue.DTO
{
    public class DOANHTHU
    {
        public DOANHTHU(int id, float price, string name, string address, string status, string type)
        {
            this.id = id;
            this.price = price;
            this.name = name;
            this.address = address;
            this.status = status;
            this.type = type;
        }

        public DOANHTHU(DataRow row)
        {
            this.id = Convert.ToInt32(row["id"].ToString());
            this.price = (float)Convert.ToDecimal(row["price"].ToString());
            this.name = row["name"].ToString();
            this.address = row["address"].ToString();
            this.status = row["status"].ToString();
            this.type = row["type"].ToString();
        }

        public int id { get; set; }
        public float price { get; set; }
        public string name {  get; set; }
        public string address {  get; set; }
        public string status {  get; set; }
        public string type {  get; set; }



    }
}
