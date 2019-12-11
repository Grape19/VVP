using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Введите значения сторон : ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if (((a + b) > c) && ((b + c) > a) && ((a + c) > b))
            {
                Console.WriteLine("Существует треугольник со сторонами a, b, c");
            }
            else
                Console.WriteLine("Не существует треугольник со сторонами a, b, c");
            Console.ReadKey();
        }
    }
}
