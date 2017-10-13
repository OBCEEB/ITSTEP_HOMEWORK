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
            int m, temp = 1;
            Console.Write("Input m\n");
            m = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= m+1; i++)
            {                
                Console.WriteLine("{0}\n", temp);
                temp *= 2;
            }
                Console.ReadKey();
        }
    }
}
