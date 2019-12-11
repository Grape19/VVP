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
            int x;
            Console.WriteLine("Введите значение x: ");
            x = int.Parse(Console.ReadLine());
            if((x>0)&&(x<10)&&(x%2==0))
            {
                Console.WriteLine("Однозначное четное число");
            }
            if ((x > 0) && (x < 10) && (x % 2 != 0))
            {
                Console.WriteLine("Однозначное нечетное число");
            }
            if ((x > 9) && (x < 100) && (x % 2 == 0))
            {
                Console.WriteLine("Двузначное четное число");
            }
            if ((x > 9) && (x < 100) && (x % 2 != 0))
            {
                Console.WriteLine("Двузначное нечетное число");
            }
            if ((x > 99) && (x < 1000) && (x % 2 == 0))
            {
                Console.WriteLine("Трехзначное четное число");
            }
            if ((x > 99) && (x < 1000) && (x % 2 != 0))
            {
                Console.WriteLine("Трехзначное нечетное число");
            }
            Console.ReadKey();
        }
    }
}
