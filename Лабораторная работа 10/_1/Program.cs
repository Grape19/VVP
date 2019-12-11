using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y = 1;
            int n;
            Console.WriteLine("Введите цену конфет за 1 кг: ");
            x = double.Parse(Console.ReadLine());
            double[] Price = new double[] { 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 1 };
            for (n = 0; n < 10; n++)
            {
                y = x * Price[n];
                Console.WriteLine("Cтоимость {0} кг конфет:{1} ", Price[n], y);
            }
            Console.ReadKey();
        }
    }
}
