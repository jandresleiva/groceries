using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Groceries.Models
{
    public class Purchase
    {
        public class Detail
        {
            public int Id { get; set; }
            public Product Product { get; set; }
            public int Quantity { get; set; }
            public double Price { get; set; }

            public Detail(Product newProduct, int newQty)
            {
                Product = newProduct;
                Quantity = newQty;
                Price = Product.Price * Quantity;
            }

            public Detail()
            {
            }
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Market Market { get; set; }
        public List<Detail> Details { get; set; }
        public double Total { get; set; }
    }
}
