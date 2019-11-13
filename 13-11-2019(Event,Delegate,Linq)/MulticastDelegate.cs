/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate
{
    class Rectangle
    {
        public void GetArea(double Width,double Height)
        {
            Console.WriteLine(Width * Height);
        }
        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine(2*(Width+Height));
        }
        static void Main()
        {
            Rectangle rect = new Rectangle();
            rect.GetArea(12.34,56.78);
            rect.GetPerimeter(12.34, 56.78);
        }
    }
}*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate
{
    public delegate void RectDelegate(double Width, double Height);
    class Rectangle
    {
        public void GetArea(double Width, double Height)
        {
            Console.WriteLine("Area of rect:"+Width * Height);
        }
        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine("Area of rect:"+2 * (Width + Height));
        }
        static void Main()
        {
            Rectangle rect = new Rectangle();
            //RectDelegate obj = new RectDelegate(rect.GetArea);
            RectDelegate obj=rect.GetArea;//binding method with delegate
            obj += rect.GetPerimeter;
            obj.Invoke(12.34, 52.1);
            Console.WriteLine();
            obj.Invoke(47.87,34.8);
            Console.ReadLine();
        }
    }
}
