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
            int N, x, y, z;
            Console.WriteLine("Введите размер массивов: ");
            N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            int[] B = new int[N];
            Console.WriteLine("Введите элементы массива A : ");
            for(x=0;x<N;x++)
            {
                A[x] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Введите элементы массива B : ");
            for (x = 0; x < N; x++)
            {
                B[x] = int.Parse(Console.ReadLine());
            }
            for (x=0;x<N;x++)
            {
                z = A[x];
                A[x] = B[x];
                B[x] = z;
            }
            for(x=0;x<N;x++)
            {
                Console.WriteLine("Массив A: " + A[x]);
            }
            Console.WriteLine("");
            for (x = 0; x < N; x++)
            {
                Console.WriteLine("Массив B: " + B[x]);
            }
            Console.ReadKey();
        }
    }
}
