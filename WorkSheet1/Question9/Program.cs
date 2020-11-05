using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rectangle 1
            Rectangle rect1 = new Rectangle(5, 2.6);
            //print the length of rect1
            Console.WriteLine(rect1.PrintLength());
            //print the width of rect1
            Console.WriteLine(rect1.PrintWidth());
            //Calculate and print the area
            rect1.calculateArea();
            //Calculate and print the perimeter
            rect1.calculatePerimeter();

            Console.ReadKey();//waits for key to be pressed to continue 
        }
    }
}
