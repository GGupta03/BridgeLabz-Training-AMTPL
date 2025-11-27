using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.Collections
{
    public class ReverseArray
    {
        static void Main()
        {
            ArrayList list = new ArrayList();

            list.Add(10);          
            list.Add(20);     
            list.Add(30);        
            list.Add(40); 
            
            int left = 0;
            int right = List.Count - 1;

            while (left < right )
            {
                object temp = list[left];
                list[left] = list[right];
                list[right] = temp;

                left++;
                right--;
            }

            Console.WriteLine("Reversed Array: " + string.Join(", ", list));
        }
    }
}
