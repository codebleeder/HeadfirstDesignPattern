using System;
using System.Collections.Generic;
using System.Text;

namespace UsingCSharpFeatures.Chapter1_Strategy
{
    public abstract class Duck
    {
        public Action FlyAction;
        public Action QuackAction;

        public Duck() { }

        public abstract void display();

        public void SetFlyBehavior(Action fb)
        {
            this.FlyAction = fb;
        }

        public void SetQuackBehavior(Action qb)
        {
            this.QuackAction = qb;
        }

        public void performFly()
        {
            FlyAction();
        }

        public void performQuack()
        {
            QuackAction();
        }

        public void swim()
        {
            System.Console.WriteLine("all ducks float");
        }
    }
}
