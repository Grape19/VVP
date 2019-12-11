using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, y1, y2, AB, BC;
            Console.WriteLine("Введите значения x1,x2,y1,y2:  ");
            x1 = int.Parse(Console.ReadLine());
            x2 = int.Parse(Console.ReadLine());
            y1 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());
            AB = 0;
            BC = 0;

            if (x2 > x1)
            {
                AB = x2 - x1;
                Console.WriteLine("AB = " + AB);
            }
            else if(x1 > x2)
            {
                AB = x1 - x2;
                Console.WriteLine("AB = " + AB);
            }
            if(y2 > y1)
            {
                BC = y2 - y1;
                Console.WriteLine("BC = " + BC);
            }
            else if(y1 > y2)
            {
                BC = y1 - y2;
                Console.WriteLine("BC = " + BC);
            }
            Console.WriteLine("S = " + (AB * BC));
            Console.WriteLine("P = " + 2 * (AB + BC));
            Console.ReadKey();
        }
    }
}
