using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа__1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;//Объявлены переменные a и b
            a = int.Parse(Console.ReadLine());//Присвоили целочисленное значение перменной a
            b = int.Parse(Console.ReadLine());//Присвоили целочисленное значение переменной b
            Console.WriteLine("Среднее арифметическое значение a и b = " + (a + b) / 2);//Найти и вывести среднее арифметическое значение
            Console.ReadKey();//Чтобы консоль не закрывалась
        }
    }
}
