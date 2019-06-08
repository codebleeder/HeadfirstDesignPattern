using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter6_Command
{
    public enum Speed {OFF = 0, LOW = 1, MEDIUM = 2, HIGH = 3}
    public class CeilingFan
    {
        private string Location;
        private Speed Speed { get; set; }

        public CeilingFan(string location)
        {
            Location = location;
            Speed = Speed.OFF;
        }

        public void High()
        {
            Speed = Speed.HIGH;
            Console.WriteLine("ceiling fan: High");
        }

        public void Medium()
        {
            Speed = Speed.MEDIUM;
            Console.WriteLine("ceiling fan: Medium");
        }

        public void Low()
        {
            Speed = Speed.LOW;
            Console.WriteLine("ceiling fan: Low");
        }

        public void Off()
        {
            Speed = Speed.OFF;
            Console.WriteLine("ceiling fan: Off");
        }

        public Speed GetSpeed()
        {
            return Speed;
        }
    }
}
