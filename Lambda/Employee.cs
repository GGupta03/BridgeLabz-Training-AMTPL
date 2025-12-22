using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.Lambda
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Amit", Salary = 40000 },
                new Employee { Id = 2, Name = "Neha", Salary = 55000 },
                new Employee { Id = 3, Name = "Rahul", Salary = 60000 },
                new Employee { Id = 4, Name = "Sneha", Salary = 35000 }
            };

            double averageSalary = employees.Average(e => e.Salary);

            Console.WriteLine($"Average Salary: {averageSalary}");
            Console.WriteLine("Employees earning more than average salary:");

            var highSalaryEmployees = employees
                                      .Where(e => e.Salary > averageSalary)
                                      .ToList();

            foreach (var emp in highSalaryEmployees)
            {
                Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Salary: {emp.Salary}");
            }

            Console.ReadLine();
        }
    }
}
