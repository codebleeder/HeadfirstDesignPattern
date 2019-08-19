using HeadfirstDesignPattern.Chapter10_State;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter11_Proxy
{
    public static class Chapter11_Tests
    {
        public static void Test1()
        {
            Console.WriteLine("Enter location and count:");
            var argsLine = Console.ReadLine();
            var args = argsLine.Split();
            var machine = new GumballMachine(Int32.Parse(args[1]), args[0]);
            var monitor = new GumballMonitor(machine);
            monitor.Report();
        }
    }
}
