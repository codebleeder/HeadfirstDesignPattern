using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter3_Decorator
{
    public class Houseblend : Beverage
    {
        public Houseblend()
        {
            description = "Houseblend";
        }
        public override double Cost()
        {
            return 0.89;
        }
    }
}
