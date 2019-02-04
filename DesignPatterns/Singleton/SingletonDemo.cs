using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Singleton
{
    public class SingletonDemo : IExecutable
    {
        public void Run()
        {
            Console.WriteLine("Getting instance 1...");
            var instance1 = AppSingleton.GetInstance();
            Console.WriteLine("Done.");

            Console.WriteLine("Getting instance 2...");
            var instance2 = AppSingleton.GetInstance();
            Console.WriteLine("Done.");

            Console.WriteLine($"instance1 is the same object as instance2: {instance1 == instance2}");
        }
    }
}
