using System;
using System.Collections.Generic;
using System.Text;

namespace UsingCSharpFeatures.Chapter9_1_Iterator
{
    public static class Chapter9_1Tests
    {
        public static void Test1()
        {
            var pancakeHouseMenu = new PancakeHouseMenu();
            var dinerMenu = new DinerMenu();
            var waitress = new Waitress(pancakeHouseMenu, dinerMenu);
            waitress.PrintMenu();
        }
    }
}
