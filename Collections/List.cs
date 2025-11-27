using System;
using System.Collections.Generic;

namespace BridgeLabzApp.Collections
{
    public class ListExample
    {
        static public void Main(string[] args)
        {
            List<int> li = new List<int>();
            li.Add(100);
            li.Add(200);
            li.Add(300);

            Console.WriteLine("Initial List:");
            for (int i = 0; i < li.Count; i++)
            {
                Console.WriteLine(li[i]);
            }

            li.Insert(2, 30);

            Console.WriteLine("\nAfter Insert:");
            for (int i = 0; i < li.Count; i++)
            {
                Console.WriteLine(li[i]);
            }

            li.RemoveAt(3);  

            Console.WriteLine("\nAfter RemoveAt(3):");
            for (int i = 0; i < li.Count; i++)
            {
                Console.WriteLine(li[i]);
            }
        }
    }
}
