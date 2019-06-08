using System;

namespace HeadfirstDesignPattern.Chapter7_Facade
{
    public class PopcornPopper
    {
        internal void On()
        {
            Console.WriteLine("popcorn popper ON");
        }

        public void Pop()
        {
            Console.WriteLine("Popcorn popper: POP!");
        }

        public void Off()
        {
            Console.WriteLine("Popcorn popper: off");
        }
    }
}