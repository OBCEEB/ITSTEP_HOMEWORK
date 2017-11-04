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
            String logins = "Login1,LOgin2,login3,loGin4";
            split_tolower(logins);
            */
            //
            /*          
            char[,] field = new char[30, 30];
            draw_square(field);
            */
            //
            /*
            string line;
            line = Console.ReadLine();
            words_toupper(line);
            */
            //
            Console.ReadKey();
        }

        private static void words_toupper(string input)
        {
            string[] splited = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string tmp;
            for (int i = 0; i < splited.Length; i++)
            {
                tmp = splited[i];
                if (!char.IsDigit(Convert.ToChar(tmp.Substring(0, 1))))
                {
                    splited[i] = tmp.Substring(0, 1).ToUpper() + tmp.Substring(1, tmp.Length - 1);
                }
            }
            string result = "";
            foreach (string s in splited)
            {
                result += s + " ";
            }
            Console.Write(result);
        }

        private static void draw_square(char[,] field)
        {
            for (int i = 0; i < 30; i++)
                for (int j = 0; j < 30; j++)
                    field[i, j] = '\0';
            int x1, x2, y1, y2;
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            x1--; y1--; x2--; y2--;
            if (y1 > y2)
            {
                swap(ref y1, ref y2);
                swap(ref x1, ref x2);
            }
            field[x1, y1] = (char)9556; //  ╔
            field[x2, y2] = (char)9565; //      ╝
            field[x1, y2] = (char)9559; //          ╗
            field[x2, y1] = (char)9562; //              ╚
            for (int i = x1 + 1; i < x2; i++)
            {
                field[i, y1] = (char)9553;
                field[i, y2] = (char)9553;
            }
            for (int i = y1 + 1; i < y2; i++)
            {
                field[x1, i] = (char)9552;
                field[x2, i] = (char)9552;
            }

            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    Console.Write(field[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static void split_tolower(string logins)
        {
            String[] login_array = logins.Split(',');
            for (int i = 0; i <= login_array.GetUpperBound(0); i++)
                login_array[i] = login_array[i].ToLower();
            foreach (string n in login_array)
                Console.WriteLine(n);
        }

        static void swap<T>(ref T val1, ref T val2)
        {
            T buf = val1;
            val1 = val2;
            val2 = buf;
        }
    }
}
