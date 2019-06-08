using System;

namespace HeadfirstDesignPattern.Chapter7_Facade
{
    public class Amplifier
    {
        public void On()
        {
            Console.WriteLine("amplifier on");
        }

        public void SetSurroundSound()
        {
            Console.WriteLine("amp: set surround sound");
        }

        public void SetVolume(int v)
        {
            Console.WriteLine($"amp: set volume to {v}");
        }

        public void Off()
        {
            Console.WriteLine("amp: off");
        }
    }
}