using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static int Quarter(double  x,double  y)
        {
            if ((x > 0) && (y > 0))
                Console.WriteLine("1 четверть");
            else if ((x > 0) && (y < 0))
                Console.WriteLine("4 четверть");
            else if ((x < 0) && (y < 0))
                Console.WriteLine("3 четверть");
            else
                Console.WriteLine("2 четверть");
            return 0;
        }
        static void Main(string[] args)
        {
            double x, y,n;
            for(n=1;n<=3;n++)
            {
                Console.WriteLine("Введите координаты: ");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
                Quarter(x, y);
            }
            Console.ReadKey();
        }
    }
}
