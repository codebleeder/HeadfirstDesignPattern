using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter3_Decorator
{
    public class Mocha : CondimentDecorator
    {
        Beverage beverage;

        public Mocha(Beverage beverage) => this.beverage = beverage;

        public override double Cost()
        {
            return beverage.Cost() + 0.20;
        }

        public override string description => $"{beverage.description}, Mocha";
    }
}
