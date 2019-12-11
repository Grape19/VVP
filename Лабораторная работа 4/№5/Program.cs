using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            double  A, B, x;
            Console.WriteLine("Введите A,B: ");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            if (A != 0)
            {
                x = -(B / A);
                Console.WriteLine("x = " + x);
            }
            else
                Console.WriteLine("Ошибка");
            Console.ReadKey();
        }
    }
}
