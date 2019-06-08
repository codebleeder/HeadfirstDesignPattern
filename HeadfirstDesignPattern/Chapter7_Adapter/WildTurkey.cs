using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter7_Adapter
{
    public class WildTurkey : Turkey
    {
        public void Fly()
        {
            Console.WriteLine("Wild Turkey: Turkey flying a short distance");
        }

        public void Gobble()
        {
            Console.WriteLine("Wild Turkey: Gobble gobble");
        }
    }
}
