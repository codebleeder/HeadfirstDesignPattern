using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter8_Template
{
    public class Chapter8Tests
    {
        public static void Test1()
        {
            var coffeeWithHook = new CoffeeWithHook();
            coffeeWithHook.PrepareRecipe();
        }

        public static void Test2()
        {
            Duck[] ducks = {
                new Duck("Daffy", 8),
                new Duck("Dewey", 2),
                new Duck("Howard", 7),
                new Duck("Louie", 2),
                new Duck("Donald", 10),
                new Duck("Huey", 2),
            };
            Console.WriteLine("before sorting:");
            Display(ducks);
            Array.Sort(ducks);
            Console.WriteLine("after sorting:");
            Display(ducks);
        }

        private static void Display(Duck[] ducks)
        {
            foreach(var duck in ducks)
            {
                Console.WriteLine(duck.ToString());
            }
        }
    }
}
