using System;

namespace BridgeLabzApp.OOPS_Concepts.Encapsulation
{
    internal class AStudent
    {
        public class Student
        {
            private int id;
            private string? name;
            private int passMarks = 35;

            
            public void SetID(int ID)
            {
                if (ID <= 0)
                {
                    throw new Exception("Invalid ID. ID must be greater than zero.");
                }
                this.id = ID;
            }

            
            public int GetID()
            {
                return this.id;
            }

            
            public void SetName(string Name)
            {
                if (string.IsNullOrWhiteSpace(Name))
                {
                    throw new Exception("Name cannot be empty!");
                }
                this.name = Name;
            }

            
            public string GetName()
            {
                return this.name!;
            }

            
            public int GetPassMarks()
            {
                return this.passMarks;
            }
        }

        class Program
        {
            public static void Main(string[] args)
            {
                Student student1 = new Student();

                student1.SetID(100);
                student1.SetName("Gaurav Gupta");

                Console.WriteLine("Student Details:");
                Console.WriteLine("ID: " + student1.GetID());
                Console.WriteLine("Name: " + student1.GetName());
                Console.WriteLine("Pass Marks: " + student1.GetPassMarks());
            }
        }
    }
}
