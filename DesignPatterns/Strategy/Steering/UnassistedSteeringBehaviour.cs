using System;

namespace DesignPatterns.Strategy
{
    public class UnassistedSteeringBehaviour : ISteeringBehaviour
    {
        public void Turn() => Console.WriteLine("Turning unassisted.");
    }
}