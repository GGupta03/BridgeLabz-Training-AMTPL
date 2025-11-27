using System;

namespace BridgeLabzApp.OOPS_Concepts.Inheritance
{
    internal class EmployeeType
    {
        
        public class Employee
        {
            public string? FirstName;
            public string? LastName;
            public string? Email;

            public virtual void PrintFullName()
            {
                Console.WriteLine("Employee Full Name: " + FirstName + " " + LastName);
            }
        }

        
        public class FullTimeEmployee : Employee
        {
            public float YearlySalary;

            public override void PrintFullName()
            {
                Console.WriteLine("Full-Time: " + FirstName + " " + LastName);
            }
        }

        
        public class PartTimeEmployee : Employee
        {
            public float HourlySalary;

            public override void PrintFullName()
            {
                Console.WriteLine("Part-Time: " + FirstName + " " + LastName);
            }
        }

        
        public class Program
        {
            public static void Main(string[] args)
            {
                
                FullTimeEmployee FTE = new FullTimeEmployee();
                FTE.FirstName = "Pranav";
                FTE.LastName = "Mahajan";
                FTE.YearlySalary = 600000;
                FTE.PrintFullName();

                
                PartTimeEmployee PTE = new PartTimeEmployee();
                PTE.FirstName = "Pratyush";
                PTE.LastName = "Aggarwal";
                PTE.HourlySalary = 350;
                PTE.PrintFullName();
            }
        }
    }
}
