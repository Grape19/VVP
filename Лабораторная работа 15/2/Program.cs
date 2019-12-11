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
            int N, x, y, z=0;
            Console.WriteLine("Введите размер массива:" );
            N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            Console.WriteLine("Введите элементы массива: ");
            for(x=0;x<N;x++)
            {
                A[x] = int.Parse(Console.ReadLine());
            }
            int[] B = new int[N];
            for(x=0;x<N;x++)
            {
                for(y=1;y<=x;y++)
                {
                    z += A[y];
                }
                B[x] = z / (y);
                Console.WriteLine("Массив: " + B[x]);
            }
            Console.ReadKey();
        }
    }
}
