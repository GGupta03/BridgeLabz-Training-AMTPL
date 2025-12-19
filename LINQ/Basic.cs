using System;
using System.Collections.Generic;
using System.Linq;

namespace BridgeLabzApp.LINQ
{
    public class Basic
    {
        static void Main()
        {
            List<int> list = new List<int>()
            { 1, 3 ,4 ,7 , 9 ,12, 25};

            var Result = list.Where(n => n > 5).ToList();

            foreach(int i in Result)
                Console.WriteLine(i + " ");
        }

    }
}
