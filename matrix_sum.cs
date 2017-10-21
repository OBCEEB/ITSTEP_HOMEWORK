using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix_1 = new int[5, 5];
            int[,] matrix_2 = new int[5, 5];
            int[,] matrix_3 = new int[5, 5];
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    matrix_1[i, j] = rnd.Next(1, 50);
                    matrix_2[i, j] = rnd.Next(1, 50);
                }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("{0} ", matrix_1[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("//");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("{0} ", matrix_2[i, j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    matrix_3[i, j] = matrix_1[i, j] + matrix_2[i, j];
            Console.ReadKey();
            Console.WriteLine("//");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("{0} ", matrix_3[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
