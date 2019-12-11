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
            int N, x, y;
            Console.WriteLine("Введите размер массива: ");
            N = int.Parse(Console.ReadLine());
            int[] Mas = new int[N];
            Console.WriteLine("Введите элементы массива(два одинаковых): ");
            for (x = 0; x < N; x++)
            {
                Mas[x] = int.Parse(Console.ReadLine());
            }
            for(x=0;x<N;x++)
            {
                for(y=0;y<N;y++)
                {
                    if((Mas[x]==Mas[y])&&(x!=y)&&(x<y))
                    {
                        Console.WriteLine("Вывод: {0},{1}", x, y);
                    }
                }
            }
            Console.ReadKey();

        }
    }
}
