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
            int M, N, K, a = 0, b = 1, i, j;
            Console.WriteLine("Введите размер матрицы M и N");
            M = int.Parse(Console.ReadLine());
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число K номер строки");
            K = int.Parse(Console.ReadLine());
            int[,] A = new int[M, N];
            Console.WriteLine("Введите элементы");
            for (i = 0; i < M; i++)
            {
                for (j = 0; j < N; j++)
                {
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (i = 0; i < M; i++)
            {
                for (j = 0; j < N; j++)
                {
                    Console.Write("    " + A[i, j]);
                }
                Console.WriteLine("");
            }
            for (i = K - 1; i < K; i++)
            {
                for (j = 0; j < N; j++)
                {
                    a += A[i, j];
                    b *= A[i, j];
                }
            }
            Console.WriteLine("Сумма эллементов {0} строки = {1}, а произведение эллементов = {2} ", K, a, b);
            Console.ReadKey();
        }
    }
}