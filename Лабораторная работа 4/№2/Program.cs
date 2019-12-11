using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа__4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, x, PI = Math.PI;
            Console.WriteLine("Введите a: ");
            a = int.Parse(Console.ReadLine());
            x = 180;
            if ((a > 0) && (a < 2*PI))
            {
                x = PI;
                a = (a*180)/PI;
                Console.WriteLine("a = " + a);
            }
            else
                Console.WriteLine("Ошибка");
            Console.ReadKey();
        }
    }
}
