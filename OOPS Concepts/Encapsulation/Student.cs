using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.OOPS_Concepts.Encapsulation
{
    internal class AStudent
    {
        public class Student
        {
            private int id;
            private string? name;
            private int passMarks;

            public void SetID(int ID)
            {
                if (id <= 0)
                {
                    throw new Exception("Invalid ID");
                }
                this.id = ID;
            }

            public int getID(int ID)
            {
                return this.id;
            }
        }

        class Program
        {
            Student C1 = new Student();
            C1.SetID(100);

            Console.WriteLine()
        }
    }
 }

