using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Номер3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, x,y,z;
            Console.WriteLine("Введите размер массива: ");
            N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            Console.WriteLine("Введите элементы массива: ");
            for(x=0;x<N;x++)
            {
                A[x] = int.Parse(Console.ReadLine());
            }
            y = A[2];
            for(x=2;x<N;x+=2)
            {
                if(A[x]<y)
                {
                    y = A[x];
                }
            }
            Console.WriteLine("Минимальный элемент: " + y);
            Console.ReadKey();
        }
    }
}
