using System;

namespace DesignPatterns.Observer
{
    public class TemperatureReporter : IObserver<int>
    {
        public void OnCompleted() => Console.WriteLine("Subscription is complete.");
        public void OnError(Exception error) => Console.WriteLine($"An error occurred - {error.Message}");
        public void OnNext(int value) => Console.WriteLine($"Temperature is now {value} degrees celsius");
    }
}
