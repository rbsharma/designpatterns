using DesignPatterns.Creational.Factory.FactoryMethod;
using System.Collections.Generic;

namespace DesignPatterns.Creational.Factory.AbstractFactory
{
    public abstract class PizzaAbstractFactory
    {
        PizzaFactory _pizzaFactory;
        public PizzaAbstractFactory(PizzaFactory pizzaFactory)
        {
            _pizzaFactory = pizzaFactory;
        }

        public IPizza OrderPizza(IList<string> ingredients)
        {
            IPizza pizza = _pizzaFactory.CreatePizza(ingredients);
            //Some actions on pizza which are STANDARD GUIDELINES for all pizzas
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }

    public class ItalianPizzaAbstractFactory : PizzaAbstractFactory
    {
        public ItalianPizzaAbstractFactory() : this(new ItalianPizzaFactory()) { }
        public ItalianPizzaAbstractFactory(PizzaFactory pizzaFactory) : base(pizzaFactory) { }
    }
}
