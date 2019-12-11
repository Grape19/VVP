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
            int x;
            Console.WriteLine("Введите значение x : ");
            x = int.Parse(Console.ReadLine());
            if ((x > 0) && (x % 2 == 0) && ((x / 10) > 0)&&(x/100==0))
            {
                Console.WriteLine(" Данное число является четным и двузначным : " + x);
            }
            else
                Console.WriteLine(" Данное число не является четным и двузначным ");
            Console.ReadKey();
        }
    }
}
