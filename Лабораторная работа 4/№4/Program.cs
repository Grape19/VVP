using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int V1, V2, T, S, a;
            Console.WriteLine("Введите V1,V2,T,S : ");
            V1 = int.Parse(Console.ReadLine());
            V2 = int.Parse(Console.ReadLine());
            T = int.Parse(Console.ReadLine());
            S = int.Parse(Console.ReadLine());
            a = ((V1 + V2) * T) + S;
            Console.WriteLine("Расстояние между ними : " + a);
            Console.ReadKey();
        }
    }
}
