using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, x;
            double A, y = 1;
            Console.WriteLine("Введите значение А и N: ");
            A = double.Parse(Console.ReadLine());
            N = int.Parse(Console.ReadLine());
            for (x = 1; x <= N; x+=2)
            {
                y -= Math.Pow(A, x);
                y += Math.Pow(A, x + 1);
            }
            Console.WriteLine("Ответ: " + y);
            Console.ReadKey();
        }
    }
}