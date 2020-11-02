using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            /*
            Console.WriteLine(person1.GetID());
            Console.WriteLine(person1.GetName());
            Console.WriteLine("The age of the person is " + person1.GetAge());
            Console.WriteLine(person1.GetLocality());
            Console.WriteLine(person1.GetFavouriteColour());
            
            person1.GetID();
            person1.GetName();
            person1.GetAge();
            person1.GetLocality();
            person1.GetFavouriteColour();
            */
            Console.WriteLine(person1.GetName() + " has the ID of " + person1.GetID() + " is " + person1.GetAge() + " years old, and lives at " + person1.GetLocality() + ". His/Her favourite colour is " + person1.GetFavouriteColour());

            Console.ReadKey();
        }
    }
}
