using System;

namespace BridgeLabzApp.Collections
{
    internal class Generics
    {
        public class Calculator
        {
            public static bool AreEqual<T>(T value1, T value2)
            {
                return value1.Equals(value2);
            }
        }

        public class Program
        {
            public static void Main(string[] args)
            {
                bool equal = Calculator.AreEqual(1, 2);

                if (equal)
                {
                    Console.WriteLine("They are Equal");
                }
                else
                {
                    Console.WriteLine("They are not Equal");
                }
            }
        }
    }
}
