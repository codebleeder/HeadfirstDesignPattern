using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter10_State
{
    public class SoldOutState : State
    {
        private GumballMachine GumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            this.GumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("No more gumballs. You can't insert quarters");
        }
        public void EjectQuarter()
        {
            Console.WriteLine("You haven't inserted any Quarter");
        }
        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there are no gumballs");
        }
        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }
        public void Refill(int n)
        {
            Console.WriteLine("Refilling gumballs");
            GumballMachine.Count = n;
            GumballMachine.CurrentState = GumballMachine.NoQuarterState;
        }
        public override string ToString()
        {
            return "SOLD OUT";
        }
    }
}
