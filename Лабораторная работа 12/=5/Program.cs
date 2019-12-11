using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static double Fact2(double N)
        {
            int x,y=1,z=1;
            if(N>0)
            {
                if (N % 2 == 0)
                {
                    for (x = 2; x <= N; x += 2)
                    {
                        y *= x;
                    }
                    Console.WriteLine("Ответ:" + y);
                }
                if (N % 2 != 0)
                {
                    for (x = 1; x <= N; x += 2)
                    {
                        z *= x;
                    }
                    Console.WriteLine("Ответ:" + z);
                }
            }
            return 0;
        }
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Введите значение: ");
            N = int.Parse(Console.ReadLine());
            Fact2(N);
            Console.ReadKey();
        }
    }
}
