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
            var carName = "minicooper";

            Print("No factory");

            var auto = GetAuto(carName);
            auto.TurnOn();
            auto.TurnOff();

            Console.WriteLine();
            Print("Simple Factory");

            var factory = new SimpleAutoFactory();
            var auto2 = factory.CreateAuto(carName);
            auto2.TurnOn();
            auto2.TurnOff();

            Console.WriteLine();
            Print("Factory Method");

            var autoFactory = LoadFactory();
            var auto3 = autoFactory.CreateAutomobile();
            auto3.TurnOn();
            auto3.TurnOff();

            Console.WriteLine();
            Print("Abstract Factory");

            var abstractFactory = LoadAbstractFactory();
            var auto4 = abstractFactory.CreateEconomyCar();
            auto4.TurnOn();
            auto4.TurnOff();
            var auto5 = abstractFactory.CreateSportCar();
            auto5.TurnOn();
            auto5.TurnOff();

            Console.ReadKey();
        }

        private static IAuto GetAuto(string car)
        {
            switch (car)
            {
                case "bmw":
                    return new Bmw();
                case "minicooper":
                    return new MiniCooper();
                default:
                    throw new ArgumentException();
            }
        }

        private static IAutoFactory LoadFactory()
        {
            var autoFactory = System.Configuration.ConfigurationManager.AppSettings["Auto"];
            return Assembly.GetExecutingAssembly().CreateInstance(autoFactory) as IAutoFactory;
        }

        private static IAbstractFactory LoadAbstractFactory()
        {
            var car = System.Configuration.ConfigurationManager.AppSettings["AutoAbstract"];
            return Assembly.GetExecutingAssembly().CreateInstance(car) as IAbstractFactory;
        }

        private static void Print(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
