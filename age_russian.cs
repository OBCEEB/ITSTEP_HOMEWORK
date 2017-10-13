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
            int age;
            Console.Write("Введите ваш возраст\n");
            age = Convert.ToInt32(Console.ReadLine());
            int temp = age % 10;
            switch(temp)
            {
                case 0:
                    Console.WriteLine("Вам {0} лет", age);
                    break;
                case 1:
                    Console.WriteLine("Вам {0} год", age);
                    break;
                case 2:
                    Console.WriteLine("Вам {0} года", age);
                    break;
                case 3:
                    Console.WriteLine("Вам {0} года", age);
                    break;
                case 4:
                    Console.WriteLine("Вам {0} года", age);
                    break;
                case 5:
                    Console.WriteLine("Вам {0} лет", age);
                    break;
                case 6:
                    Console.WriteLine("Вам {0} лет", age);
                    break;
                case 7:
                    Console.WriteLine("Вам {0} лет", age);
                    break;
                case 8:
                    Console.WriteLine("Вам {0} лет", age);
                    break;
                case 9:
                    Console.WriteLine("Вам {0} лет", age);
                    break;
            }
                Console.ReadKey();
        }
    }
}
