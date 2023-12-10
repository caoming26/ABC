using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_bakery.revenue.DTO
{
    public class Chi
    {
        public Chi(int id, string name, int quantity, double price)
        {
            this.id = id;
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }
        public Chi(string name, int quantity, double price)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }
        public Chi(DataRow row)
        {
            this.id = Convert.ToInt32(row["id"].ToString());
            this.name = row["name"].ToString();
            this.quantity = Convert.ToInt32(row["quantity"].ToString());
            this.price = (double)Convert.ToDecimal(row["price"].ToString());
        }

        public int id {  get; set; }
        public string name { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
    }
}
