using System;
using System.Collections.Generic;
using System.Text;

namespace task2_product_
{
    class Milk : Product
    {
        public double Volume;
        public string FatRate;

        public Milk(string name, int price, int count, int totalincome, double volume, string fatrate) : base
            (name, price, count, totalincome)
        {
            Volume = volume;
            FatRate = fatrate;
        }
        public string Over()
        {
            return Info() + $"Volume{Volume}\nFatRate{FatRate}";
        }
    }
}

