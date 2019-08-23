using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter12_Compound
{
    public class MallardDuck: IQuackable
    {
        QuackObservable QuackObservable;
        public MallardDuck()
        {
            QuackObservable = new QuackObservable(this);
        }
        public void Quack()
        {
            Console.WriteLine("Mallard duck: Quack!!");
            NotifyObserver();
        }

        private void NotifyObserver()
        {
            QuackObservable.NotifyObservers();
        }

        public IDisposable Subscribe(IObserver<IQuackable> observer)
        {
            return QuackObservable.Subscribe(observer);
        }

        public override string ToString()
        {
            return "Mallard Duck";
        }
    }
}
