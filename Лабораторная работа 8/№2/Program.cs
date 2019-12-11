using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D;
            Console.WriteLine("Введите значения A,B,C: ");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = 0;
            if((A>B)&&(B>C))
            {
                D = A + B;
                Console.WriteLine("1Сумма наибольших чисел равна : " + D);
            }
            else if ((C > B) && (B > A))
            {
                D = B + C;
                Console.WriteLine("2Сумма наибольших чисел равна : " + D);
            }
            if ((B>A)&&(A>C))
            {
                D = A + B;
                Console.WriteLine("3Сумма наибольших чисел равна : " + D);
            }
            else if ((C > A) && (A > B))
            {
                D = A + C;
                Console.WriteLine("4Сумма наибольших чисел равна : " + D);
            }
            if ((A>C)&&(C>B))
            {
                D = A + C;
                Console.WriteLine("5Сумма наибольших чисел равна : " + D);
            }
            else if ((B > C) && (C > A))
            {
                D = B + C;
                Console.WriteLine("6Сумма наибольших чисел равна : " + D);
            }

            Console.ReadKey();
        }
    }
}
