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
            int N, x, y, z=0;
            Console.WriteLine("Введите размер массива: ");
            N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            Console.WriteLine("Введите элементы массива: ");
            for(x=0;x<N;x++)
            {
                A[x] = int.Parse(Console.ReadLine());
            }
            for(x=0;x<N;x++)
            {
                if(A[x]%2!=0)
                {
                    z = A[x];
                }
            }
            for(y=0;y<N;y++)
            {
                if (A[y] % 2 != 0)
                {
                    A[y] += z;
                }
                Console.WriteLine("Массив: " + A[y]);
            }
            Console.ReadKey();
        }
    }
}
