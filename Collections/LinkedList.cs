using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.Collections
{
    public class Employee
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public Employee(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }

    public class CustomLinkedList
    {
        private LinkedList<Employee> List = new LinkedList<Employee>();

        public CustomLinkedList()
        {
            List = new LinkedList<Employee>();
        }

        public void AddFirst(Employee emp)
        {
            List.AddFirst(emp);
        }

        public void AddLast(Employee emp) { 
            List.AddLast(emp);
        }
    }
}
