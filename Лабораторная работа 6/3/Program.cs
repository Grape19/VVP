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
            int K, N, x;
            Console.WriteLine("Введите K,N : ");
            K = int.Parse(Console.ReadLine());
            N = int.Parse(Console.ReadLine());
            x = 0;
            if((K>=1)&&(K<=365))
            {
                x = ((N + K) % 7) - 1;
            }
            Console.WriteLine("Номер дня недели : " + x);
            Console.ReadKey();
        }
    }
}
