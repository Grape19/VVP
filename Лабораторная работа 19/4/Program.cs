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
            int M, N,z, i, j;
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
            for(i=0;i<M-1;i++)
            {
                j = 0;
                if(A[i,j]>A[i+1,j])
                {
                    for (j = 0; j < N; j++)
                    {
                        z = A[i, j];
                        A[i, j] = A[i + 1, j];
                        A[i + 1, j] = z;
                    }
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