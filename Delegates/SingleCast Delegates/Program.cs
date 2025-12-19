using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.Delegates.SingleCast_Delegates
{
    public delegate void SingleDelegate(int x, int y);

    public delegate string DispalyDelegate(string str);
    class Program
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static String Display(String name)
        {
            return "Hello" + name + "Good Morning";
        }

        public static void Main(string[] args)
        {
            Program pg = new Program();
            SingleDelegate sd = pg.Add;
            sd.Invoke(10, 20);

            DispalyDelegate dd = new DispalyDelegate(Display);
            String str = dd.Invoke("Gaurav");
        }
    }
}
