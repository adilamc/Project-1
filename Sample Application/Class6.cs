using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Application
{
    class Class6
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("enter an age:");
            number = Convert.ToInt32(Console.ReadLine());
            if (number >= 18 && number >= 60)
            {
                Console.WriteLine(" \nSenior Citizen");
            }
            else if (number >= 18 && number < 60)
            {
                Console.WriteLine("\nYou are eligible for vote ");
            }
            else
            {
                Console.WriteLine("\nYou are not eligible for voting");
            }
            Console.ReadLine();
        }
    }
}
