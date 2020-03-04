using System;

namespace DesignPatterns.Strategy
{
    public class PowerSteeringBehaviour : ISteeringBehaviour
    {
        public void Turn() => Console.WriteLine("Turning using power steering.");
    }
}