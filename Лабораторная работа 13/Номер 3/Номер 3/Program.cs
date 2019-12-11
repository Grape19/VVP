using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Носер_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, x, A, B,z;
            Console.WriteLine("Введите размер массива, первый член и второй член: ");
            N = int.Parse(Console.ReadLine());
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            int[] Mas = new int[N+1];
            Mas[0] = A;
            Mas[1] = B;
            Console.WriteLine("Массив: " + Mas[0]);
            Console.WriteLine("Массив: " + Mas[1]);
            if (N>2)
            {
                for(z=2;z<N;z++)
                {
                    for (x = 0; x < z; x++)
                    {
                        Mas[z] += Mas[x];
                        if(x==z-1)
                        Console.WriteLine("Массив: " + Mas[z]);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
