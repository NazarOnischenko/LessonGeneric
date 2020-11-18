using System;
using System.Collections.Generic;
using System.Text;

namespace LessonGeneric
{
    class Bag <T>
        where T:Product
    {
        public int Price { get; private set; } = 0;
        public Bag()
        {
            
        }
        public void Calculate(T product)
        {
            Price += product.Weight / 100 * product.Price;
        }
    }
}
