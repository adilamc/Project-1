using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Application
{
    
    class @enum
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("enter a number");
            number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 ==0)
            {
                Console.WriteLine(number+ " is divisible by 2");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine(number+ " is divisible by 3");
            }
            else if(number % 5 == 0)
            {
                Console.WriteLine(number + " is divisible by 5");
            }
            else
            {
                Console.WriteLine(number+ "is not divisible by 2,3,5");
            }
            Console.ReadLine();
        }
    }
}
