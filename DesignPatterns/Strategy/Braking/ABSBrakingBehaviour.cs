using System;

namespace DesignPatterns.Strategy
{
    public class ABSBrakingBehaviour : IBrakingBehaviour
    {
        public void Brake() => Console.WriteLine("Braking with ABS.");
    }
}