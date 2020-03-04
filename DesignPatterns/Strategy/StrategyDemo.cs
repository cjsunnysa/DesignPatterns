using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    // creating these variations with an inheritance hierarchy would be very difficult
    // and lead to class explosion.
    // favor composition over inheritance.
    public class StrategyDemo : IExecutable
    {
        public void Run() 
        {
            var vwBeetle = new Car(new NormalBrakingBehaviour(), new UnassistedSteeringBehaviour());
            var fordFiestaST150 = new Car(new NormalBrakingBehaviour(), new PowerSteeringBehaviour());
            var bmwE46320 = new Car(new ABSBrakingBehaviour(), new PowerSteeringBehaviour());

            Console.WriteLine("VW Beetle");
            Drive(vwBeetle);

            Console.WriteLine();

            Console.WriteLine("Ford Fiesta ST150");
            Drive(fordFiestaST150);

            Console.WriteLine();

            Console.WriteLine("BMW E46 320i");
            Drive(bmwE46320);

            Console.WriteLine();
        }

        private void Drive(Car car)
        {
            car.Brake();
            car.Turn();
        }
    }
}
