using System;
using System.Collections.Generic;
using System.Text;
using UsingCSharpFeatures.Chapter1_Strategy;

namespace UsingCSharpFeatures.Chapter1_Strategy
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            this.QuackAction = QuackBehavior.Quack;
            this.FlyAction = FlyBehavior.FlyWithWings;
        }

        public override void display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}
