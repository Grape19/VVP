using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Номер_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, x, y, z;
            Console.WriteLine("Введите размер массива: ");
            N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            Console.WriteLine("Введите элементы массива: ");
            for(x=0;x<N;x++)
            {
                A[x] = int.Parse(Console.ReadLine());
            }
            for(y=0;y<N;y++)
            {
                Console.WriteLine("Массив " + A[y]);
                for(z=N-1; (z > N - 2) && (z>y);z--)
                {
                    Console.WriteLine("Массив " + A[z]);
                }
                N--;
            }
            Console.ReadKey();
        }
    }
}