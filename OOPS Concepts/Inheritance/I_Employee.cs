using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.OOPS_Concepts.Inheritance
{
    internal class EmployeeType
    {
        public class Employee
        {
            public string? FirstName;
            public string? LastName;
            public string? Email;

            public void PrintFullName()
            {
                Console.WriteLine(FirstName + " " + LastName);
            }
        }

        public class FullTimeEmployee : Employee
        {
            float YearlySalary;
        }

        public class PartTimeEmployee : Employee
        {
            float HourlySalary;
        }

        class Program
        {
            public static void Run()
            {
                FullTimeEmployee FTE = new FullTimeEmployee();
                FTE.FirstName = "Pranav";
                FTE.LastName = "Mahajan";
                FTE.PrintFullName();

                PartTimeEmployee PTE = new PartTimeEmployee();
                PTE.FirstName = "Pratyush";
                PTE.LastName = "Aggarwal";
                PTE.PrintFullName();
            }

        }
    }
}