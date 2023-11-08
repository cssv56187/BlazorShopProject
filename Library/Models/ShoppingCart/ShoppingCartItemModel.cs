using Library.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models.ShoppingCart
{
    public class ShoppingCartItemModel
    {
        public ShoppingCartItemModel(ProductModel product, int quantity) 
        { 
            Product = product;
            Quantity = quantity;
        }

        public void UpdateQuantity(ProductModel product, int quantity)
        {

        }

        public ProductModel Product { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

    }
}
