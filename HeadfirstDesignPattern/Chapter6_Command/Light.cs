using System;

namespace HeadfirstDesignPattern.Chapter6_Command
{
    public class Light
    {
        string Location;

        public Light(string location)
        {
            Location = location;
        }
        public void On()
        {
            Console.WriteLine("light on");
        }

        public void Off()
        {
            Console.WriteLine("Light off");
        }
    }
}