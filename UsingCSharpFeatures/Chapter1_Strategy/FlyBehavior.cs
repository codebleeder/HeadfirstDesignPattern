using System;
using System.Collections.Generic;
using System.Text;

namespace UsingCSharpFeatures.Chapter1_Strategy
{
    public class FlyBehavior
    {
        public static void FlyNoWay()
        {
            Console.WriteLine("I can't fly");
        }

        public static void FlyRocketPowered()
        {
            Console.WriteLine("I'm flying with a rocket");
        }

        public static void FlyWithWings()
        {
            Console.WriteLine("I'm flying");
        }
    }
}
