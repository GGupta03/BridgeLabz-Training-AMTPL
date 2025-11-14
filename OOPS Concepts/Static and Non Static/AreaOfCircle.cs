using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.OOPS_Concepts.Static_and_Non_Static
{
    internal class AreaOfCircle
    {
        class Circle
        {
            float PI = 3.14F;
            int radius;

            public Circle(int radius)
            {
                this.radius = radius;
            }
            public float CalculateArea ()
            {
                return this.PI * this.radius * this.radius;
            }
        }

        class Program
        {
            public static void Main()
            {
                Circle C1 = new Circle(5);
                float Area = C1.CalculateArea();
                Console.WriteLine("Area : {0}", Area);
            }
        }
    }
}
