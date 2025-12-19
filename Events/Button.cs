using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.Events
{
    public delegate void EventHandler();
    class Button
    {
        public event EventHandler? Click;

        public void BtnPress()
        {
            Console.WriteLine("Button Pressed");
            Click?.Invoke();
        }
    }

    class Screen
    {
        public void Display()
        {
            Console.WriteLine("Screen Updated");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Button btn = new Button();
            Screen screen = new Screen();

            btn.Click += screen.Display;

            btn.Press();
        }
    }
}
