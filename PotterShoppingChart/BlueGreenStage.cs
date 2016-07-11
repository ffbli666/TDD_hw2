using System;
using System.Collections.Generic;
using System.Linq;

namespace PotterShoppingCart
{
    internal class BlueGreenStage : IStage
    {
        private List<Book> _books = new List<Book> { };
        public void Add(Book book)
        {
            this._books.Add(book);
        }

        public double Calculate()
        {
            int maxCount = getMaxCountOfTheSameName(this._books);
            //分類不同顏色的集合,並計算該集合的 amount price
            List<double> amount = new List<double> { };
            IEnumerable<IGrouping<String, Book>> query = this._books.GroupBy(x => x.Name);
            for (int i = 0; i < maxCount; i++)
            {
                int sum = 0; //不同顏色的總和
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

                if (different == 2)
                {
                    amount.Add(sum * 0.85);
                }
                else
                {
                    amount.Add(sum);
                }
                
            }
            return amount.Sum();
        }

        private int getMaxCountOfTheSameName(List<Book> books)
        {
            //取得同名書中的最大數量
            var countList = from b in books
                            group b by b.Color into g
                            select new
                            {
                                g.Key,
                                Count = g.Count()
                            };
            return countList.Max(x => x.Count);
        }
    }
}