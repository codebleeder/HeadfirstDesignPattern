using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter8_Template
{
    public class Duck : IComparable
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public Duck(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }
        public int CompareTo(object obj)
        {
            var otherDuck = (Duck)obj;
            if (Weight < otherDuck.Weight)
            {
                return -1;
            }
            else if (Weight == otherDuck.Weight)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public override string ToString()
        {
            return $"{Name} weighs {Weight}";
        }
    }
}
