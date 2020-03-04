using DesignPatterns.Builder;
using DesignPatterns.FactoryMethod;
using DesignPatterns.SimpleFactory;
using DesignPatterns.Singleton;
using DesignPatterns.Strategy;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //IExecutable app = new SingletonDemo();
            //IExecutable app = new BuilderDemo();
            //IExecutable app = new SimpleFactoryDemo();
            //IExecutable app = new FactoryMethodDemo();
            IExecutable app = new StrategyDemo();

            app.Run();

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
