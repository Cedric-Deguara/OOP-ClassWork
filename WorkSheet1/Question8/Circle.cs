using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question8
{
    class Circle
    {
        public double radius;

        public Circle(double r)
        {
            radius = r;
        }

        public string PrintRadius()
        {
            string returnText = "The radius of this circle is " + radius;
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
