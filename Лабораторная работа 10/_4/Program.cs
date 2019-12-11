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
            int N,x;
            double A,y=0;
            Console.WriteLine("Введите значение А и N: ");
            A = double.Parse(Console.ReadLine());
            N = int.Parse(Console.ReadLine());
            for(x=0;x<=N;x++)
            {
                y += Math.Pow(A, x);
            }
            Console.WriteLine("Ответ: "+y);
            Console.ReadKey();
        }
    }
}
