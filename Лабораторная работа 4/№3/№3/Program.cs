using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, X, Y, B, C;
            Console.WriteLine("Введите значение A руб. и X кг и Y кг конфет: ");
            A = int.Parse(Console.ReadLine());
            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());
            B = A / X;
            C = B * Y;
            Console.WriteLine("B: " + B);
            Console.WriteLine("C: " + C);
            Console.ReadKey();
        }
    }
}
