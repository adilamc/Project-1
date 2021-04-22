using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Application
{
    class Class4
    {
        
        static void Main(string[] args)
        {
            int number;
            Console.Write("enter a number");
            number = Convert.ToInt32(Console.ReadLine());
            if(number>18)
            {
                Console.WriteLine(" Person is eligible for vote");
            }
            else
            {
                Console.WriteLine( "Person is not eligible for vote");
            }
            Console.ReadLine();
        }
    }
}
