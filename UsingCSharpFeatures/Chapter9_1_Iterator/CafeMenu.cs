using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace UsingCSharpFeatures.Chapter9_1_Iterator
{
    public class CafeMenu: IMenu
    {
        Dictionary<string, MenuItem> MenuItems;

        public CafeMenu()
        {
            MenuItems = new Dictionary<string, MenuItem>();
            AddItem("Veggie burger and Air fries",
                "Veggie burger on a whole wheat bun, lettuce, tomato, and fries",
                true, 3.99);
            AddItem("Soup of the day",
                "A cup of soup of the day, with a side salad",
                false, 3.69);
            AddItem("Burrito",
                "A large burrito, with whole pinto beans, salsa, guacomole",
                true, 4.29);
        }

        public IEnumerator GetEnumerator()
        {
            return MenuItems.Values.GetEnumerator();
        }

        private void AddItem(string name, string description, bool vegetarian, double price)
        {
            var menuItem = new MenuItem(name, description, vegetarian, price);
            MenuItems.Add(menuItem.Name, menuItem);
        }

       
    }
}
