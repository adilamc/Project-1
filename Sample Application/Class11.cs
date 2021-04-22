using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Application
{
    class Class11
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 2];
            Console.WriteLine("Enter the elements");
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    arr[row, col] = Convert.ToInt32(Console.ReadLine());
                }

            }
            Console.WriteLine("----------------------------------------");
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    Console.Write(arr[row, col] + "\t");
                }
                Console.WriteLine("\t");
            }
            Console.WriteLine("Transpose of matrix is:\n");
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    Console.Write(arr[col, row] + "\t");
                }
                Console.WriteLine("\t");
            }

            Console.ReadLine();
        }
    }
}
