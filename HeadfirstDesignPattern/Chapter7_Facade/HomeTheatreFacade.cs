using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter7_Facade
{
    public class HomeTheatreFacade
    {
        private Amplifier Amp { get; set; }
        public Tuner Tuner { get; set; }
        public DvdPlayer DvdPlayer { get; set; }
        public Screen Screen { get; set; }
        public PopcornPopper PopcornPopper { get; set; }

        public HomeTheatreFacade(
            Amplifier amp,
            Tuner tuner,
            DvdPlayer dvdPlayer,
            Screen screen,
            PopcornPopper popcornPopper
            )
        {
            Amp = amp;
            Tuner = tuner;
            DvdPlayer = dvdPlayer;
            Screen = screen;
            PopcornPopper = popcornPopper;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie");
            PopcornPopper.On();
            PopcornPopper.Pop();
            Screen.Down();
            Amp.On();
            Amp.SetSurroundSound();
            Amp.SetVolume(5);
            DvdPlayer.On();
            DvdPlayer.PlayMovie(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theatre now");
            PopcornPopper.Off();
            Screen.Up();
            Amp.Off();
            DvdPlayer.Stop();
            DvdPlayer.Eject();
            DvdPlayer.Off();
        }
    }
}
