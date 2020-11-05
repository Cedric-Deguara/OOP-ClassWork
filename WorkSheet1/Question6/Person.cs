using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Question6
{
    class Person
    {
        string id;
        string name;
        int age;
        string locality;
        string favouriteColour; 

        public string GetID()
        {
            Console.WriteLine("What is the person's ID?");
            ID = Console.ReadLine();
            String returnName = id;
            return returnName; 
        }
        public string GetName()
        {
            Console.WriteLine("What is the person's name?");
            name = Console.ReadLine();
            return name; 
        }

        public int GetAge()
        {
            Console.WriteLine("How old is the person?");
            age = Convert.ToInt32(Console.ReadLine());
            return age; 
        }

        public string GetLocality()
        {
            Console.WriteLine("Where does the person live? ");
            locality = Console.ReadLine();
            return locality; 
        }

        public string GetFavouriteColour()
        {
            Console.WriteLine("What is the person's favourite colour? ");
            favouriteColour = Console.ReadLine();
            return favouriteColour;
        }
    }
}
