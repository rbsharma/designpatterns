using DesignPatterns.Factory;
using DesignPatterns.Factory.AbstractFactory;
using DesignPatterns.Factory.FactoryMethod;
using DesignPatterns.Factory.SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Client
    {
        static void Main(string[] args)
        {
            IPizza pizza;
            List<string> pizzaIngredients = new List<string>() { "ONE", "TWO" };

            #region SIMPLE FACTORY CREATION EXAMPLE
            PizzaStore factory = new PizzaStore();
            pizza = factory.CreatePizza(PizzaType.ITALIAN, pizzaIngredients);
            pizza = factory.CreatePizza(PizzaType.NEY_YORK, pizzaIngredients);

            #endregion

            #region FACTORY METHOD CREATION EXAMPLE
            PizzaFactory factoryMethod;

            factoryMethod = new ItalianPizzaFactory();
            pizza = factoryMethod.OrderPizza(pizzaIngredients);

            factoryMethod = new NewYorkPizzaFactory();
            pizza = factoryMethod.OrderPizza(pizzaIngredients);
            #endregion

            #region ABSTRACT FACTORY CREATION EXAMPLE
            pizza = new ItalianPizzaAbstractFactory().OrderPizza(pizzaIngredients);
            pizza = new ItalianPizzaAbstractFactory(new NewYorkPizzaFactory()).OrderPizza(pizzaIngredients);
            pizza.Serve();
            #endregion
        }
    }
}
