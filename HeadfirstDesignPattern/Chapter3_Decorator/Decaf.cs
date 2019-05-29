using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter3_Decorator
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf coffee";
        }
        public override double Cost()
        {
            return 1.05;
        }
    }
}
