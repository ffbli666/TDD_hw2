using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingChart
{
    public class Sell
    {
        public int CalculatePrice(List<Book> books)
        {
            return books.Sum(x => x.Price);
        }
    }
}
