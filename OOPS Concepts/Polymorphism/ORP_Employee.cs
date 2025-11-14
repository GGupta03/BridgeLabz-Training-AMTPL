using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.OOPS_Concepts.Polymorphism

{
    internal class PolymorphismOR
    {
        public class Employee
        {
            public string? FirstName;
            public string? LastName;
            public string? Email;

            public virtual void PrintFullName()
            {
                Console.WriteLine(FirstName + " " + LastName);
            }
        }

        public class FullTimeEmployee : Employee
        {
            public override void PrintFullName()
            {
                Console.WriteLine(FirstName + " " + LastName + " - Full Time ");
            }
        }

        public class PartTimeEmployee : Employee
        {
            public override void PrintFullName()
            {
                Console.WriteLine(FirstName + " " + LastName + " - Part Time");
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
            public static void main()
            {
                Employee[] employee = new Employee[4];

                employee[0] = new Employee();
                employee[1] = new FullTimeEmployee();
                employee[2] = new PartTimeEmployee();
                employee[3] = new TemporaryEmployee();

                foreach (Employee e in employee)
                {
                    e.PrintFullName();
                }


            }      
        }
    }
}
