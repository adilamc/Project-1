using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Application
{
    class Class3
    {
        static void Main(string[] args)
        {
            //Declare var
            int firstNumber, secondNumber, result;
            Console.WriteLine("Enter firstnumber");
            //input fro user
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter secondnumber");
            //input fro user
            secondNumber = Convert.ToInt32(Console.ReadLine());
            result = firstNumber + secondNumber;
            //print the value
            Console.WriteLine("sum of the numbers"+"="+result);
            Console.ReadLine();
        }
    }
}
