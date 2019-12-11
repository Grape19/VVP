using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Номер_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, x, y, z;
            Console.WriteLine("Введите размер массива :");
            N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            Console.WriteLine("Введите элементы массива: ");
            for(x=0;x<N;x++)
            {
                A[x] = int.Parse(Console.ReadLine());
            }
            for(y=1;y<N;y+=2)
            {
                Console.WriteLine("Массив " + A[y]);
            }
            if (N / 2 == 0)
            {
                for (z = N; z >=0; z -= 2)
                {
                    Console.WriteLine("Массив " + A[z]);
                }
            }
            else
            {
                for (z = N-1; z >=0; z -= 2)
                {
                    Console.WriteLine("Массив " + A[z]);
                }
            }
            Console.ReadKey();
        }
    }
}
