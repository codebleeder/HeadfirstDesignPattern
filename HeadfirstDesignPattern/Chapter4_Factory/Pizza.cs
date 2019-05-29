using System;
using System.Collections.Generic;

namespace HeadfirstDesignPattern.Chapter4_Factory
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public List<string> Toppings { get; set; }

        public Pizza()
        {
            Toppings = new List<string>();
        }

        public virtual void Cut()
        {
            Console.WriteLine("cut");
        }

        public void Box()
        {
            Console.WriteLine("box");
        }

        public void Bake()
        {
            Console.WriteLine("bake");
        }

        public void Prepare()
        {
            Console.WriteLine("prepare");
        }
    }
}