using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter1
{
    public class RegularQuack: QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Regular quack");
        }
    }
}
