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
            int N, x, y=0, z;
            Console.WriteLine("Введите размер массива: ");
            N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            Console.WriteLine("Введите элементы массива, начиная по возрастанию со второго: ");
            for(x=0;x<N;x++)
            {
                A[x] = int.Parse(Console.ReadLine());
            }
            if (A[0] > A[N - 1])
            {
                for (x = 0; x < N-1; x++)
                {
                    z = A[x];
                    A[x] = A[x + 1];
                    A[x + 1] = z;
                }
            }
            else
            {
                for (x = 1; A[0] > A[x]; x++)
                {
                    y++;
                }
                for (x = 0; x < y; x++)
                {
                    z = A[x];
                    A[x] = A[x + 1];
                    A[x + 1] = z;
                }
            }
            for(x=0;x<N;x++)
            {
                Console.WriteLine("Массив: "+A[x]);
            }
            Console.ReadKey();
        }
    }
}
