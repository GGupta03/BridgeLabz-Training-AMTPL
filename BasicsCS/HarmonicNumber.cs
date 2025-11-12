using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.BasicsCS
{
    internal class HarmonicNumber
    {
        public HarmonicNumber()
        {
            Console.WriteLine("Enter the value of N :");
            int N = Convert.ToInt32(Console.ReadLine());

            if (N == 0)
            {
                Console.WriteLine("N can't be zero");
                return;
            }

            double harmonic = 0.0;

            for(int i =1; i < N; i++)
            {
                harmonic += 1.0 / i;
            }
            Console.WriteLine($"The {N}th Harmonic Number is: {harmonic:F4}");
        }
    }
}
