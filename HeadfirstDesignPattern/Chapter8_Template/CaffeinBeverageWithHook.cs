using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter8_Template
{
    public abstract class CaffeinBeverageWithHook
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            
            if(CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        public virtual bool CustomerWantsCondiments()
        {            
            return true;
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
