using System;

namespace BridgeLabzApp.OOPS_Concepts.Polymorphism.Run_Time_Polymorphism
{
    internal class ORP_Employee
    {
        public class Employee
        {
            public string? FirstName;
            public string? LastName;
            public string? Email;

            public virtual void PrintFullName()
            {
                Console.WriteLine(FirstName + " " + LastName + " - Employee");
            }
        }

        public class FullTimeEmployee : Employee
        {
            public override void PrintFullName()
            {
                Console.WriteLine(FirstName + " " + LastName + " - Full Time Employee");
            }
        }

        public class PartTimeEmployee : Employee
        {
            public override void PrintFullName()
            {
                Console.WriteLine(FirstName + " " + LastName + " - Part Time Employee");
            }
        }

        public class TemporaryEmployee : Employee
        {
            public override void PrintFullName()
            {
                Console.WriteLine(FirstName + " " + LastName + " - Temporary Employee");
            }
        }

        class Program
        {
            public static void Main(string[] args)
            {
                Employee[] employees = new Employee[4];

                employees[0] = new Employee() { FirstName = "Gaurav", LastName = "Gupta" };
                employees[1] = new FullTimeEmployee() { FirstName = "Pranav", LastName = "Mahajan" };
                employees[2] = new PartTimeEmployee() { FirstName = "Pratyush", LastName = "Aggarwal" };
                employees[3] = new TemporaryEmployee() { FirstName = "Ananya", LastName = "Sharma" };

                foreach (Employee e in employees)
                {
                    e.PrintFullName();
                }
            }
        }
    }
}
