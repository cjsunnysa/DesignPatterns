using System;

namespace DesignPatterns.SimpleFactory
{
    public class SimpleFactoryDemo : IExecutable
    {
        public void Run()
        {
            Console.WriteLine("\nStarting addition operation...");
            var operation1 = OperationFactory.CreateOperation(OperationType.Addition);
            PerformOperation(operation1);

            Console.WriteLine("\nStarting subtraction operation...");
            var operation2 = OperationFactory.CreateOperation(OperationType.Subtraction);
            PerformOperation(operation2);            
        }

        private void PerformOperation(IOperation operation)
        {
            var num1 = 10m;
            Console.WriteLine($"Number1: {num1}");

            var num2 = 5m;
            Console.WriteLine($"Number2: {num2}");

            var result = operation.Execute(num1, num2);
            Console.WriteLine($"Operation Result: {result}");
        }
    }
}