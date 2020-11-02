using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Question2
{
    class Rectangle
    {
        public double length; //creating length and making it public so it can be modified
        public double width; //creating width and making it public so it can be modified

        public void calculateArea() //calculated the area
        {
            double area = length * width;
            Console.WriteLine("The area of the rectangle is: " + area); //prints the asnwer
        }

        public void calculatePerimeter()//calculates the perimeter
        {
            double perimeter = (length * 2) + (width * 2);
            Console.WriteLine("The perimeter of the rectangle is: " + perimeter);//print the answer
        }
    }
}
