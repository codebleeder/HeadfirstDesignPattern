using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter3_Decorator
{
    public abstract class CondimentDecorator: Beverage
    {
        public abstract override string description { get; }
    }
}
