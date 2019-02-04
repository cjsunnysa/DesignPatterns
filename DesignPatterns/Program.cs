using DesignPatterns.Builder;
using DesignPatterns.Singleton;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //IExecutable app = new SingletonDemo();
            IExecutable app = new BuilderDemo();

            app.Run();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
