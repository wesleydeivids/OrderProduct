using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace OrderProduct.Entities
{
    class OrderItem
    {
        public int Quantify { get; set; }
         public double Price { get; set; }
        public Product Product { get; set; }
        public OrderItem() 
        { 
        }

        public OrderItem(int quantify, double price, Product product)
        {
            Quantify = quantify;
            Price = price;
            Product = product;
        }

        public double Subtotal() {
            return Quantify * Price;
        }
    
        public override string ToString() {
            return Product.Name
                + ", "
                + Price.ToString("f2", CultureInfo.InvariantCulture)
                + ", quantify "
                + Quantify
                + " ,subtotal"
                + Subtotal().ToString("f2", CultureInfo.InvariantCulture);
                
                
                
                
                
                
        }


    }
}
