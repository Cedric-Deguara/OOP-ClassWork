﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle();
            circle1.radius = 2.6;

            Console.WriteLine("Circle 1: ");
            circle1.GetRadius();           
                       
            Console.ReadKey();

        }
    }
}
