using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Введите значение числа x: ");
            x = int.Parse(Console.ReadLine());
            if(x==0)
            {
                Console.WriteLine("Нулевое число");
            }
            if((x>0)&&(x%2==0))
            {
                Console.WriteLine("Положительное четное число");
            }
            if((x>0)&&(x%2!=0))
            {
                Console.WriteLine("Положительное нечетное число");
            }
            if ((x < 0) && (x % 2 == 0))
            {
                Console.WriteLine("Отрицательное четное число");
            }
            if ((x < 0) && (x % 2 != 0))
            {
                Console.WriteLine("Отрицательное нечетное число");
            }
            Console.ReadKey();
        }
    }
}
