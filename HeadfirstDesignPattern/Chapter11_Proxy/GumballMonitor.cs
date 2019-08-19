using HeadfirstDesignPattern.Chapter10_State;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter11_Proxy
{
    public class GumballMonitor
    {
        GumballMachine Machine;
        public GumballMonitor(GumballMachine machine)
        {
            Machine = machine;
        }
        public void Report()
        {
            Console.WriteLine($"{Machine.ToString()}    Location: {Machine.Location}");
        }
    }
}
