using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter9_1_Iterator
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
            var dinerIterator = DinerMenu.CreateIterator();
            Console.WriteLine("MENU\n-------\nBREAKFAST");
            PrintMenu(pancakeIterator);
            Console.WriteLine("LUNCH");
            PrintMenu(dinerIterator);
        }

        private void PrintMenu(Iterator iterator)
        {
            while(iterator.HasNext())
            {
                var item = (MenuItem)iterator.Next();
                Console.WriteLine($"{item.Name}, {item.Price} --- {item.Description}");
            }
        }
    }
}
