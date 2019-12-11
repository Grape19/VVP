using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Введите размер файла в байтах: ");
            x = int.Parse(Console.ReadLine());
            y = x / 1024;
            Console.WriteLine("Размер файла в килобайтах : " + y);
            Console.ReadKey();
        }
    }
}
