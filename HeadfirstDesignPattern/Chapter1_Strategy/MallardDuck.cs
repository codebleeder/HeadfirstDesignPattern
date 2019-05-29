using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter1
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            this.quackBehavior = new RegularQuack();
            this.flyBehavior = new FlyWithWings();
        }

        public override void display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}
