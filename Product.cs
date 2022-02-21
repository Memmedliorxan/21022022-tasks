using System;
using System.Collections.Generic;
using System.Text;

namespace task2_product_
{
    class Product
    {
        public string Name;
        public int Price;
        public int Count;
        public int TotalIncome;

        public Product(string name, int price, int count, int totalincome)
        {
            Name = name;
            Price = price;
            Count = count;
            TotalIncome = totalincome;
        }


        public string Sell()
        {
            if (Count == 0)
            {
                return "mehsul yoxdur";
            }
            else
            {
                Count++;
                TotalIncome = TotalIncome + Price;
                return "mehsul davam edir";
            }
        }
        public string Info()
        {
            return $"Name={Name}\nPrice={Price}\nCount={Count}\nTotalIncome={TotalIncome}";
        }
    }
}
