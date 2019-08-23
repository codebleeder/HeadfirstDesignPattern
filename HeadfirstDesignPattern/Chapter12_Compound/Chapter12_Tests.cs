using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter12_Compound
{
    public static class Chapter12_Tests
    {
        public static void Test1()
        {
            var simulator = new DuckSimulator();
            var duckFactory = new CountingDuckFactory();
            simulator.Simulate(duckFactory);
        }
    }
}
