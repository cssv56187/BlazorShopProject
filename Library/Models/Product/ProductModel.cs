using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models.Product
{
    public class ProductModel
     {
        public ProductModel (string sku, string name, decimal price, string image)
        {
            Sku = sku;
            Name = name;
            Price = price;
            Image = image;
        }

        public string? Sku { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public string? Image {  get; set; }
        public string? Slug { get; set; }
        public string? FullUrl { get; set; }

    }
}
