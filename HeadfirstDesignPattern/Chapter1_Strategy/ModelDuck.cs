using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter1
{
    public class ModelDuck: Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new RegularQuack();
        }

       
        public override void display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
