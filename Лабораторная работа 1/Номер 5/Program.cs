using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа__1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;//Объявлены переменные a и b
            a = int.Parse(Console.ReadLine());//Присваеваем целочисленное значение для переменной a
            b = int.Parse(Console.ReadLine());//Присваеваем целочисленное значение для переменной b
            if ((a != 0) && (b != 0))//Условие при котором числа ненулевые
            {
                Console.WriteLine("Найти сумму двух модулей ненулевых чисел = " + (Math.Abs(a) + Math.Abs(b)));//Находим и выводим сумму двух модулей ненулевых чисел
                Console.WriteLine("Найти разность двух модулей ненулевых чисел = " + (Math.Abs(a) - Math.Abs(b)));//Находим и выводим разность двух модулей ненулевых чисел
                Console.WriteLine("Найти частное двух модулей ненулевых чисел = " + (Math.Abs(a) / Math.Abs(b)));//Находим и выводим частное двух моедулей ненулевых чисел
                Console.WriteLine("Найти произведение двух модулей ненулевых чисел = " + (Math.Abs(a) * Math.Abs(b)));//Находим и выводим произведние двух модулей ненулевых чисел
            }
            else
                Console.WriteLine("Ошибка в выполнении условия");//Вывод, если числа нулевые
            Console.ReadKey();//Чтобы консоль оставалась открытой
        }
    }
}
