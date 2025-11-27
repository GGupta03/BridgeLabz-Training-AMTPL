using System;
using System.Collections.Generic;

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
        public static void Main(string[] args)
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

            Dictionary<int, Customer> dictionaryCustomer = new Dictionary<int, Customer>();
            dictionaryCustomer.Add(customer1.Id, customer1);
            dictionaryCustomer.Add(customer2.Id, customer2);
            dictionaryCustomer.Add(customer3.Id, customer3);

            Console.WriteLine("Customer Details:");
            foreach (var kvp in dictionaryCustomer)
            {
                Console.WriteLine($"Key: {kvp.Key}, Name: {kvp.Value.Name}, Salary: {kvp.Value.Salary}");
            }

            Console.WriteLine("\nAccessing Customer with Key 102:");
            if (dictionaryCustomer.TryGetValue(102, out Customer? cust))
            {
                Console.WriteLine($"Id: {cust.Id}, Name: {cust.Name}, Salary: {cust.Salary}");
            }
        }
    }
}
