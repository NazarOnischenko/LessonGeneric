using System;
using System.Collections.Generic;
using System.Text;

namespace LessonGeneric
{
    public class Banana: Product
    {
        public Banana(string name, int weight, int calories,int price) : base(name, weight, calories,price)
        {
        }
    }
}
