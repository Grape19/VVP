using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, x, y=0,z;
            Console.WriteLine("Введите значения : ");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            z = B;
            if (A > B)
            {
                for (x = B; x <= A; x += z)
                {
                    y = A - x;
                }

                Console.WriteLine("Ответ: " + y);
            }
            else
                Console.WriteLine("Ошибка");
            Console.ReadKey();
        }
    }
}
