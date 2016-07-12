using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart
{
    public class Cart
    {
        public int CalculatePrice()
        {
            throw new NotImplementedException();
        }

        public object CalculatePrice(List<Product> products)
        {
            return products.Sum(x => x.Price);
        }
    }
}
