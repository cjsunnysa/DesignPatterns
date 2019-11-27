using System;

namespace DesignPatterns.FactoryMethod
{
    public abstract class OperationProgram
    {
        protected abstract IOperator CreateOperator();
        
        public void Run()
        {
            Console.WriteLine();
            Console.WriteLine("Starting operation...");
            Console.WriteLine();
            
            var num1 = 10;
            var num2 = 5;

            Console.WriteLine($"Num1: {num1}");
            Console.WriteLine($"Num2: {num2}");

            var op = CreateOperator();
            var result = op.Execute(num1, num2);

            Console.WriteLine($"Result: {result}");

            Console.WriteLine("Operation complete");
        }
    }
}