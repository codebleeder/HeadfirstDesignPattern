using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter12_Compound
{
    public class Goose
    {
        public void Honk()
        {
            Console.WriteLine("Honk");
        }
        public override string ToString()
        {
            return "Goose";
        }
    }
}
