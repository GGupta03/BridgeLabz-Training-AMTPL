using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.BasicsCS
{
    internal class PowerOf2
    {
        public PowerOf2()
        {
            Console.WriteLine("Enter the value of N to calculate power of 2:");
            int N = Convert.ToInt32(Console.ReadLine());
            if (N < 0 || N >= 31)
            {
                Console.WriteLine("Please enter a value between 0 and 30.");
                return;
            }
            for (int i = 0; i <= N; i++)
            {
                Console.WriteLine($"2^{i} = {Math.Pow(2, i)}");
            }
        }
    }
}
