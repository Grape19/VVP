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

            int N, M, i, j, z, a = 0, b = 0, max, min;
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
            max = A[0, 0];
            min = A[0, 0];
            for(i=0;i<M;i++)
            {
                for(j=0;j<N;j++)
                {
                    if(A[i,j]>max)
                    {
                        max = A[i, j];
                            a = j;
                    }
                    if(A[i,j]<min)
                    {
                        min = A[i, j];
                        b = j;
                    }
                }
            }
            for(i=0;i<M;i++)
            {
                z = A[i, a];
                A[i, a] = A[i, b];
                A[i, b] = z;
            }

            for (i = 0; i < M; i++)
            {
                for (j = 0; j < N; j++)
                {
                    Console.Write("Массив: " + A[i, j]);
                }
                Console.WriteLine("  ");
            }
            Console.ReadKey();
        }
    }
}
