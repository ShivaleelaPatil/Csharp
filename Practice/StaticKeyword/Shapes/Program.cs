using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle
    {
         int width, height;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void OutputArea()
        {
            Console.WriteLine("Area output: " + Rectangle.CalculateArea(this.width, this.height));
        }

        public static int CalculateArea(int width, int height)
        {
            return width * height;
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(10,100);
            Rectangle.OutputArea();
        }
    }
}
