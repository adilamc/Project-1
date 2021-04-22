using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Application
{
    class Class7
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("enter what you want to do: \n 1. Addition \n 2.Sub \n 3.Mul \n");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("ADD");
                    break;
                case 2:
                    Console.WriteLine("SUB");
                    break;
                case 3:
                    Console.WriteLine("Mul");
                    break;
                default:
                    Console.WriteLine("Nothing");
                    break;

            }
            Console.ReadLine();
        }
    }
}
