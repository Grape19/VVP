using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ___5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Введите x : ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("y = " + ((4*(Math.Pow ((x-3),6)))-(7*(Math .Pow ((x-3),3)))+2));
            Console.ReadKey();
        }
    }
}
