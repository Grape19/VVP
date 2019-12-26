using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, M, i, j, x = 0, y = 0, z, a = 0, b = 0, max, min;
            Console.WriteLine("Введите количество строк и столбцов в матрице: ");
            M = int.Parse(Console.ReadLine());
            N = int.Parse(Console.ReadLine());
            int[,] A = new int[M, N];
            Console.WriteLine("Введите элементы массива:");
            for (i = 0; i < M; i++)
            {
                for (j = 0; j < N; j++)
                {
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (i = 0; i < M; i++)
            {
                max = A[i, 0];
                min = A[i, 0];
                x = i;
                y = 0;
                a = i;
                b = 0;
                for (j = 0; j < N; j++)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        a = i;
                        b = j;
                    }
                    if (A[i, j] < min)
                    {
                        min = A[i, j];
                        x = i;
                        y = j;
                    }
                }
                z = A[x, y];
                A[x, y] = A[a, b];
                A[a, b] = z;
            }

            for (i=0;i<M;i++)
            {
                for(j=0;j<N;j++)
                {
                    Console.WriteLine("Массив: " + A[i, j]);
                }
            }
            Console.ReadKey();
        }
    }
}
