using System;

namespace BridgeLabzApp.OOPS_Concepts.Static_and_Non_Static
{
    internal class AreaOfCircle
    {
        class Circle
        {
            public static float PI;

            private int radius;

            static Circle()
            {
                PI = 3.14159F;
                Console.WriteLine("Static Constructor Executed");
            }

            public Circle(int radius)
            {
                this.radius = radius;
                Console.WriteLine("Instance Constructor Executed");
            }

            public float CalculateArea()
            {
                return PI * radius * radius;
            }

            public static float GetPI()
            {
                return PI;
            }
        }

        class Program
        {
            public static void Main()
            {
                Console.WriteLine("Value of PI (without object): " + Circle.GetPI());
                Console.WriteLine();

                Circle c1 = new Circle(5);
                Console.WriteLine("Area of Circle 1: " + c1.CalculateArea());

                Circle c2 = new Circle(10);
                Console.WriteLine("Area of Circle 2: " + c2.CalculateArea());
            }
        }
    }
}
