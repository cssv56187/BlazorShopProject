using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models.ShoppingCart
{
    public class ShoppingCartModel
    {
        public ShoppingCartModel() { }

        public IList<ShoppingCartItemModel>? Items { get; set; }
    }
}
