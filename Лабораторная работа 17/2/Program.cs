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
            int N, L, x, y , z, a ,b=0,c,k,n=0;
            Console.WriteLine("Введите  размер массива и число L: ");
            N = int.Parse(Console.ReadLine());
            L = int.Parse(Console.ReadLine());
            int[] A = new int[N+2];
            A[N] = 0;
            Console.WriteLine("Введите элементы массива: ");
            for(x=0;x<N;x++)
            {
                A[x] = int.Parse(Console.ReadLine());
            }
            for(x=0;x<N;x++)
            {
                y = x+1;
                a = 0;
                k = 1;
                while ((A[x] == A[y])&& (A[x]!=0))
                {
                    y++;
                    k++;
                    a++;
                }
                if(k>L)
                {
                    b += a;
                    for(c=y-1;c>=x;c--)
                    {
                        A[c] = 0;
                    }
                    while(n<k-1)
                    {
                        for(z=x+1;z<N+1;z++)
                        {
                            A[z] = A[z + 1];
                        }
                        n++;
                    }
                }
            }
            for(x=0;x<N-b;x++)
            {
                Console.WriteLine("Массив: " + A[x]);
            }
            Console.ReadKey();
        }
    }
}
