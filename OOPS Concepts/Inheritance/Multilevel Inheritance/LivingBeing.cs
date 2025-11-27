using System;

namespace BridgeLabzApp.OOPS_Concepts.Inheritance.Multilevel_Inheritance
{
    internal class LivingBeing
    {
        public void Breathe()
        {
            Console.WriteLine("Living being is breathing.");
        }
    }

    internal class Animal : LivingBeing
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    // Level 3: Child Class inheriting Animal
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

            dog.Breathe(); 
            dog.Eat();     
            dog.Bark();    
        }
    }
}
