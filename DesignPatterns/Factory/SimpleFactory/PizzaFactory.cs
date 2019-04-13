using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.SimpleFactory
{
    public class PizzaStore
    {
        public IPizza CreatePizza(PizzaType type, IList<string> ingredients)
        {
            switch (type)
            {
                case PizzaType.ITALIAN: return new ItalianPizza(ingredients);
                case PizzaType.NEY_YORK:return new NewYorkPizza(ingredients);
                default: return new NewYorkPizza(ingredients);
            }
        }
    }
}
