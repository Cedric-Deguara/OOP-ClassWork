using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rectangle 1
            Rectangle rect1 = new Rectangle();
            //get the length of rect1
            Console.Write("Please enter the length of the rectangle.");
            rect1.length = Convert.ToDouble (Console.ReadLine());
            //get the width of rect1
            Console.Write("Please enter the width of the rectangle.");
            rect1.width = Convert.ToDouble(Console.ReadLine());
            //Calculate and print the area
            rect1.calculateArea();
            //Calculate and print the perimeter
            rect1.calculatePerimeter();

            //Rectangle 2 
            Rectangle rect2 = new Rectangle();
            //get the length of rectangle
            Console.Write("Please enter the length of the rectangle:");
            rect2.length = Convert.ToDouble(Console.ReadLine());
            //get the width of the rectangle 
            Console.Write("Please enter the width of the rectangle: ");
            rect2.length = Convert.ToDouble(Console.ReadLine());
            //Calculate and print the area 
            rect2.calculateArea();
            //Calculate and print the perimeter
            rect2.calculatePerimeter();

            //Rectangle 3 
            Rectangle rect3 = new Rectangle();
            //Get the length
            Console.Write("What is the length of the rectangle: ");
            rect3.length = Convert.ToDouble(Console.ReadLine());
            //Get the width 
            Console.Write("What is the width of the rectagnle: ");
            rect3.width = Convert.ToDouble(Console.ReadLine());
            //calculate and print area 
            rect3.calculateArea();
            //calculate and print perimeter 
            rect3.calculatePerimeter();


            Console.ReadKey();//waits for key to be pressed to continue 


        }
    }
}
