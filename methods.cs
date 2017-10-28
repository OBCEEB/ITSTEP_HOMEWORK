using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int a, b, c;
            Console.WriteLine("Input 3 numbers:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(min(a, b, c));
            */
            //
            /*
            string line;
            line = Convert.ToString(Console.ReadLine());
            char[] str = new char[line.Length];
            using (StringReader sr = new StringReader(line))
                sr.Read(str, 0, line.Length);
            for(int i=0; i<str.Length; i++)
            {
                if (str[i] == ' ' && str[i + 1] == ' ')
                    delete(ref str, i + 1);
            }
            Console.WriteLine(str);
            */
            //
            /*
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            swap1(ref a, ref b);
            Console.WriteLine("{0} {1}", a, b);
            */
            //
            /*
            double a;
            a = Convert.ToDouble(Console.ReadLine());
            exp(a);
            */
            //
            /*
            int len;
            len = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[len];
            Random rnd = new Random();
            for(int i=0; i<len; i++)
            {
                mas[i] = rnd.Next(0, 50);
            }
            for (int i = 0; i < len; i++)
            {
                Console.Write("{0} ", mas[i]);
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(lcm(mas));
            */
            //
            /*
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(gcd2(a, b));
            */
            //
            /*
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    array[i, j] = rnd.Next(1, 10);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write("{0} ", array[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine(determinant(array, n));
            */
            //
            Console.ReadKey();
        }

        private static double determinant(int[,] array, int n)
        {
            double det = 1;
            for (int i = 0; i < n; ++i)
            {
                int k = i;
                for (int j = i + 1; j < n; ++j)
                    if (Math.Abs(array[j,i]) > Math.Abs(array[k,i]))
                        k = j;
                if (Math.Abs(array[k,i]) < 1e-9)
                {
                    det = 0;
                    break;
                }
                swap(ref i, ref k);
                if (i != k)
                    det = -det;
                det *= array[i,i];
                for (int j = i + 1; j < n; ++j)
                    array[i,j] /= array[i,i];
                for (int j = 0; j < n; ++j)
                    if (j != i && Math.Abs(array[j,i]) > 1e-9)
                        for (int b = i + 1; b < n; ++b)
                            array[j,b] -= array[i,b] * array[j,i];
            }
            return det;
        }

        static void swap<T>(ref T val1, ref T val2)
        {
            T buf = val1;
            val1 = val2;
            val2 = buf;
        }

        private static void exp(double a)
        {
            Console.WriteLine("{0:E}", a);
        }

        private static int lcm(int[] mas)
        {
            int res = lcm(mas[0], mas[1]);
            for(int i=2; i<mas.Length;i++)
            {
                res = lcm(res, mas[i]);
            }
            return res;
        }

        private static long gcd2(int a, int b)
        {
            long nod = 1L;
            for (long i = a; i > 0; i--)
            {
                if (a % i == 0 && b % i == 0)
                {
                    nod = i;
                    break;
                }
            }
            return nod;
        }

        private static int lcm(int a, int b)
        {
            return (a / gcd(a, b) * b);
        }

        private static int gcd(int a, int b)
        {
            return Convert.ToBoolean(a) ? gcd(b % a,a) : b;
        }

        private static void swap1(ref int a,ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }

        private static void delete(ref char[]  str, int pos)
        {
            int i;
            if (str[pos] == ' ' && str[pos + 1] == ' ')
                delete(ref str, pos + 1);
            for (i = pos; i < str.Length - 1; i++)
                str[i] = str[i + 1];
            str[i] = '\0';
        }

        private static int min(int a, int b, int c)
        {
            return(Math.Min(Math.Min(a, b),c));
        }
    }
}
