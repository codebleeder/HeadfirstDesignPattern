using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter12_Compound
{
    public class DuckCall : IQuackable
    {
        QuackObservable QuackObservable;
        public DuckCall()
        {
            QuackObservable = new QuackObservable(this);
        }
        public void Quack()
        {
            Console.WriteLine("Kwak");
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
            return "Duck Call";
        }
    }
}
