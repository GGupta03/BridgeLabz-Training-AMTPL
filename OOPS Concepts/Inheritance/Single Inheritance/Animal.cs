using System;

namespace BridgeLabzApp.OOPS_Concepts.Inheritance
{
    internal class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    internal class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }

    internal class Program
    {
        static void Main()
        {
            Dog dog = new Dog();

            dog.Eat();   
            dog.Bark();  
        }
    }
}
