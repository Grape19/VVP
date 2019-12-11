using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ___3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, x, y, z;
            Console.WriteLine("Введите A,B,C : ");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            x = A;
            y = B;
            z = C;
            Console.WriteLine("A=" + (A = y));
            Console.WriteLine("B=" + (B = z));
            Console.WriteLine("C=" + (C = x));
            Console.ReadKey();
        }
    }
}
