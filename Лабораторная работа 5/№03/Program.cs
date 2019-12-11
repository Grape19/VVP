using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, x;
            Console.WriteLine("Введите длины отрезков A,B: ");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            if ((A > B) && (B > 0))
            {
                x = A % B;
                Console.WriteLine("Длина незанятой отрезка A : " + x);
            }
            else
                Console.WriteLine("Ошибка");
            Console.ReadKey();
        }
    }
}