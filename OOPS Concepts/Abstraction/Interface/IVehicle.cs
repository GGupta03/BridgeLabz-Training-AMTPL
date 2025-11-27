using System;

namespace BridgeLabzApp.OOPS_Concepts.Abstraction.Interface
{
    internal interface IVehicle
    {
        void Start();
        void Stop();
    }

    internal class Car : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Car started.");
        }

        public void Stop()
        {
            Console.WriteLine("Car stopped.");
        }
    }

    internal class Program
    {
        static void Main()
        {
            IVehicle vehicle = new Car();
            vehicle.Start();
            vehicle.Stop();
        }
    }
}
