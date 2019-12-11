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
            int x,A,B,C,D;
            Console.WriteLine("Введите значение x : ");
            x = int.Parse(Console.ReadLine());
            A = x / 1000;
            B = (x / 100) % 10;
            C = (x / 10) % 10;
            D = x % 10;
            if ((A == D) && (B == C))
            {
                Console.WriteLine("Данное число читается одинаково слева направо и справа налево : " + x);
            }
            else
                Console.WriteLine("Данное число не читается одинаково слева направо и справа налево ");
            Console.ReadKey();
        }
    }
}
