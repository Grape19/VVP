using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, x3, y1, y2, y3;
            double AB, BC, AC, P, p;
            Console.WriteLine("Введите значения переменных x1,x2,x3,y1,y2,y3 : ");
            x1 = int.Parse(Console.ReadLine());
            x2 = int.Parse(Console.ReadLine());
            x3 = int.Parse(Console.ReadLine());
            y1 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());
            y3 = int.Parse(Console.ReadLine());
            AB = Math.Sqrt((Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2)));
            BC = Math.Sqrt((Math.Pow((x2 - x3), 2) + Math.Pow((y2 - y3), 2)));
            AC = Math.Sqrt((Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2)));
            P = AB + BC + AC;
            p = P / 2;
            Console.WriteLine("P = " + P);
            Console.WriteLine("S = " + Math.Sqrt(p * (p - AB) * (p - BC) * (p - AC)));
            Console.ReadKey();
        }
    }
}
