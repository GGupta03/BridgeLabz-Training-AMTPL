using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.BasicsCS
{
    internal class FlipACoin
    {
        public FlipACoin()
        {
            Console.WriteLine("Enter the number of times coin to be fliped :");
            int N = Convert.ToInt32(Console.ReadLine());

            if(N <= 0)
            {
                Console.WriteLine("Enter a positive Integer :");
                return;
            }
            int head = 0, tail = 0;
            Random random = new Random();

            for(int i=0; i<N; i++)
            {
                double result = random.NextDouble();
                if(result < 0.5)
                {
                    tail++;
                }
                else
                {
                    head++;
                }
                double HeadPer = (head * 100.00) / N;
                double TailPer = (tail * 100.00) / N;

                Console.WriteLine($"Heads Percentage: {HeadPer:F2}%");
                Console.WriteLine($"Tails Percentage: {TailPer:F2}%");
            }
        }
    }
}
