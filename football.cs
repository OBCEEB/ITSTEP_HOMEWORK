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
            Console.Write("Input score\n");
            int[] n = Console.ReadLine().Split(':').Select(e => Convert.ToInt32(e)).ToArray();
            if (n[0] > n[1])
                Console.Write("Hosters win!");
            else if(n[0] == n[1])
                Console.Write("Draw!");
            else
                Console.Write("Guests win!");
            Console.ReadKey();
        }
    }
}
