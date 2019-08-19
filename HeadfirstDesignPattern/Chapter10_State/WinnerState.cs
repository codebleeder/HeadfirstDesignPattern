using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter10_State
{
    public class WinnerState : State
    {
        private GumballMachine GumballMachine;

        public WinnerState(GumballMachine gumballMachine)
        {
            this.GumballMachine = gumballMachine;
        }
        public void InsertQuarter()
        {
            Console.WriteLine("Please wait. We are already giving you a gumball");
        }
        public void EjectQuarter()
        {
            Console.WriteLine("Sorry. You already turned the crank");
        }
        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't get you another gumball");
        }
        public void Dispense()
        {
            Console.WriteLine("You're a winner! you get two gumballs for your quarter!!");
            GumballMachine.ReleaseBall();
            if (GumballMachine.Count == 0)
            {
                GumballMachine.CurrentState = GumballMachine.SoldOutState;
            }
            else
            {
                GumballMachine.ReleaseBall();
                if (GumballMachine.Count > 0)
                {
                    GumballMachine.CurrentState = GumballMachine.NoQuarterState;
                }
                else
                {
                    Console.WriteLine("Oops! out of gumballs");
                    GumballMachine.CurrentState = GumballMachine.SoldOutState;
                }
            }
        }
        public void Refill(int n)
        {
            Console.WriteLine("you can refill only when all gumballs are sold out");
        }
        public override string ToString()
        {
            return "WINNER";
        }
    }
}
