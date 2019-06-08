using System;

namespace HeadfirstDesignPattern.Chapter6_Command
{
    public class Stereo
    {
        public string Location { get; set; }

        public Stereo(string location)
        {
            Location = location; 
        }
        public void On()
        {
            Console.WriteLine("Stereo On");
        }

        internal void Off()
        {
            Console.WriteLine("Stereo Off");
        }

        public void SetCD()
        {
            Console.WriteLine("Stereo set CD");
        }

        public void SetVolume()
        {
            Console.WriteLine("Stereo set volume");
        }
    }
}