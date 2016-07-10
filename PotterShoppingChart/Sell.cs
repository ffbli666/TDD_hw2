using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingChart
{
    public class Sell
    {
        public double CalculatePrice(List<Book> books)
        {
            IEnumerable<IGrouping<String, Book>> query = books.GroupBy(x => x.Name);
            double discount = 1.0;
            switch (query.Count())
            {
                case 2:
                    discount = 0.95;
                    break;
                    
            }
            return books.Sum(x => x.Price) * discount;
        }
    }
}
