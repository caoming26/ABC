using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_bakery.oop
{
    public class ProductOfOrder
    {
        public int ProductId { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }

        public ProductOfOrder(int productId, float price, int quantity)
        {
            ProductId = productId;
            Price = price;
            Quantity = quantity;
        }
    }
}
