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

        public double CalculatePrice(List<Product> products)
        {
            var count = products.GroupBy(x => x.Name).Count();
            double discount = 1;
            if (count == 2)
            {
                discount = 0.95;
            }
            else if(count == 3) 
            {
                discount = 0.9;
            }

            return products.Sum(x => x.Price) * discount;
        }
    }
}
