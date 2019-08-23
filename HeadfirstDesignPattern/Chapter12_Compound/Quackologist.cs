using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter12_Compound
{
    public class Quackologist : IObserver<IQuackable>
    {
        public void OnCompleted()
        {
            Console.WriteLine("Not listening to duck anymore");
        }

        public void OnError(Exception error)
        {
            
        }

        public void OnNext(IQuackable value)
        {
            Console.WriteLine($"Quackologist: {value.ToString()} just quacked");
        }
    }
}
