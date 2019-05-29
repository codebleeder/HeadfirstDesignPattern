using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter3_Decorator
{
    public abstract class Beverage
    {
        public virtual string description { get; protected set; } = "unknown beverage";

        public abstract double Cost();
    }
}
