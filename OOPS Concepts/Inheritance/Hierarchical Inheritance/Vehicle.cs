using System;

namespace BridgeLabzApp.OOPS_Concepts.Inheritance.Hierarchical_Inheritance
{
    internal class Vehicle
    {
        public void Start()
        {
            Console.WriteLine("Vehicle is starting...");
        }
    }

    internal class Car : Vehicle
    {
        public void PlayMusic()
        {
            Console.WriteLine("Car is playing music.");
        }
    }

    internal class Bike : Vehicle
    {
        public void KickStart()
        {
            Console.WriteLine("Bike is kick-started.");
        }
    }

    internal class Truck : Vehicle
    {
        public void LoadCargo()
        {
            Console.WriteLine("Truck is loading cargo.");
        }
    }

    internal class Program
    {
        static void Main()
        {
            Car car = new Car();
            car.Start();
            car.PlayMusic();

            Bike bike = new Bike();
            bike.Start();
            bike.KickStart();

            Truck truck = new Truck();
            truck.Start();
            truck.LoadCargo();
        }
    }
}
