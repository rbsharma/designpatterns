using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.FactoryMethod
{
    public abstract class PizzaFactory
    {
        public IPizza OrderPizza(IList<string> ingredients)
        {
            IPizza pizza = CreatePizza(ingredients);
            //Some actions on pizza which are STANDARD GUIDELINES for all pizzas
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
        
        //CREATING PIZZA IS FLEXIBLE AS PER CONCRETE FACTORY GUIDELINES
        public abstract IPizza CreatePizza(IList<string> ingredients);
    }

    public class ItalianPizzaFactory : PizzaFactory
    {
        public override IPizza CreatePizza(IList<string> _ingredients)
        {
            return new ItalianPizza(_ingredients);
        }
    }
    public class NewYorkPizzaFactory : PizzaFactory
    {
        public override IPizza CreatePizza(IList<string> _ingredients)
        {
            return new NewYorkPizza(_ingredients);
        }
    }
}
