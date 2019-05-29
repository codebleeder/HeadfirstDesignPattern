using System;
using System.Collections.Generic;
using System.Text;
using UsingCSharpFeatures.Chapter1_Strategy;

namespace UsingCSharpFeatures.Chapter1_Strategy
{
    public class ModelDuck: Duck
    {
        public ModelDuck()
        {
            FlyAction = FlyBehavior.FlyNoWay;
            QuackAction = QuackBehavior.MuteQuack;
        }

       
        public override void display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
