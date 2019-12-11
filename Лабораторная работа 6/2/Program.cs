using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int K, N;
            Console.WriteLine("Введите K : ");
            K = int.Parse(Console.ReadLine());
            N = 0;
            if((K>=1)&&(K<=365))
            {
                N = K % 7;
            }
            Console.WriteLine("Номер дня недели : " + N);
            Console.ReadKey();
        }
    }
}
