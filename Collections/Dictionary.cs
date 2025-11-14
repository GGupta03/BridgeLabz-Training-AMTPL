/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.Collections
{
    public class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Salary { get; set; }


    }
    class Program
    {
        public static void main()
        {
            Customer customer1 = new Customer()
            {
                Id = 101,
                Name = "Vijay",
                Salary = 500000
            };

            Customer customer2 = new Customer()
            {
                Id = 102,
                Name = "Pranay",
                Salary = 600000
            };

            Customer customer3 = new Customer()
            {
                Id = 103,
                Name = "Nabeel",
                Salary = 700000
            };
            
            Dictionary<int,Customer> dictionaryCustomer = new Dictionary<int,Customer>();
            dictionaryCustomer.Add(customer1.Id, customer1);
            dictionaryCustomer.Add(customer2.Id, customer2);
            dictionaryCustomer.Add(customer3.Id, customer3);


        }
    }
}

*/