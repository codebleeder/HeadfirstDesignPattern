using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter4_Factory
{
    public class Chapter4_Tests
    {
        public static void PizzaStoreTest()
        {
            var nyStore = new NYPizzaStore();
            var chicagoStore = new ChicagoPizzaStore();
            var pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine($"Ethan ordered a {pizza.Name}");
            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine($"Joel ordered a {pizza.Name}");
        }
    }
}
