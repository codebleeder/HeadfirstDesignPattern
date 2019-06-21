using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace UsingCSharpFeatures.Chapter9_1_Iterator
{
    public class DinerMenu: IEnumerable
    {
        const int MAX_ITEMS = 6;
        private int NumberOfItems = 0;
        public MenuItem[] MenuItems;
        public DinerMenu()
        {
            MenuItems = new MenuItem[MAX_ITEMS];
            AddItem(
                "Vegetarian blt", 
                "Fakin bacon with lettuce and tomato", true, 2.99);
            AddItem(
                "blt",
                "bacon, lettuce, tomato on whole wheat", false, 2.99
                );
            AddItem(
                "Soup of the day",
                "soup of the day with potato salad", false, 3.29
                );
            AddItem(
                "Hotdog",
                "a hotdog with saurkraut, relish, onions, topped with cheese", false, 3.05
                );

        }

        private void AddItem(string name, string description, bool vegetarian, double price)
        {
            var menuItem = new MenuItem(name, description, vegetarian, price);
            if (NumberOfItems >= MAX_ITEMS)
            {
                throw new System.OverflowException("menu is full. Can't add item to menu");
            }
            else
            {
                MenuItems[NumberOfItems] = menuItem;
                NumberOfItems += 1;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new DinerMenuIterator(MenuItems);
        }
    }
}
