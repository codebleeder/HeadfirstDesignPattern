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

        // using composite enumerator
        public void PrintVegetarian()
        {
            var enumerator = AllMenus.GetCompositeEnumerator();
            Console.WriteLine("Vegetarian Menu");
            while(enumerator.MoveNext())
            {
                var menuComponent = (MenuComponent)enumerator.Current;
                try
                {
                    if (menuComponent.IsVegetarian)
                    {
                        menuComponent.Print();
                    }
                }
                catch (NotSupportedException e) { }
            }
        }
    }
}
