using System;

namespace DesignPatterns.Strategy
{
    public class NormalBrakingBehaviour : IBrakingBehaviour
    {
        public void Brake() => Console.WriteLine("Braking normally.");
    }
}