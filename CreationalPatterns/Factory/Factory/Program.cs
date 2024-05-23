using System;
using System.Reflection;
using Factory.AbstractFactory;
using Factory.FactoryMethod;

namespace Factory
{
    public class Program
    {
        /// <summary>
        /// Factory Method
        /// Define an interface for creating an object, but let subclasses decide which class to instantiate.
        /// Factory Method lets a class defer instantiation to subclasses.
        /// Abstract Factory
        /// Provide an interface for creating families of related or dependent objects without specifying their concrete classes.
        /// </summary>
        public static void Main(string[] args)
        {
            var autoName = "minicooper";

            // No factory
            Print("No factory");

            var auto = GetAuto(autoName);
            auto.TurnOn();
            auto.TurnOff();

            // Simple Factory
            Console.WriteLine();
            Print("Simple Factory");

            var factory = new SimpleAutoFactory();
            var auto2 = factory.CreateAuto(autoName);
            auto2.TurnOn();
            auto2.TurnOff();

            // Factory Method
            Console.WriteLine();
            Print("Factory Method");

            var autoFactory = LoadAutoFactory();
            var auto3 = autoFactory.CreateAuto();
            auto3.TurnOn();
            auto3.TurnOff();

            // Abstract Factory
            Console.WriteLine();
            Print("Abstract Factory");

            var abstractAutoFactory = LoadAbstractAutoFactory();
            var auto4 = abstractAutoFactory.CreateEconomyAuto();
            auto4.TurnOn();
            auto4.TurnOff();
            var auto5 = abstractAutoFactory.CreateSportAuto();
            auto5.TurnOn();
            auto5.TurnOff();

            Console.ReadKey();
        }

        private static IAuto GetAuto(string autoName)
        {
            switch (autoName)
            {
                case "bmw":
                    return new Bmw();
                case "minicooper":
                    return new MiniCooper();
                default:
                    throw new ArgumentException();
            }
        }

        private static IAutoFactory LoadAutoFactory()
        {
            var autoFactory = System.Configuration.ConfigurationManager.AppSettings["AutoFactory"];
            return Assembly.GetExecutingAssembly().CreateInstance(autoFactory) as IAutoFactory;
        }

        private static IAbstractAutoFactory LoadAbstractAutoFactory()
        {
            var abstractAutoFactory = System.Configuration.ConfigurationManager.AppSettings["AutoAbstractFactory"];
            return Assembly.GetExecutingAssembly().CreateInstance(abstractAutoFactory) as IAbstractAutoFactory;
        }

        private static void Print(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
