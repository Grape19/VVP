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
            int x,A,B,C;
            Console.WriteLine("Введите значение x :");
            x = int.Parse(Console.ReadLine());
            A = x / 100;
            B = (x / 10) % 10;
            C = x % 10;
            if ((A < B) && (B < C)&&(C>=0)&&(B>=0)&&(A>0))
            {
                Console.WriteLine("Цифры данного числа образуют возрастающую последовательность : " + x);
            }
            else if ((A > B) && (B > C))
            {
                Console.WriteLine("Цифры данного числа образуют убывающую последовательнсть : " + x);
            }
            else
            {
                Console.WriteLine("Высказывание не истинно");
            }
            Console.ReadKey();
        }
    }
}
