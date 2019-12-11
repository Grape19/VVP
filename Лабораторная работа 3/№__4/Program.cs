using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ___4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Введите x : ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("y = " + (((3 * Math.Pow(x, 6)) - (6 * (Math.Pow(x, 2))) - 7)));
            Console.ReadKey();
        }
    }
}
