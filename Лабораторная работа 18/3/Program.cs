using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N, Min = 1, i, j, y = 0, p = 1;
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
            for (i = 0; i < M; i++)
                Min *= A[i, 0];

            for (j = 1; j < N; j++)
            {
                for (i = 0; i < M; i++)
                {
                    p *= A[i, j];
                }
                if (p < Min)
                {
                    Min = p;
                    y = j;
                }
            }
            Console.WriteLine("Номер столбца с минимальный произведение эллементов - {0}, а также значение = {1} ", y + 1, Min);
            Console.ReadKey();
        }
    }
}