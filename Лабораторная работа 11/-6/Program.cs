using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, N, K=0;
            int[] Fib = new int[100];
            Console.WriteLine("Введите число: ");
            N = int.Parse(Console.ReadLine());
            Fib[0] = 0;
            Fib[1] = 1;
            for (n = 2; n <100;n++)
            {
                Fib [n] = Fib[n - 1] + Fib[n - 2];
                if (N == Fib[n])
                K = n;
            }
            Console.WriteLine("Ответ: " + K);
            Console.ReadKey();
        }
    }
}
