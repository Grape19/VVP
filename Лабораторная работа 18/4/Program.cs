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
            int M, N, i, j, sr, k;
            double Sr;
            Console.WriteLine("Введите размер матрицы M и N");
            M = int.Parse(Console.ReadLine());
            N = int.Parse(Console.ReadLine());
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
            for (j = 0; j < N; j++)
            {
                k = 0;
                sr = 0;
                for (i = 0; i < M; i++)
                {
                    sr += A[i, j];
                }
                Sr = sr / M;
                for (i = 0; i < M; i++)
                {
                    if (A[i, j] > Sr)
                        k++;
                }
                Console.WriteLine("В {0} столбце количество элементов, больших среднего арифметичкеского = {1} ", j + 1, k);
            }
            Console.ReadKey();
        }
    }
}