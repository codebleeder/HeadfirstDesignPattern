using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter10_State
{
    public class GumballMachine
    {
        public State NoQuarterState { get; }
        public State HasQuarterState { get; }
        public State SoldState { get; }
        public State SoldOutState { get; }
        public State WinnerState { get; }
        public State state { get; }
        public State CurrentState { get; set; }
        public int Count { get; set; }

        public string Location { get; set; } // for Proxy pattern
        public GumballMachine(int count, string location = "")
        {
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldState = new SoldState(this);
            SoldOutState = new SoldOutState(this);
            WinnerState = new WinnerState(this);
            Location = location;

            Count = count;
            if (count > 0)
            {
                CurrentState = NoQuarterState;
            }                       
        }

        public void InsertQuarter()
        {
            CurrentState.InsertQuarter();
        }

        public void EjectQuarter()
        {
            CurrentState.EjectQuarter();
        }

        public void TurnCrank()
        {
            CurrentState.TurnCrank();
            CurrentState.Dispense();
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out of the slot...");
            if(Count != 0)
            {
                Count -= 1;
            }
        }

        public override string ToString()
        {
            return $"State: {CurrentState.ToString()}    Count: {Count}";
        }
    }
}
