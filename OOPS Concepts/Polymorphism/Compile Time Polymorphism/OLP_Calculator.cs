using System;

namespace BridgeLabzApp.OOPS_Concepts.Polymorphism.Compile_Time_Polymorphism
{
    internal class OLP_Calculator
    {

        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public string Add(string a, string b)
        {
            return a + b;
        }
    }

    internal class Program
    {
        static void Main()
        {
            OLP_Calculator calc = new OLP_Calculator();

            Console.WriteLine(calc.Add(5, 10));          
            Console.WriteLine(calc.Add(2.5, 3.7));     
            Console.WriteLine(calc.Add(1, 2, 3));       
            Console.WriteLine(calc.Add("Hello ", "World")); 
        }
    }
}
