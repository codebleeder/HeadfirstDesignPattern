using System;

namespace HeadfirstDesignPattern.Chapter7_Facade
{
    public class DvdPlayer
    {
        internal void PlayMovie(string movie)
        {
            Console.WriteLine($"dvdplayer playing {movie}");
        }

        public void On()
        {
            Console.WriteLine("dvdplayer on");
        }

        public void Stop()
        {
            Console.WriteLine("dvdplayer stop");
        }

        public void Eject()
        {
            Console.WriteLine("dvdplayer eject");
        }

        public void Off()
        {
            Console.WriteLine("dvdplayer off");
        }
    }
}