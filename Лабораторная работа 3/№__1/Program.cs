using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ___1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, x, y;
            Console.WriteLine("Введите A,B : ");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            x = A;
            y = B;
            Console.WriteLine("A = " + (A = y));
            Console.WriteLine("B = " + (B = x));
            Console.ReadKey();
        }
    }
}
