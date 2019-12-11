using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, AC, BC;
            Console.WriteLine("Введите значения точек A,B,C: ");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            AC = 0;
            BC = 0;
            if (C > A)
            {
                AC = C - A;
                Console.WriteLine("AC = " + AC);
            }
            else if (A > C)
            {
                AC = A - C;
                Console.WriteLine("AC = " + AC);
            }
            if (B > C)
            {
                BC = B - C;
                Console.WriteLine("BC = " + BC);
            }
            else if (C > B)
            {
                BC = C - B;
                Console.WriteLine("BC = " + BC);
            }
            Console.WriteLine("AC+BC = " + (AC + BC));       
            Console.ReadKey();
        }
    }
}
