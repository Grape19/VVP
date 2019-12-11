using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Номер2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, x, y=0,z,d;
            Console.WriteLine("Введите размер массива: ");
            N = int.Parse(Console.ReadLine());
            int[] Mas = new int[N];
            Console.WriteLine("Введите неповторяющиеся элементы массива: ");
            for(x=0;x<N;x++)
            {
                Mas[x] = int.Parse(Console.ReadLine());
            }
            z = Mas[1] - Mas[0];
            for (x = 0; x < N-1; x++)
            {
                d = Mas[x + 1] - Mas[x];
                if (z == d)
                {
                    y = d;
                }
                else
                {
                    y = 0;
                    break;//Чтобы когда z!=d программа останавливалась
                }

            }
            Console.WriteLine("Вывод: " + y);
            Console.ReadKey();
        }
    }
}
