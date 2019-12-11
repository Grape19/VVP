using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N,x;
            Console.WriteLine("Введите количество секунд : ");
            N = int.Parse(Console.ReadLine());
            x = N % 60;
            Console.WriteLine("Количество секунд прошедших с начала последней минуты : " + x);
            Console.ReadKey();
        }
    }
}
