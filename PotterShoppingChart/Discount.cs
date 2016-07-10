using System;

namespace PotterShoppingChart
{
    internal class Discount : IDiscount
    {
        public  double get(int different)
        {
            //取得不同數量的折扣
            double discount = 1.0;
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