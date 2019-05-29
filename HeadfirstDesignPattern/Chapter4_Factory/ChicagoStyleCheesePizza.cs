using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter4_Factory
{
    public class ChicagoStyleCheesePizza: Pizza 
    {
        public ChicagoStyleCheesePizza()
        {
            Name = "Chicago style deep dish cheese pizza";
            Dough = "Extra thick crust dough";
            Sauce = "Plum tomato sauce";
            Toppings.Add("Shredded Mozzarella Cheese");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
