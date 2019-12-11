using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ___6
{
    class Program
    {
        static void Main(string[] args)
        {
            Double  A, x;
            Console.WriteLine("Введите А : ");
            A = int.Parse(Console.ReadLine());
            x = A*A;
            A = x * x;
            x = A * A;
            Console.WriteLine("A^8 = " + x);
            Console.ReadKey();
        }
    }
}
