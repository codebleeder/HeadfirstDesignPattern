using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter3_Decorator
{
    public class Whip : CondimentDecorator
    {
        Beverage beverage;

        public Whip(Beverage beverage) => this.beverage = beverage;

        public override double Cost()
        {
            return beverage.Cost() + 0.50;
        }

        public override string description => $"{beverage.description}, Whip";
    }
}
