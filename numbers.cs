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
            int num = 0, i = 0;
            while (i < 10)
            {
                if (num % 3 == 0 && num % 7 == 0)
                {
                    Console.WriteLine("{0}\n", num);
                    i++;
                    num++;
                }
                num++;
            }
            Console.ReadKey();
        }
    }
}
