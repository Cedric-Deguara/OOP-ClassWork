using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question9
{
    class Rectangle
    {
        public double length; //creating length and making it public so it can be modified
        public double width; //creating width and making it public so it can be modified

        public Rectangle(double l, double w)
        {
            this.length = l;
            this.width = w; 
        }

        public string PrintLength()
        {
            string returnText = "The length of the rectangle is " + length;
            return returnText;
        }

        public string PrintWidth()
        {
            string returnText = "The width of the rectangle is " + width;
            return returnText; 
        }

        public void calculateArea() //calculated the area
        {
            double area = length * width;
            Console.WriteLine("The area of the rectangle is " + area); //prints the asnwer
        }

        public void calculatePerimeter()//calculates the perimeter
        {
            double perimeter = (length * 2) + (width * 2);
            Console.WriteLine("The perimeter of the rectangle is " + perimeter);//print the answer
        }
    }
}
