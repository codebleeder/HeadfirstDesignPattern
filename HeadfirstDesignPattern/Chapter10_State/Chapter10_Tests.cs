using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter10_State
{
    public static class Chapter10_Tests
    {
        public static void Test1()
        {
            var gumballMachine = new GumballMachinePrimitive(5);
            Console.WriteLine(gumballMachine.ToString());

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            Console.WriteLine(gumballMachine.ToString());

            gumballMachine.InsertQuarter();
            gumballMachine.EjectQuarter();
            gumballMachine.TurnCrank();
            Console.WriteLine(gumballMachine.ToString());

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.EjectQuarter();
            Console.WriteLine(gumballMachine.ToString());

            gumballMachine.InsertQuarter();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            Console.WriteLine(gumballMachine.ToString());
        }

        public static void Test2()
        {
            var gumballMachine = new GumballMachine(20);
            Console.WriteLine(gumballMachine.ToString());

            for(var i=0; i<20; i++)
            {
                gumballMachine.InsertQuarter();
                gumballMachine.TurnCrank();
            }
            Console.WriteLine(gumballMachine.ToString());
        }
    }
}
