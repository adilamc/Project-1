using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Application
{
    class Class9
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter the elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("----------------------------------------");
            int x = 0;
            for (int i = 0; i < arr.Length; i++)
            {

                x = x + arr[i];
                
            }
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
