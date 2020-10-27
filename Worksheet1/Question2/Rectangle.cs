using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Rectangle
    {
        public double length;
        public double width; 

        public void CalculateArea()
        {
            double area = length + width;

            Console.WriteLine("The are for this rectangle is " + area);
        }

        public void CalculatePerimeter()
        {
            double perimeter = (length * 2) + (width * 2);

            Console.WriteLine("The perimeter for this rectangle is " + perimeter);
        }
    }
}
