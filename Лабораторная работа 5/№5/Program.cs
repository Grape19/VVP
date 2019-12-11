using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, x, y;
            Console.WriteLine("Введите трехзначное число : ");
            A = int.Parse(Console.ReadLine());
            x = A % 100;
            y = A / 100;
            Console.WriteLine("Полученное число :{0}{1} ", x, y);
            Console.ReadKey();
        }
    }
}

