using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.Delegates.MultiCast_Delegates
{
    public delegate void RectDelegate(double Width, double Height);
    public class Rectangle
    {
        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine(2 * (Width + Height));
        }

        public void GetArea(double Width, double Height)
        {
            Console.WriteLine(Width * Height);
        }


        public static void Main()
        {
            Rectangle Rect = new Rectangle();

            RectDelegate Del = Rect.GetPerimeter;
            Del.Invoke(50, 10);

            Del += Rect.GetArea;
            Del.Invoke(30, 20);

        }
    }
}
