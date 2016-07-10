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
            //取得某一隻的最大數量
            var countList = from b in books
                            group b by b.Name into g
                            select new
                            {
                                g.Key,
                                Count = g.Count()
                            };
            int maxCount = countList.Max(x => x.Count);
            //分類不同名字的集合,並計算該集合的 total price
            List<double> total = new List<double> { };
            IEnumerable<IGrouping<String, Book>> query = books.GroupBy(x => x.Name);
            for (int i=0; i<maxCount; i++)
            {
                int sum = 0; //不同名字的總和
                int category = 0; //不同名字集合中有幾個不同名字
                foreach (IGrouping<String, Book> bookGroup in query)
                {
                    var temp = bookGroup.ToList();
                    if (i < temp.Count())
                    {                        
                        sum += temp[i].Price;
                        category += 1;
                    }
                }
                double discount = 1.0;
                switch (category)
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
                    case 5:
                        discount = 0.75;
                        break;
                }
                total.Add(sum * discount);
            }
            return total.Sum();
        }
    }
}
