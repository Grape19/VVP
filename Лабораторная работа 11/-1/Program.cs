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
            int A, B, x, y;
            Console.WriteLine("Введите целые числа : ");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            if (A < B)
            {
                for (x = A; x <= B; x++)
                {
                    for (y = 1; y <= x; y++)
                    {
                        Console.WriteLine("Ответ: " + x);
                    }
                }
            }
            else
                Console.WriteLine("Ошибка");
            Console.ReadKey();
        }
    }
}
