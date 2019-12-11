using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, x, N;
            x = 0;
            N = 0;
            Console.WriteLine("Введите A,B,C : ");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
                N = (A / C) * (B / C);
                x = (A * B) - (N * (C * C));
            Console.WriteLine("Количество квадратов : " + N);
            Console.WriteLine("Площадь оставшейся части : " + x);
            Console.ReadKey();
        }
    }
}
