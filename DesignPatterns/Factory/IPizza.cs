using System.Collections.Generic;

namespace DesignPatterns.Factory
{
    public interface IPizza
    {
        IList<string> Toppings { get; }
        DoughType Dough { get; set; }
        void Bake();
        void Cut();
        void Box();
        void Serve();
    }

    public abstract class Pizza : IPizza
    {
        public Pizza(IList<string> ingredients)
        {
            Toppings = ingredients;
        }
        public IList<string> Toppings { get; }
        public DoughType Dough { get; set; }
        public abstract void Bake();
        public abstract void Cut();
        public abstract void Box();
        public abstract void Serve();
    }

    public class ItalianPizza : Pizza
    {
        public ItalianPizza(IList<string> _ingredients) : base(_ingredients)
        {
            Dough = DoughType.THIN;
        }
        public override void Bake() { }
        public override void Cut() { }
        public override void Box() { }
        public override void Serve() { System.Console.WriteLine("ITALIAN PIZZA"); }
    }

    public class NewYorkPizza : Pizza
    {
        public NewYorkPizza(IList<string> _ingredients) : base(_ingredients)
        {
            Dough = DoughType.PAN;
        }
        public override void Bake() { }
        public override void Cut() { }
        public override void Box() { }
        public override void Serve() { System.Console.WriteLine("NEW YORK PIZZA"); }
    }
}
