using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter3_Decorator
{
    public static class Chapter3Tests
    {
        public static void TestBeverage()
        {
            var bev = new Espresso();
            PrintBevAndCost(bev);

            Beverage bev2 = new DarkRoast();
            bev2 = new Mocha(bev2);
            bev2 = new Mocha(bev2);
            bev2 = new Whip(bev2);
            PrintBevAndCost(bev2);

            Beverage bev3 = new Houseblend();
            bev3 = new Soy(bev3);
            bev3 = new Mocha(bev3);
            bev3 = new Whip(bev3);
            PrintBevAndCost(bev3);            
        }

        private static void PrintBevAndCost(Beverage bev)
        {
            Console.WriteLine($"{bev.description} ${bev.Cost()}");
        }
    }
}
