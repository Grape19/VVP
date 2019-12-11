using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Номер1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, K, L, x, y, z,d=0;
            Console.WriteLine("Введите размер массива и целые числа K,L: ");
            N = int.Parse(Console.ReadLine());
            K = int.Parse(Console.ReadLine());
            L = int.Parse(Console.ReadLine());
            int[] Mas = new int[N];
            Console.WriteLine("Введите массив: ");
            for (x = 0; x < N; x++)
            {
                Mas[x] = int.Parse(Console.ReadLine());
            }
            if ((1 <= K)&&(K <= L)&&(L <= N))
            {
                for (y = K; y <= L; y++)
                {
                    d += Mas[y];
                }
            }
            z = d / ((L-K)+1);
            Console.WriteLine("Среднее арифметическое: " + z);
            Console.ReadKey();
        }
    }
}
