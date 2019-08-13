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
            var cafeMenu = new CafeMenu();
            var waitress = new Waitress(pancakeHouseMenu, dinerMenu, cafeMenu);
            waitress.PrintMenu();
        }

        public static void Test2()
        {
            var pancakeHouseMenu = new PancakeHouseMenu();
            var dinerMenu = new DinerMenu();
            var cafeMenu = new CafeMenu();           
            var waitress = new Waitress2(new List<IMenu> {pancakeHouseMenu, dinerMenu, cafeMenu});
            waitress.PrintMenu();
        }
    }
}
