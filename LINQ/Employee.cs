using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.LINQ
{
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public DateTime JoiningDate { get; set; }

    }

    public class Pro
    {
        public static void Main()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Name = "Gaurav", Department = "IT", JoiningDate = DateTime.Now.AddMonths(-9)},
                new Employee { Name = "Pranav", Department = "IT", JoiningDate = DateTime.Now.AddMonths(-5)},
                new Employee { Name = "Dilshad", Department = "HR", JoiningDate = DateTime.Now.AddMonths(-3)},
                new Employee { Name = "Adarsh", Department = "IT", JoiningDate = DateTime.Now.AddMonths(-8)},
            };

            DateTime LastSixMonths = DateTime.Now.AddMonths(-6);

            var filterEmployee = employees.Where(e => e.Department == "IT" && e.JoiningDate >= LastSixMonths).ToList();

            Console.WriteLine("Employees joined in last 6 months from IT department:\n");

            foreach (var emp in filterEmployee)
            {
                Console.WriteLine(
                    $"Name: {emp.Name}, " +
                    $"Department: {emp.Department}, " +
                    $"Joining Date: {emp.JoiningDate.ToShortDateString()}"
                );
            }
        }
    }
}
