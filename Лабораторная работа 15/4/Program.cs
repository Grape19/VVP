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
            int N, x, y = 0, z = 0, min, max;
            Console.WriteLine("Введите размер массива: ");
            N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            Console.WriteLine("Введите элементы массива: ");
            for (x = 0; x < N; x++)
            {
                A[x] = int.Parse(Console.ReadLine());
            }
            min = A[0];
            for (x = 0; x < N; x++)
            {
                if (A[x] <= min)
                {
                    min = A[x];
                    z = x;
                }
            }
            max = A[0];
            for (x = 0; x < N; x++)
            {
                if (A[x] >= max)
                {
                    max = A[x];
                    y = x;
                }
            }
            if (z < y)
            {
                for (z += 1; z < y; z++)
                {
                    A[z] = 0;
                }
            }
            else
            {
                for (y += 1; y < z; y++)
                {
                    A[y] = 0;
                }
            }
            for (x = 0; x < N; x++)
            {
                Console.WriteLine("Массив : " + A[x]);
            }
            Console.ReadKey();
        }
    }
}
