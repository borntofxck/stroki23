using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("задание 2");
            string x = "это тест", x1, x2, x3;
            Console.WriteLine("Исходная строка: " + x);
            x1 = x.Insert(4, "простой ");
            Console.WriteLine("Новая строка: " + x1);


            Console.WriteLine("задание 3");
            Console.WriteLine("Исходная строка: " + x1);
            x2 = x1.Insert(4, "не");
            Console.WriteLine("Новая строка: " + x2);
            x3 = x1.Insert(4, "но");
            Console.WriteLine("Новая строка: " + x3);
        }
    }
}
