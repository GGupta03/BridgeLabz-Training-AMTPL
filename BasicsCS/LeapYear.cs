using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.BasicsCS
{
    internal class LeapYear
    {
        public LeapYear() {
            Console.Write("Enter a year (4 digits): ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year < 1000 || year > 9999)
            {
                Console.WriteLine("Please enter a valid 4-digit year.");
                return;
            }

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                Console.WriteLine($"{year} is a Leap Year.");
            else
                Console.WriteLine($"{year} is NOT a Leap Year.");
        }
    }
}

