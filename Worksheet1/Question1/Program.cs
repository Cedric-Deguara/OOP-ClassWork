using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {  

        static void Main(string[] args)
        {
            Circle circleGetRadius = new Circle();//crearinf an instance of circle this, circleGetRadius is a new actual circle which will have its own particular values
            Circle circleGetRadius2 = new Circle();
            /*
             * To access fields and methods from an object we need to use the following format: 
             * objectName.fieldsName
             * objectName.MethodName()
             */

            circleGetRadius.radius = 2.5;
            circleGetRadius2.radius = 3;

            Console.WriteLine("Circle 1: ");
            circleGetRadius.GetRadius();

            Console.WriteLine("Circle 2: ");
            circleGetRadius2.GetRadius();
            
            Console.ReadKey();//method call 
        }
    }
}
