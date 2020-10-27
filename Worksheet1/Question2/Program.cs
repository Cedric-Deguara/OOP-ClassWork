using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle();
            Rectangle rect2 = new Rectangle();

            Console.Write("Please enter the length for rectangle 1: ");

            /*
             * When a method reitrns a value the format is: 
             * variable = method()
             * so method() will be converted to the reutnrd value and the reutned value will be saved in the variable
             */

            rect1.length = Convert.ToDouble(Console.ReadLine());

  
            
    }
}
