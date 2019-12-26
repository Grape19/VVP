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
            int N, x, y=0, z,b=0,c=0;
            Console.WriteLine("Введите размер массива: ");
            N = int.Parse(Console.ReadLine());
            int[] A = new int[N+1];
            int[] B = new int[N];
            int[] C = new int[N];
            Console.WriteLine("Введите элементы массива: ");
            for(x=0;x<N;x++)
            {
                A[x] = int.Parse(Console.ReadLine());
            }
            for(x=0;x<N;x++)
            {
                b = 1;
                c=A[x] ;
                while(A[x]==A[x+1])
                {
                    b++;
                    c = A[x];
                    x++;
                }
                B[y] = b;
                C[y] = c;
                y++;
            }
            for(x=0;x<y;x++)
            {
                Console.WriteLine("Массив:  {0},{1}", B[x], C[x]);
            }
            Console.ReadKey();
        }
    }
}
