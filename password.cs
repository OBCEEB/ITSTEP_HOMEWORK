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
            String password = "brig", temp;
            int i = 0;
            do
            {
                Console.Clear();
                Console.Write("Input password\n");
                temp = Console.ReadLine();
                if (temp == password)
                {
                    Console.Clear();
                    Console.Write("OK\n");
                    break;
                }
                i++;
            } while (i < 5);
            Console.Write("ERROR\n");
            Console.ReadKey();
        }
    }
}
