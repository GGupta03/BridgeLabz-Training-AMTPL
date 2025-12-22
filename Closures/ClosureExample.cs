using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.Closures
{
    internal class ClosureExample
    {
        static Func<double, double> CreateDiscountCalculator(double discountPercentage)
        {
            return price =>
            {
                return price - (price * discountPercentage / 100);
            };
        }

        static void Main()
        {
            var discount20 = CreateDiscountCalculator(20);

            Console.WriteLine(discount20(1000)); 
            Console.WriteLine(discount20(500));  
        }
    }
}
