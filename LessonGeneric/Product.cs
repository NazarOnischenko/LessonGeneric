using System;

namespace LessonGeneric
{
    public class Product
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Calories { get; set; }
        public int Price { get; set; }
        public Product(string name,int weight,int calories, int price)
        {
            if (name == string.Empty ||name == null)
            {
                throw new ArgumentNullException("Name must be not empty!");
            }
            if (weight <= 0)
            {
                throw new ArgumentNullException("Weight must bo bigger than 0!");
            }
            if (calories < 0)
            {
                throw new ArgumentNullException("Calories must not be negative!");
            }
            if (price <= 0)
            {
                throw new ArgumentNullException("Price must bo bigger than 0!");
            }
            Name = name;
            Weight = weight;
            Calories = calories;
            Price = price;
        }
    }
}
