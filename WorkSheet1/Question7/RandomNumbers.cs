using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Question7
{
    class RandomNumbers
    {
        public int num1;
        public int num2;
        public int userInput;
        public int sum;
        Random rand = new Random(); 

        public void GenerateNumbers()
        {
            num1 = rand.Next(1, 11);
            num2 = rand.Next(1, 11); 
        }

        public int GetNumber1()
        {
            return num1; 
        }

        public int GetNumber2()
        {
            return num2;
        }

        public void FindSum()
        {
            sum = num1 + num2;
        }

        public bool IsEqual()
        {
            if(userInput == sum)
            {
                return true; 
            }

            else
            {
                return false; 
            }
        }


    }
}
