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
            double x, epsilon;
            Console.Write("Input angle\n");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input epsilon\n");
            epsilon = Convert.ToDouble(Console.ReadLine());
            double s = 0, an;
            int n = 1;
            an = x;
            while (Math.Abs(an) > epsilon)
            {
                s += an;
                n++;
                an*=-x*x/(2*n-1.0)/(2.0*n-2.0); 
            }
            Console.WriteLine("Sin\t{0}\t rad", s);
                Console.ReadKey();
        }
    }
}
