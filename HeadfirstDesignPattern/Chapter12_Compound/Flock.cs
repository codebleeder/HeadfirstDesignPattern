using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter12_Compound
{
    public class Flock : IQuackable
    {
        List<IQuackable> Quackers;

       // public List<IObserver<IQuackable>> Observers { get; }
        QuackObservable QuackObservable;
        public Flock()
        {
            Quackers = new List<IQuackable>();
           // Observers = new List<IObserver<IQuackable>>();
            QuackObservable = new QuackObservable(this);
        }
        public void Add(IQuackable quacker)
        {
            Quackers.Add(quacker);
        }
        public void Quack()
        {
            foreach(var quacker in Quackers)
            {
                quacker.Quack();
                
            }
        }

        public IDisposable Subscribe(IObserver<IQuackable> observer)
        {
            foreach (var quacker in Quackers)
            {
                quacker.Subscribe(observer);
            }
            return QuackObservable.Subscribe(observer);
        }

        public override string ToString()
        {
            return "Flock";
        }
    }
}
