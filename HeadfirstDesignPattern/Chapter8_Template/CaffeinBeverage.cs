using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter8_Template
{
    public abstract class CaffeinBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        public abstract void AddCondiments();

        public void PourInCup()
        {
            Console.WriteLine("pour into cup");
        }

        public abstract void Brew();

        public void BoilWater()
        {
            Console.WriteLine("boil water");
        }
    }
}
