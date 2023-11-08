using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models.Product
{
    public class IProductAddToCart
    {
        public ProductModel Product { get; set; }
        public int Quantity { get; set; }

        public void AddToCard()
        {

        }
    }
}
