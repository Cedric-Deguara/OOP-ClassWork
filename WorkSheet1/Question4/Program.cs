using Question3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle();
            Console.WriteLine(circle1.GetRadius());
            Console.WriteLine("The area of the circle is " + circle1.GetArea());
            Console.WriteLine("The Circumference of the circle is " + circle1.GetCircumference());
            Console.ReadKey();
        }
    }
}
