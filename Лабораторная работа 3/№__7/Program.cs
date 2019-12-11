using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ___7
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, x, y;
            Console.WriteLine("Введите A : ");
            A = int.Parse(Console.ReadLine());
            x = A * A * A;
            y = x * x;
            A = y * y * x;
            Console.WriteLine("A^15 = " + A);
            Console.ReadKey();
        }
    }
}
