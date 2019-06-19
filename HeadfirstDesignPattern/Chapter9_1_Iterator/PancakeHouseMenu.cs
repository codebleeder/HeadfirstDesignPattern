using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter9_1_Iterator
{
    public class PancakeHouseMenu
    {
        public List<MenuItem> MenuItems;

        public PancakeHouseMenu()
        {
            MenuItems = new List<MenuItem>();
            AddItem(
                "K & Bs pancake breakfast",
                "Pancakes with scrambled eggs and toast",
                true,
                2.99
                );
            AddItem(
                "Regular pancake breakfast",
                "pancakes with fried eggs",
                false, 
                2.99
                );
            AddItem(
                "blueberry pancakes",
                "pancakes with fresh blueberries",
                true,
                3.49
                );
            AddItem(
                "Waffles",
                "waffles, with your choice of blueberries or strawberries",
                true,
                3.59
                );
        }

        private void AddItem(string name, string description, bool vegetarian, double price)
        {
            var menuItem = new MenuItem(name, description, vegetarian, price);
            MenuItems.Add(menuItem);
        }

        public Iterator CreateIterator()
        {
            return new PancakeHouseIterator(MenuItems);
        }
    }
}
