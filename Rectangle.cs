using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleAppliocation
{
    //=============== This is the example of multicast delegate============================
    class Rectangle
    {
        public delegate void DelegateRectangle(double length, double width);
        public void RectangleArea(double lenght,double width)
        {
            Console.WriteLine("Area of Rectangle is:" + lenght * width);
        }
        public static void RactangleParimeter(double length,double width)
        {    
                Console.WriteLine("Perimeter of Rectangle is:" + 2 * (length + width));
        }
        public static void Main()
        {
            Rectangle obj = new Rectangle();
            DelegateRectangle delegateRectangle = new DelegateRectangle(obj.RectangleArea);
            delegateRectangle += Rectangle.RactangleParimeter;
            delegateRectangle(60, 42);
            Console.ReadLine();
        }
    }
}
