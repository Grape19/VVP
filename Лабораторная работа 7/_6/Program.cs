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
            int a, b, c;
            Console.WriteLine("Введите значения сторон треугольника a,b,c : ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if(c*c==((a*a)+(b*b)))
                {
                Console.WriteLine("Треугольник со сторонами a, b, c является прямоугольным");
                }
            else
            {
                Console.WriteLine("Треугольник со сторонами a, b, c не является прямоугольным");
            }
            Console.ReadKey();
        }
    }
}
