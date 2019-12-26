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
            int N, x, z = 0, a =0,b;
            Console.WriteLine("Введите размер массива: ");
            N = int.Parse(Console.ReadLine());
            int[] A = new int[2 * N];
            Console.WriteLine("Введите элементы массива: ");
            for (x = 0; x < N; x++)
            {
                A[x] = int.Parse(Console.ReadLine());
            }
            for (x = N; x < 2*N; x++)
            {
                A[x] = 0;
            }
            for (x = 0; x < 2*N; x++)
            {
                if (A[x]>0)
                {
                    a++;
                    z = x;
                    for (b = N + a - 1; b>z; b--)
                    {
                        A[b] = A[b-1];
                    }
                    A[z] = 0;
                    x++;
                }
            }

            for (x = 0; x < N + a; x++)
            {
                Console.WriteLine("Массив: " + A[x]);
            }
            Console.ReadKey();
        }
    }
}