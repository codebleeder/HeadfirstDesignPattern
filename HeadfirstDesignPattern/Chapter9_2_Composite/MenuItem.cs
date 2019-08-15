using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter9_2_Composite
{
    public class MenuItem: MenuComponent
    {
        public override string Name { get; }
        public override string Description { get; }
        public override bool IsVegetarian { get; }
        public override double Price { get; }
        public MenuItem(
            string name,
            string description,
            bool isVegetarian,
            double price
            )
        {
            Name = name;
            Description = description;
            IsVegetarian = isVegetarian;
            Price = price;
        }

        override public void Print()
        {
            var isVeg = IsVegetarian ? "(v)" : " ";
            Console.WriteLine($"{Name} {isVeg} {Price} --- {Description}");
        }
    }
}
