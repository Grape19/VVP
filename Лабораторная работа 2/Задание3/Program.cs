using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, AC, BC;
            Console.WriteLine("Введите значения A,B,C:  ");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            if ((B > C) && (C > A))
            {
                AC = C - A;
                Console.WriteLine("AC = " + AC);
                BC = B - C;
                Console.WriteLine("BC = " + BC);
                Console.WriteLine("AC*BC = " + AC * BC);
            }
            else
                Console.WriteLine("Ошибка");
            Console.ReadKey();
        }
    }
}
