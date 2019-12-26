using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, x = 0, a, b, c, z = 1, i, j;
            Console.WriteLine("Введите размер матрицы M: ");
            M = int.Parse(Console.ReadLine());
            int[,] A = new int[M, M];
            Console.WriteLine("Введите элементы: ");
            for (i = 0; i < M; i++)
            {
                for (j = 0; j < M; j++)
                {
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (i = 0; i < M; i++)
            {
                for (j = 0; j < M; j++)
                {
                    Console.Write("  " +
                        " " + A[i, j]);
                }
                Console.WriteLine("");
            }
            for (i = 0; i < M - 1; i++)
            {
                x = 0;
                for (a = i + 1; a < M; a++)
                {
                    for (b = a - (i + 1); b < a - i; b++)
                    {
                        x += A[a, b];
                    }
                }
                Console.WriteLine("Сумма {0} диагонали, которая ниже главной = {1}", z, x);
                z++;
            }
            z = 1;
            Console.WriteLine("");
            for (i = 0; i < M - 1; i++)
            {
                x = 0;
                for (b = i + 1; b < M; b++)
                {
                    for (a = b - (i + 1); a < b - i; a++)
                    {
                        x += A[a, b];
                    }
                }
                Console.WriteLine("Сумма {0} диагонали, которая выше главной = {1}", z, x);
                z++;
            }
            Console.ReadKey();
        }
    }
}