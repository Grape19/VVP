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
            int N, x,y=0,z=0,a;
            Console.WriteLine("Введите размер массива: ");
            N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            a = N;
            Console.WriteLine("Введите элементы массива: ");
            for (x = 0; x < N; x++)
            {
                A[x] = int.Parse(Console.ReadLine());
            }
            for(x=0;x<N;x++)
            {
                for(y=x+1;y<N;y++)
                {
                    if(A[x]==A[y])
                    z++;
                }
            }
            if (z < 3)
            {
                for (x = 0; x < N; x++)
                {
                    for (y = x + 1; y < N; y++)
                    {
                        if (A[x] == A[y])
                        {
                            A[x] = 0;
                            A[y] = 0;
                            a -= 2;
                        }
                    }
                }
            }
            else
                a++;
            Console.WriteLine("Размер массива: " + a);
            for (x = 0; x < N; x++)
            {
                if (A[x] != 0)
                    Console.WriteLine("Массив: " + A[x]);
            }
            Console.ReadKey();
        }
    }
}
