using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter10_State
{
    public class HasQuarterState : State
    {
        private GumballMachine GumballMachine;
        private Random RandomWinner;
        public HasQuarterState(GumballMachine gumballMachine)
        {
            this.GumballMachine = gumballMachine;
            RandomWinner = new Random(System.DateTime.Now.Millisecond);
        }
        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }
        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            GumballMachine.CurrentState = GumballMachine.NoQuarterState;
        }
        public void TurnCrank()
        {
            Console.WriteLine("You turned crank..");
            var winner = RandomWinner.Next(10);
            Console.WriteLine($"Winner random num: {winner}");
            if (winner == 0 && GumballMachine.Count > 1)
            {
                GumballMachine.CurrentState = GumballMachine.WinnerState;
            }
            else
            {
                GumballMachine.CurrentState = GumballMachine.SoldState;
            }            
        }
        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }
        public void Refill(int n)
        {
            Console.WriteLine("you can refill only when all gumballs are sold out");
        }
        public override string ToString()
        {
            return "HAS QUARTER";
        }
    }
}
