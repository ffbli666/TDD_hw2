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
            return CalculatePrice(books, new Discount());
        }
        public double CalculatePrice(List<Book> books, IDiscount discount)
        {
            int maxCount = getMaxCountOfTheSameName(books);
            //分類不同名字的集合,並計算該集合的 amount price
            List<double> amount = new List<double> { };
            IEnumerable<IGrouping<String, Book>> query = books.GroupBy(x => x.Name);
            for (int i = 0; i < maxCount; i++)
            {
                int sum = 0; //不同名字的總和
                int different = 0; //集合中有幾個不同名字
                foreach (IGrouping<String, Book> bookGroup in query)
                {
                    var temp = bookGroup.ToList();
                    if (i < temp.Count())
                    {
                        sum += temp[i].Price;
                        different += 1;
                    }
                }
                amount.Add(sum * discount.get(different));
            }
            return amount.Sum();
        }
        private int getMaxCountOfTheSameName(List<Book> books)
        {
            //取得同名書中的最大數量
            var countList = from b in books
                            group b by b.Name into g
                            select new
                            {
                                g.Key,
                                Count = g.Count()
                            };
            return countList.Max(x => x.Count);
        }
    }
}
