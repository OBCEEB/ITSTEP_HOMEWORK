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
            int n, temp;
            bool flag = false;
            Console.WriteLine("Input length of array:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            Console.Clear();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\n", mas[i]);
            }
            for (int i = 0; i < n; i++)
            {
                Console.Clear();
                Console.WriteLine("Input {0} element of array:", i+1);
                temp = Convert.ToInt32(Console.ReadLine());
                for (int j = 0; j < i; j++)
                    if (mas[j] == temp)
                        flag = true;
                if (!flag)
                    mas[i] = temp;
            }
            Console.Clear();
            for (int i = 0; i < n; i++)
            {
                if(mas[i]!=0)
                    Console.WriteLine("{0}\n", mas[i]);
            }
            Console.ReadKey();
            Console.Clear();
            Array.Sort(mas);
            for (int i = 0; i < n; i++)
            {
                if (mas[i] != 0)
                    Console.WriteLine("{0}\n", mas[i]);
            }
                Console.ReadKey();
        }
    }
}
