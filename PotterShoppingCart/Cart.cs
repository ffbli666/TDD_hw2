using System;
using System.Collections.Generic;
using System.Linq;

namespace PotterShoppingCart
{
    public class Cart
    {
        public double CalculatePrice(List<Product> products)
        {
            /*
                .       100                     ^
            . . .       300*0.9                 | 形成的每個組合(上下)  
            1 2 3 4 5                           |
            <-------> 滿足優惠條件的組成(左右)  v
            */
            var groupByName = products.GroupBy(x => x.Name);
            //取得最大數量集數的本數
            int maxCount = groupByName.Max(x=>x.Count());
            var nameList = groupByName.ToDictionary(x => x.Key, x => x.ToList());
            List<double> amountList = new List<double> { };
            for (int i = 0; i < maxCount; i++)
            {
                int sum = 0; //這組優惠集合中的總和
                int different = 0; //這組優惠集合中有幾個不同集數的書
                foreach (var item in nameList)
                {
                    var list = item.Value;
                    if (i < list.Count())
                    {
                        sum += list[i].Price;
                        different += 1;
                    }
                }
                amountList.Add(sum * GetDiscount(different));
            }
            return amountList.Sum();
        }

        private double GetDiscount(int different)
        {
            double discount = 1;
            switch (different)
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
            return discount;
        }
    }
}