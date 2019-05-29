using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter1
{
    class FlyWithWings: FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying");
        }
    }
}
