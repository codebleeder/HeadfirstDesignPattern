using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter3_Decorator
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Dark Roast";
        }
        public override double Cost()
        {
            return 0.99;
        }
    }
}
