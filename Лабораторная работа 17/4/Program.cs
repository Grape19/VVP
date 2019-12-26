using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, x, y, z=0,max;
            Console.WriteLine("Введите количество точек: ");
            N = int.Parse(Console.ReadLine());
            int[,] A = new int[N, 2];
            Console.WriteLine("Введите координаты x и y: ");
            for(x=0;x<N;x++)
            {
                for(y=0;y<2;y++)
                {
                    A[x, y] = int.Parse(Console.ReadLine());
                }
            }
            max = A[0, 0] + A[0, 1];
            for(x=0;x<N;x++)
            {
                if(A[x,0]+A[x,1]>max)
                {
                    max = A[x, 0] + A[x, 1];
                    z = x;
                }
            }
            Console.WriteLine("Координаты точки: {0}  {1}", A[z, 0], A[z, 1]);
            Console.ReadKey();
        }
    }
}
