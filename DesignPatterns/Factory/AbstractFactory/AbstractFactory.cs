using DesignPatterns.Factory.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.AbstractFactory
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
