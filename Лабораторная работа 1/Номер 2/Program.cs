using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа__1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int d;//Объявлена переменная d
            const double PI = 3.14;//Объявлена константа PI
            d = int.Parse(Console.ReadLine());//Присвоили целочисленное значение для переменной d
            Console.WriteLine("L=" + PI * d);//Нашли и вывели длину окружности L
            Console.ReadKey();//Чтобы консоль оставалась открытой

        }
    }
}
