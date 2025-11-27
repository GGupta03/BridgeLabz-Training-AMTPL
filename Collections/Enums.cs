using System;
using System.Collections.Generic;

namespace BridgeLabzApp.Collections
{
    public class Enums
    {
        public static void Main()
        {
            Customer[] localCustomers = new Customer[3];
            localCustomers[0] = new Customer
            {
                Name = "Vijay",
                gender = Gender.Male
            };
            localCustomers[1] = new Customer
            {
                Name = "Maya",
                gender = Gender.Female
            };
            localCustomers[2] = new Customer
            {
                Name = "Tanmay",
                gender = Gender.Unknown
            };

            foreach (Customer customer in localCustomers)
            {
                Console.WriteLine("Name = {0} and Gender = {1}",
                    customer.Name,
                    GetGender(customer.gender));
            }
        }

        public enum Gender
        {
            Unknown,
            Male,
            Female
        }

        public static string GetGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.Unknown: return "Unknown";
                case Gender.Male: return "Male";
                case Gender.Female: return "Female";
            }

            return "Invalid";
        }

        public class Customer
        {
            public string? Name { get; set; }
            public Gender gender { get; set; }
        }
    }
}
