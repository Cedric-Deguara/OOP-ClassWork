using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question7
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomNumbers randnum = new RandomNumbers();

            randnum.GenerateNumbers();
            randnum.FindSum();
            Console.WriteLine("First Number is " + randnum.GetNumber1() + " and Second Number is " + randnum.GetNumber2());
            Console.WriteLine("What is the sum of both numbers?");
            randnum.userInput = Convert.ToInt32(Console.ReadLine());
            randnum.IsEqual();


            Console.ReadKey();
        }
    }
}
