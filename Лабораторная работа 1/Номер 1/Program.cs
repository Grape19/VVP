using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа__1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;//Объявлена переменная a
            int b;//Объявлена переменная b
            a = int.Parse(Console.ReadLine());//Присваеваем целочисленное значение для переменной a
            b = int.Parse(Console.ReadLine());//Присваеваем целочисленное значение для переменной b
            Console.WriteLine("S=" + a * b);//Находим и выводим площадь прямоугольника
            Console.WriteLine("P=" + 2 * (a + b));//Находим и выводим периметр прямоугольника
            Console.ReadKey();//Чтобы консоль оставалась открытой


        }
    }
}
