using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory.AbstractFactory
{
    public abstract class Product
    {
        public void StandardMethod()
        {
            Console.WriteLine("Standard Method");
        }
        public abstract void TypeSpecificMethod();
    }

    class ConcreteProductA : Product
    {
        public override void TypeSpecificMethod() { Console.WriteLine("Concrete Product A"); }
    }

    class ConcreteProductB : Product
    {
        public override void TypeSpecificMethod() { Console.WriteLine("Concrete Product B"); }
    }

    public abstract class Factory
    {
        public abstract Product Create();
    }

    public class ConcreteFactoryA : Factory
    {
        public override Product Create() { return new ConcreteProductA(); }
    }

    public class ConcreteFactoryB : Factory
    {
        public override Product Create() { return new ConcreteProductB(); }
    }

    public abstract class AbstractFactorySimplified
    {
        Factory _factory;
        public AbstractFactorySimplified(Factory factory)
        {
            _factory = factory;
        }

        public Product Create()
        {
            Product product = _factory.Create();
            product.StandardMethod();
            return product;
        }
    }

    public class ConcreteAbstractFactory : AbstractFactorySimplified
    {
        public ConcreteAbstractFactory() : base(new ConcreteFactoryA()) { }
        public ConcreteAbstractFactory(Factory factory) : base(factory) { }
    }
}
