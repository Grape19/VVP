using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа__1_4
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
                Console.WriteLine("Найти сумму двух квадратов ненулевых чисел = " + (Math.Pow(a, 2) + Math.Pow(b, 2)));//Находим и выводим сумму двух квадратов ненулевых чисел
                Console.WriteLine("Найти разность двух квадратов ненулевых чисел = " + (Math.Pow(a, 2) - Math.Pow(b, 2)));//Находим и выводим разность двух квадратов ненулевых чисел
                Console.WriteLine("Найти частное двух квадратов ненулевых чисел = " + (Math.Pow(a, 2) / Math.Pow(b, 2)));//Находим и выводим частное двух квадратов ненулевых чисел
                Console.WriteLine("Найти произведение двух квадратов ненулевых чисел = " + (Math.Pow(a, 2) * Math.Pow(b, 2)));//Находим и выводим произведние двух квадратов ненулевых чисел
            }
            else
                Console.WriteLine("Ошибка в выполнении условия");//Вывод, если числа нулевые
            Console.ReadKey();//Чтобы консоль оставалась открытой


        }
    }
}
