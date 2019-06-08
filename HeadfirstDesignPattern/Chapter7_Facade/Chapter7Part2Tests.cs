using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter7_Facade
{
    public static class Chapter7Part2Tests
    {
        public static void Test1()
        {
            var homeTheatre = new HomeTheatreFacade(
                new Amplifier(),
                new Tuner(),
                new DvdPlayer(),
                new Screen(),
                new PopcornPopper()                
                );
            homeTheatre.WatchMovie("Star wars episode 1");
            homeTheatre.EndMovie();
        }
    }
}
