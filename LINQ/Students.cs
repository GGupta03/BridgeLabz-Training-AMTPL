using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.LINQ
{
    public class Students
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public int Marks { get; set; }
        public string State { get; set; }

    }

    public class Program
    {
        public static void Main()
        {
            List<Students> list = new List<Students>()
            {
                new Students { ID = 101, Name = "Gaurav", Marks = 80, State = "Maharashtra"},
                new Students { ID = 102, Name = "Pranav", Marks = 85, State = "HP"},
                new Students { ID = 103, Name = "Dilsahd", Marks = 83, State = "Jharkhand"},
                new Students { ID = 104, Name = "Adarsh", Marks = 87, State = "Kolkata"},
            };

            var Above85 = list.Where(s => s.ID > 85);
            var Name = list.Select(s => s.Name);
            var Sort = list.OrderByDescending(s => s.Marks);

            int Max = list.Max(s => s.Marks);
            double AvgMarks = list.Average(s => s.Marks);

            Console.WriteLine("The Maximun Marks is {0}", Max);
            Console.WriteLine("The Average Marks is {1}", AvgMarks);
        }
    }
}
