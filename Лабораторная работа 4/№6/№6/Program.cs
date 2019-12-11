using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int A1, A2, B1, B2, C1, C2, x, y;
            Console.WriteLine("Введите A1,A2,B1,B2,C,C2: ");
            A1 = int.Parse(Console.ReadLine());
            A2 = int.Parse(Console.ReadLine());
            B1 = int.Parse(Console.ReadLine());
            B2 = int.Parse(Console.ReadLine());
            C1 = int.Parse(Console.ReadLine());
            C2 = int.Parse(Console.ReadLine());
            y = ((A2 * C1) - (A1 * C2)) / ((A2 * B1) - (A1 * B2));
            x = (C1 - (B1 * y)) / A1;
            Console.WriteLine("Решение системы уравнений : " + y);
            Console.WriteLine("Решение системы уравнений : " + x);
            Console.ReadKey();
        }
    }
}
