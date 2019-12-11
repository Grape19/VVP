using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static int Sign(double  X)
        {
            if (X < 0)
                return -1;
            else if (X == 0)
                return 0;
            else
                return 1;

        }
        static void Main(string[] args)
        {
            double A, B;
            Console.WriteLine("Введите значения A,B: ");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            Sign(A);
            Sign(B);
            Console.WriteLine("Ответ: " + (Sign(A) + Sign(B)));
            Console.ReadKey();
        }
    }
}
