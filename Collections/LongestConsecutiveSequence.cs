using System;
using System.Collections.Generic;

namespace BridgeLabzApp.Collections
{
    public class LongestConsecutiveSequence
    {
        static void Main()
        {
            HashSet<int> num = new HashSet<int>() { 100, 4, 200, 1, 3, 2 };
            int length = 0;

            foreach (int n in num)
            {
                
                if (!num.Contains(n - 1))
                {
                    int current = n;
                    int count = 1;

                    
                    while (num.Contains(current + 1))
                    {
                        current++;
                        count++;
                    }

                    
                    length = Math.Max(length, count);
                }
            }

            Console.WriteLine("Longest Consecutive Sequence Length = " + length);
        }
    }
}
