using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.Collections
{
    internal class Genreics
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
            public static void Main()
            {
                bool Equal = Calculator.AreEqual<int>(1, 2);
                if (Equal)
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
