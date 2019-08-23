using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter12_Compound
{
    public class RubberDuck : IQuackable
    {
        QuackObservable QuackObservable;
        public RubberDuck()
        {
            QuackObservable = new QuackObservable(this);
        }
        public void Quack()
        {
            Console.WriteLine("Squeak");
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
            return "Rubber Duck";
        }
    }
}
