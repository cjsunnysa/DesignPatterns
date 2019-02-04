using DesignPatterns.Singleton;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IExecutable app = new SingletonDemo();

            app.Run();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
