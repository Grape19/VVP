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
            int M, N, x, y, a, b, c, i, j;
            Console.WriteLine("Введите размер матрицы M и N: ");
            M = int.Parse(Console.ReadLine());
            N = int.Parse(Console.ReadLine());
            int[,] A = new int[M, N];
            Console.WriteLine("Введите элементы матрицы: ");
            for (i = 0; i < M; i++)
            {
                for (j = 0; j < N; j++)
                {
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            x = M / 2;
            y = N / 2;
            a = x;
            for (i = 0; i < x; i++, a++)
            {

                b = y;
                for (j = 0; j < y; j++, b++)
                {
                    c = A[i, j];
                    A[i, j] = A[a, b];
                    A[a, b] = c;
                }
            }
            Console.WriteLine("Матрица: ");
            for (i = 0; i < M; i++)
            {
                for (j = 0; j < N; j++)
                {
                    Console.Write("  " + A[i, j]);
                }
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}