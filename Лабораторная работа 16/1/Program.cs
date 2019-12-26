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
            int N, x;
            Console.WriteLine("Введите размер массива: ");
            N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            Console.WriteLine("Введите элементы массива: ");
            for(x=0;x<N;x++)
            {
                A[x] = int.Parse(Console.ReadLine());
            }
            for(x=0;x<N-1;x++)
            {
                if(A[x]==A[x+1])
                {
                    A[x] = 0;
                }
            }
            for(x=0;x<N;x++)
            {
                if(A[x]!=0)
                {
                    Console.WriteLine("Массив: " + A[x]);
                }
            }
            Console.ReadKey();
        }
    }
}
