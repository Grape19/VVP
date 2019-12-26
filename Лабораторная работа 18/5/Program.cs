using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N, i, j, k = 0;
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
                for (i = 0; i < M; i++)
                {
                    if (A[i, j] % 2 == 0)
                        k++;
                }
                if (k == 0)
                {
                    Console.WriteLine("Номер столбца, содержащий только нечетные числа - {0} ", j + 1);
                    break;
                }
            }
            if (k != 0)
            {
                Console.WriteLine("0");
            }
            Console.ReadKey();
        }
    }
}