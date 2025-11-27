using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.Collections
{
    public class EvenList
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 10, 15, 22, 7, 30, 41, 6 };

            List<int> evens = new List<int>();

            foreach(int n in numbers)
            {
                if (n % 2 == 0)
                {
                    evens.Add(n);
                }
            }

            Console.WriteLine("Even List " + string.Join(" , ", evens));


        }

    }
}
