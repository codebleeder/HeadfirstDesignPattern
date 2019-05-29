using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter4_Factory
{
    public abstract class PizzaStore
    {
        //SimplePizzaFactory factory;

        public PizzaStore()
        {
            //this.factory = factory;
        }

        public Pizza OrderPizza(string type)
        {
            Pizza pizza;
            pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }

        protected abstract Pizza CreatePizza(string type);
    }
}
