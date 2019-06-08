using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter7_Adapter
{
    public static class Chapter7Tests
    {
        public static void Test1TurkeyAdapter()
        {
            var mallard = new MallardDuck();
            var wildTurkey = new WildTurkey();
            var turkeyAdapter = new TurkeyAdapter(wildTurkey);

            Console.WriteLine("wild turkey says...");
            wildTurkey.Fly();
            wildTurkey.Gobble();

            Console.WriteLine("the duck says...");
            TestDuck(mallard);

            Console.WriteLine("the turkey adapter says...");
            TestDuck(turkeyAdapter);
        }

        private static void TestDuck(Duck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
