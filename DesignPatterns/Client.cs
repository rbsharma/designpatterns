using DesignPatterns.Creational.Factory;
using DesignPatterns.Creational.Factory.AbstractFactory;
using DesignPatterns.Creational.Factory.FactoryMethod;
using DesignPatterns.Creational.Factory.SimpleFactory;
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Adapter.Pragmatic;
using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    public class Client
    {
        static void Main(string[] args)
        {
            #region ADAPTOR PATTERN

            #region PRAGMATIC
            //Without Adapter
            CustomAuth.CustomAuthorization.AuthorizeUser();
            GoogleAuth.GoogleAuthorization.SignIn();
            FbAuth.FacebookAuth.Login();


            //With Adapter
            //Design and Code Consistency
            IAuthProvider authProvider;
            authProvider = new AuthProvider(AuthType.CUSTOM);
            authProvider.Authorize();

            authProvider = new AuthProvider(AuthType.FB);
            authProvider.Authorize();

            authProvider = new AuthProvider(AuthType.GOOGLE);
            authProvider.Authorize();
            Console.Read();
            #endregion


            #region THEORITICAL
            //Without Adapter Method;
            AdapteeA adapteeA = new AdapteeA();
            adapteeA.UseAdapteeA();
            AdapteeB adapteeB = new AdapteeB();
            adapteeB.UseAdapteeB();

            //With Adapter Method; ITarget interface provides consistency; 
            ITarget target;
            target = new AdapterA();
            target.Method();
            target = new AdapterB();
            target.Method();

            Console.Read();
            #endregion

            #endregion

            #region FACTORY PATTERN
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

            #region SIMPLIFIED ABSTRACT FACTORY CREATION EXAMPLE
            Console.Clear();
            Product product;
            product = new ConcreteAbstractFactory().Create();
            product.TypeSpecificMethod();

            product = new ConcreteAbstractFactory(new ConcreteFactoryB()).Create();
            product.TypeSpecificMethod();
            #endregion
            #endregion
        }
    }
}
