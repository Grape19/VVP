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
            int N, y ;
            double x=1.1,z=1;
            Console.WriteLine("Введите целое число : ");
            N = int.Parse(Console.ReadLine());
            for (y=1; y <=N; y ++)
            {
                z *= x;
                x += 0.1;
            }
            Console.WriteLine("Ответ : " + z);
            Console.ReadKey();
        }
    }
}
