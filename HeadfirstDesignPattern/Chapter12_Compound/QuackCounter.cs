using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter12_Compound
{
    public class QuackCounter : IQuackable
    {
        IQuackable Duck;
        public static int NumberOfQuacks { get; private set; }
        public QuackCounter(IQuackable duck)
        {
            Duck = duck;
        }
        public void Quack()
        {
            Duck.Quack();
            NumberOfQuacks += 1;
        }

        public IDisposable Subscribe(IObserver<IQuackable> observer)
        {
            return Duck.Subscribe(observer);
        }
    }
}
