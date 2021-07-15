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
            Apple apple = new Apple("Golden",100,70,5);
            Banana banana = new Banana("Cavendish",100,90,10);
            bag.Calculate(product);
            bag.Calculate(product2);
            bag.Calculate(apple);
            bag.Calculate(banana);

            Console.WriteLine($"Price: {bag.Price} grn");
           
        }
    }
}
