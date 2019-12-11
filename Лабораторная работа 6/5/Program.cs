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
            int N,x;
            Console.WriteLine("Введите номер года : ");
            N = int.Parse(Console.ReadLine());
            x = (N / 100) + 1;
            Console.WriteLine("Столетие : "+x);
            Console.ReadKey();
        }
    }
}
