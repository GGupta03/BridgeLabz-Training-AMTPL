using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.OOPS_Concepts.Abstraction
{
    internal class Interface
    {
        interface ICustomer
        {
            void print();
        }
        interface ICustomer2 : ICustomer
        {
            void print1();
        }

        public class Customer : ICustomer, ICustomer2
        {
            public void print()
            {
                Console.WriteLine("Interface Method");
            }

            public void print1()
            {
                Console.WriteLine("Interface Method for ICustomer 2");
            }
        }

        public class Program
        {
            public static void main()
            {
                Customer c = new Customer();
                c.print();
            }
        }
    }
}
