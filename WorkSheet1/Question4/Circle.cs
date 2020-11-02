using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Circle
    {
        public double radius;

        public String GetRadius()
        {
            Console.Write("Please enter the radius of the circle: ");
            radius = Convert.ToDouble(Console.ReadLine());
            String returnText = "The radius of the circle is " + radius;
            return returnText;
        }

        public double GetArea()
        {
            double area = Math.PI * Math.Pow(radius, 2);

            return area;
        }

        public double GetCircumference()
        {
            double circumference = 2 * Math.PI * radius;

            return circumference;
        }
    }

}