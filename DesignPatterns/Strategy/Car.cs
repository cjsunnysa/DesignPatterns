using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    public class Car
    {
        private readonly IBrakingBehaviour _brakingBehaviour;
        private readonly ISteeringBehaviour _steeringBehaviour;

        public Car(IBrakingBehaviour brakingBehaviour, ISteeringBehaviour steeringBehaviour)
        {
            _brakingBehaviour = brakingBehaviour;
            _steeringBehaviour = steeringBehaviour;
        }

        public void Brake()
        {
            _brakingBehaviour.Brake();
        }

        public void Turn()
        {
            _steeringBehaviour.Turn();
        }
    }
}
