using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, K=1, x,y=0;
            Console.WriteLine("Введите значение : ");
            N = int.Parse(Console.ReadLine());
            if(N>1)
            {
                for(x=0;x<=N;K++)
                {
                    x += K;
                }
                Console.WriteLine("Сумма : " + x);
            }
            Console.WriteLine("Наименьшее : " + 1);
            Console.ReadKey();
        }
    }
}
