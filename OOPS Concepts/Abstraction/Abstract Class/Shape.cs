using System;

namespace BridgeLabzApp.OOPS_Concepts.Abstraction.Abstract Class
{
    internal abstract class Shape
    {
        public abstract void Draw();    

        public void Display()           
        {
            Console.WriteLine("This is a shape.");
        }
    }

    internal class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle...");
        }
    }

    internal class Program
    {
        static void Main()
        {
            Shape shape = new Circle(); 
            shape.Display();
            shape.Draw();
        }
    }
}
