using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Circle
    {
        //attributes 
        public double radius; //radius is a field for the Circle type
        
        /* 
         * GetReadius() is a method called for circle objects to display the circle;s radius on the console
         * It has no return type (void) and no parementers (no value between brackets).
        */
        //method
        public void GetRadius() //method definition - creating our method
        {
            Console.WriteLine("The radius for this circle is " + radius);
         
        }

    }
}
