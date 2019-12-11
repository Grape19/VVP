using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Номер_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double A,D,a;
            int N,x;
            Console.WriteLine("Введите размер массива , первый член и знаменатель: ");
            N = int.Parse(Console.ReadLine());
            A = double.Parse(Console.ReadLine());
            D = double.Parse(Console.ReadLine());
            double[] Mas = new double[N+1];
            if(N>1)
            {
                for (a = 0,x=0; a <N; a++)
                {
                    Mas[x] = A * (Math.Pow(D, a));
                    Console.WriteLine("Массив: " + Mas[x]);
                    x++;
                }
            }
            Console.ReadKey();
        }
    }
}
