using System;
using System.Collections.Generic;
using System.Text;

namespace UsingCSharpFeatures.Chapter1_Strategy
{
    public class QuackBehavior
    {
        public static void Quack()
        {
            Console.WriteLine("quack");
        }

        public static void MuteQuack()
        {
            Console.WriteLine("<<Silence>>");
        }

        public static void Squeak()
        {
            Console.WriteLine("Squeak!");
        }
    }
}
