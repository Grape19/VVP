using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Номер4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, x, y=0;
            Console.WriteLine("Введите размер массива: ");
            N = int.Parse(Console.ReadLine());
            int[] Mas = new int[N];
            Console.WriteLine("Введите элементы массива: ");
            for(x=0;x<N;x++)
            {
                Mas[x] = int.Parse(Console.ReadLine());
            }
            for (x = 0; x < N; x++)
            {
                if ((x==0)&&(Mas[0] > Mas[1]))
                    y = x;
                if (((x > 0) && (x < N - 1))&&((Mas[x] > Mas[x + 1])||(Mas[x]>Mas[x-1])))
                    y= x;
                if ((x==N-1)&&(Mas[N - 1] > Mas[N - 2]))
                    y = x;
            }
            Console.WriteLine("Вывод: " + y);
            Console.ReadKey();
        }
    }
}
