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
            switch(count)
            {
                case 2:
                    discount = 0.95;
                    break;
                case 3:
                    discount = 0.9;
                    break;
                case 4:
                    discount = 0.8;
                    break;
            }

            return products.Sum(x => x.Price) * discount;
        }
    }
}
