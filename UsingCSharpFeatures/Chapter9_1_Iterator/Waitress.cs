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
        CafeMenu CafeMenu;
        //List<IEnumerable> Menus;
        public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu, CafeMenu cafeMenu)
        {
            PancakeHouseMenu = pancakeHouseMenu;
            DinerMenu = dinerMenu;
            CafeMenu = cafeMenu;
            //Menus = menus;
        }

        public void PrintMenu()
        {
            var pancakeIterator = PancakeHouseMenu.CreateIterator();
            var dinerIterator = DinerMenu.GetEnumerator();
            var cafeIterator = CafeMenu.GetEnumerator();
            Console.WriteLine("MENU\n-------\nBREAKFAST");
            PrintMenu(pancakeIterator);
            Console.WriteLine("LUNCH");
            PrintMenu(dinerIterator);
            Console.WriteLine("DINNER");
            PrintMenu(cafeIterator);
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
