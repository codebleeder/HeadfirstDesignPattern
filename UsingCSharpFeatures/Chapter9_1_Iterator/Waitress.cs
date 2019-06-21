using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace UsingCSharpFeatures.Chapter9_1_Iterator
{
    public class Waitress
    {
        PancakeHouseMenu PancakeHouseMenu;
        DinerMenu DinerMenu;

        public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
        {
            PancakeHouseMenu = pancakeHouseMenu;
            DinerMenu = dinerMenu;
        }

        public void PrintMenu()
        {
            var pancakeIterator = PancakeHouseMenu.CreateIterator();
            var dinerIterator = DinerMenu.GetEnumerator();
            Console.WriteLine("MENU\n-------\nBREAKFAST");
            PrintMenu(pancakeIterator);
            Console.WriteLine("LUNCH");
            PrintMenu(dinerIterator);
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
