using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter1
{
    public abstract class Duck
    {
        public FlyBehavior flyBehavior;
        public QuackBehavior quackBehavior;

        public Duck() { }

        public abstract void display();

        public void setFlyBehavior(FlyBehavior fb)
        {
            this.flyBehavior = fb;
        }

        public void setQuackBehavior(QuackBehavior qb)
        {
            this.quackBehavior = qb;
        }

        public void performFly()
        {
            flyBehavior.Fly();
        }

        public void performQuack()
        {
            quackBehavior.Quack();
        }

        public void swim()
        {
            System.Console.WriteLine("all ducks float");
        }
    }
}
