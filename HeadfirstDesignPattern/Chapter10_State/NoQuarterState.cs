using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter10_State
{
    public class NoQuarterState : State
    {
        private GumballMachine GumballMachine;

        public NoQuarterState(GumballMachine gumballMachine)
        {
            this.GumballMachine = gumballMachine;
        }
        public void InsertQuarter()
        {            
            Console.WriteLine("you inserted a quarter");
            GumballMachine.CurrentState = GumballMachine.HasQuarterState;
        }
        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            GumballMachine.CurrentState = GumballMachine.NoQuarterState;
        }
        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there is no quarter");
        }
        public void Dispense()
        {
            Console.WriteLine("You need to pay first");
        }
        public void Refill(int n)
        {
            Console.WriteLine("you can refill only when all gumballs are sold out");
        }
        public override string ToString()
        {
            return "NO QUARTER";
        }
    }
}
