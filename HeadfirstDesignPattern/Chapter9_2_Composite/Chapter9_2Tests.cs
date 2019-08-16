using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter9_2_Composite
{
    public static class Chapter9_2Tests
    {
        public static void Test1()
        {
            var pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
            var dinerMenu = new Menu("DINER MENU", "Lunch");
            var cafeMenu = new Menu("CAFE MENU", "Dinner");
            var dessertMenu = new Menu("DESSERT MENU", "Desserts");
            var allMenus = new Menu("ALL MENUS", "All menus combined");

            allMenus.Add(pancakeHouseMenu);
            allMenus.Add(dinerMenu);
            allMenus.Add(cafeMenu);

           

            pancakeHouseMenu.Add(new MenuItem("K & Bs pancake breakfast",
                "Pancakes with scrambled eggs and toast",
                true,
                2.99));
            pancakeHouseMenu.Add(new MenuItem("Regular pancake breakfast",
                "pancakes with fried eggs",
                false,
                2.99));
            pancakeHouseMenu.Add(new MenuItem("blueberry pancakes",
                "pancakes with fresh blueberries",
                true,
                3.49));

            dinerMenu.Add(new MenuItem(
                "Vegetarian blt",
                "Fakin bacon with lettuce and tomato", true, 2.99
                ));
            dinerMenu.Add(new MenuItem(
                "blt",
                "bacon, lettuce, tomato on whole wheat", false, 2.99
                ));
            dinerMenu.Add(new MenuItem(
                "Soup of the day",
                "soup of the day with potato salad", false, 3.29
                ));

            cafeMenu.Add(new MenuItem(
                "Veggie burger and Air fries",
                "Veggie burger on a whole wheat bun, lettuce, tomato, and fries",
                true, 3.99
                ));
            cafeMenu.Add(new MenuItem(
                "Soup of the day",
                "A cup of soup of the day, with a side salad",
                false, 3.69
                ));
            cafeMenu.Add(new MenuItem(
                "Burrito",
                "A large burrito, with whole pinto beans, salsa, guacomole",
                true, 4.29
                ));

            dessertMenu.Add(new MenuItem(
                "Apple pie", "Apple pie with flakey crust, topped with Vanilla ice cream",
                true, 1.59
                ));
            dessertMenu.Add(new MenuItem(
                "Gulab Jamun", "3 Sugary Gulab Jamun with honey syrup",
                true, 2.59
                ));
            dessertMenu.Add(new MenuItem(
                "Pineapple ice-cream", "Pineapple flavored ice cream",
                true, 3.59
                ));
            cafeMenu.Add(dessertMenu);
            var waitress = new Waitress(allMenus);
            //waitress.Print();
            waitress.PrintVegetarian();
        }
    }
}
