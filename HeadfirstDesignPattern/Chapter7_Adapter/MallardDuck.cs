using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter7_Adapter
{
    public class MallardDuck : Duck
    {
        public void Fly()
        {
            Console.WriteLine("Mallard duck fly");
        }

        public void Quack()
        {
            Console.WriteLine("Mallard duck quack");
        }
    }
}
