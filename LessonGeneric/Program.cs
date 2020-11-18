using System;
using System.Collections.Generic;

namespace LessonGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product("Apple",400,100,5);
            var product2 = new Product("Banana",300,200,20);
            Bag<Product> bag = new Bag<Product>();
            bag.Calculate(product);
            bag.Calculate(product2);
            Console.WriteLine($"Price: {bag.Price} grn");
            //var list = new List<int>();
            //var dict = new Dictionary<int, string>();
        }
    }
}
