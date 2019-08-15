using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter9_2_Composite
{
    public class Waitress
    {
        MenuComponent AllMenus;

        public Waitress(MenuComponent allMenus)
        {
            AllMenus = allMenus;
        }

        public void Print()
        {
            AllMenus.Print();
        }
    }
}
