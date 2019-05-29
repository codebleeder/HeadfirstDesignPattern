using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter1
{
    public class FlyRocketPowered : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket");
        }
    }
}
