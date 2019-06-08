using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter6_Command
{
    public class GarageDoor
    {
        public void Open()
        {
            Console.WriteLine("GarageDoor open");
        }

        public void Close()
        {
            Console.WriteLine("Garagedoor close");
        }
    }
}
