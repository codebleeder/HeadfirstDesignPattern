using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter10_State
{
    public enum state  {SOLD_OUT, NO_QUARTER, HAS_QUARTER, SOLD};
    
    public class GumballMachinePrimitive
    {
        public state State;
        public int Count { get; set; }
        public GumballMachinePrimitive(int count)
        {
            Count = count;
            if(Count > 0)
            {
                State = state.NO_QUARTER;
            }
        }
        public void InsertQuarter()
        {
            switch(State)
            {
                case state.NO_QUARTER:
                    State = state.HAS_QUARTER;
                    Console.WriteLine("you inserted a quarter");
                    break;

                case state.HAS_QUARTER:
                    Console.WriteLine("You cannot insert another quarter");
                    break;

                case state.SOLD:
                    Console.WriteLine("Please wait. We are already giving you a gumball");
                    break;

                case state.SOLD_OUT:
                    Console.WriteLine("No more gumballs. You can't insert quarters");
                    break;
            }
        }

        public void EjectQuarter()
        {
            switch(State)
            {
                case state.HAS_QUARTER:
                    Console.WriteLine("Quarter returned");
                    State = state.NO_QUARTER;
                    break;

                case state.NO_QUARTER:
                    Console.WriteLine("You haven't inserted any Quarter");
                    break;

                case state.SOLD:
                    Console.WriteLine("Sorry. You already turned the crank");
                    break;

                case state.SOLD_OUT:
                    Console.WriteLine("You haven't inserted any Quarter");
                    break;
            }
        }

        public void TurnCrank()
        {
            switch (State)
            {
                case state.HAS_QUARTER:
                    Console.WriteLine("You turned crank..");
                    State = state.SOLD;
                    Dispense();
                    break;

                case state.NO_QUARTER:
                    Console.WriteLine("You turned, but there is no quarter");
                    break;

                case state.SOLD:
                    Console.WriteLine("Turning twice doesn't get you another gumball");
                    break;

                case state.SOLD_OUT:
                    Console.WriteLine("You turned, but there are no gumballs");
                    break;
            }
        }

        public void Dispense()
        {
            switch (State)
            {
                case state.HAS_QUARTER:
                    Console.WriteLine("No gumball dispensed");                    
                    break;

                case state.NO_QUARTER:
                    Console.WriteLine("You need to pay first");
                    break;

                case state.SOLD:
                    Console.WriteLine("gumball comes rolling");
                    Count -= 1;
                    if (Count == 0)
                    {
                        Console.WriteLine("Out of gumballs");
                        State = state.SOLD_OUT;
                    }
                    else
                    {
                        State = state.NO_QUARTER;
                    }
                    break;

                case state.SOLD_OUT:
                    Console.WriteLine("No gumball dispensed");
                    break;
            }
        }

        public override string ToString()
        {
            var state = StateToString();
            return $"Gumball machine:    Current State:{state}     Count:{Count} ";
        }

        private string StateToString()
        {
            var res = "";
            switch (State)
            {
                case state.HAS_QUARTER:
                    res = "HAS QUARTER";
                    break;

                case state.NO_QUARTER:
                    res = "NO QUARTER";
                    break;

                case state.SOLD:
                    res = "SOLD";
                    break;

                case state.SOLD_OUT:
                    res = "SOLD OUT";
                    break;
            }
            return res;
        }
    }
}
