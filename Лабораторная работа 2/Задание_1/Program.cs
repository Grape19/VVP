using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, y1, y2;
            Console.WriteLine("Введите x1,x2,y1,y2  ");
            x1 = int.Parse(Console.ReadLine());
            x2 = int.Parse(Console.ReadLine());
            y1 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("d = " + Math.Sqrt(Math.Pow(x2 - x1, 2) + (Math.Pow(y2 - y1, 2))));
            Console.ReadKey();
        }
    }
}
