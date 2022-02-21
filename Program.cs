using System;

namespace task2_product_
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Konfet", 5, 8, 0);
            Milk milk = new Milk("konfet", 10, 20, 1, 5, "1%");
            Console.WriteLine(product.Info());
            Console.WriteLine(product.Sell());
            Console.WriteLine(milk.Over());
        }
    }
}
