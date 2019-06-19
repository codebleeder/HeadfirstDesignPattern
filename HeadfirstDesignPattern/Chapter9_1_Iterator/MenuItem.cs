using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter9_1_Iterator
{
    public class MenuItem
    {
        public string Name { get;  }
        public string Description { get; }
        public bool Vegetarian { get;  }
        public double Price { get;  }

        public MenuItem(
            string name,
            string desc,
            bool veg,
            double price
            )
        {
            Name = name;
            Description = desc;
            Vegetarian = veg;
            Price = price;
        }

        
    }
}
