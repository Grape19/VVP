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
            int N, x,y=0,z=0,min,max;
            Console.WriteLine("Введите размер массива: ");
            N = int.Parse(Console.ReadLine());
            int[] A = new int[N+2];
            Console.WriteLine("Введите элементы массива: ");
            for (x = 0; x < N; x++)
            {
                A[x] = int.Parse(Console.ReadLine());
            }
            min = A[0];
            max = A[0];
            for(x=0;x<N;x++)
            {
                if(A[x]<=min)
                {
                    min = A[x];
                    y = x;
                }
                if(A[x]>=max)
                {
                    max = A[x];
                    z = x;
                }
            }
            if (y < z)
                z++;
            for(x=N;x>y;x--)
            {
                 A[x] = A[x - 1];
            }
            A[y] = 0;
            for(x=N+1;x>z;x--)
            {
                A[x] = A[x - 1];
            }
            A[z + 1] = 0;
            for(x=0;x<N+2;x++)
            {
                Console.WriteLine("Массив: " + A[x]);
            }
            Console.ReadKey();
        }
    }
}