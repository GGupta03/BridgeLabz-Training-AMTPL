using System;

namespace BridgeLabzApp.OOPS_Concepts.Abstraction.Interface
{
    internal class InterfaceExample
    {
        
        interface ICustomer
        {
            void Print();
        }

        
        interface ICustomer2 : ICustomer
        {
            void Print1();
        }

        // Implementing both interfaces
        public class Customer : ICustomer2
        {
            public void Print()
            {
                Console.WriteLine("ICustomer: Print Method Executed");
            }

            public void Print1()
            {
                Console.WriteLine("ICustomer2: Print1 Method Executed");
            }
        }

        
        public class Program
        {
            public static void Main(string[] args)
            {
                Customer c = new Customer();

                Console.WriteLine("Calling methods using class object:");
                c.Print();
                c.Print1();

                Console.WriteLine("\nCalling methods using interface reference:");
                ICustomer customer1 = c;
                customer1.Print();

                ICustomer2 customer2 = c;
                customer2.Print();
                customer2.Print1();
            }
        }
    }
}
