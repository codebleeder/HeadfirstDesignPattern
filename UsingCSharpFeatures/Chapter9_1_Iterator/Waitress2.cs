using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace UsingCSharpFeatures.Chapter9_1_Iterator
{
    public class Waitress2
    {        
        List<IMenu> Menus;
        public Waitress2(List<IMenu> menus)
        {            
            Menus = menus;
        }

        public void PrintMenu()
        {            
            var menuIterator = Menus.GetEnumerator();
            while(menuIterator.MoveNext())
            {
                var menu = menuIterator.Current;
                PrintMenu(menu.GetEnumerator());
            }
        }

        private void PrintMenu(IEnumerator iterator)
        {
            while(iterator.MoveNext())
            {
                var item = (MenuItem)iterator.Current;
                Console.WriteLine($"{item.Name}, {item.Price} --- {item.Description}");
            }
        }
    }
}
