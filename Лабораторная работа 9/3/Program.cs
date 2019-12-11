using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Введите количество учебных заданий : ");
            x = int.Parse(Console.ReadLine());
            if ((x > 9) && (x < 41))
            {
                switch (x)
                {
                    case 10: Console.WriteLine("Десять учебных заданий");
                        break;
                    case 11:
                        Console.WriteLine("Одиннадцать учебных заданий");
                        break;
                    case 12:
                        Console.WriteLine("Двенадцать учебных заданий");
                        break;
                    case 13:
                        Console.WriteLine("Тренадцать учебных заданий");
                        break;
                    case 14:
                        Console.WriteLine("Четырнадцать учебных заданий");
                        break;
                    case 15:
                        Console.WriteLine("Пятнадцать учебных заданий");
                        break;
                    case 16:
                        Console.WriteLine("Шестнадцать учебных заданий");
                        break;
                    case 17:
                        Console.WriteLine("Семнадцать учебных заданий");
                        break;
                    case 18:
                        Console.WriteLine("Восемнадцать учебных заданий");
                        break;
                    case 19:
                        Console.WriteLine("Девятнадцать учебных заданий");
                        break;
                    case 20:
                        Console.WriteLine("Двадцать учебных заданий");
                        break;
                    case 21:
                        Console.WriteLine("Двадцать одно учебное задание");
                        break;
                    case 22:
                        Console.WriteLine("Двадцать два учебных задания");
                        break;
                    case 23:
                        Console.WriteLine("Двадцать три учебных задания");
                        break;
                    case 24:
                        Console.WriteLine("Двадцать четыре учебных задания");
                        break;
                    case 25:
                        Console.WriteLine("Двадцать пять учебных заданий");
                        break;
                    case 26:
                        Console.WriteLine("Двадцать шесть учебных заданий");
                        break;
                    case 27:
                        Console.WriteLine("Двадцать семь учебных заданий");
                        break;
                    case 28:
                        Console.WriteLine("Двадцать восемь учебных заданий");
                        break;
                    case 29:
                        Console.WriteLine("Двадцать девять учебных заданий");
                        break;
                    case 30:
                        Console.WriteLine("Тридцать учебных заданий");
                        break;
                    case 31:
                        Console.WriteLine("Тридцать одно учебое задание");
                        break;
                    case 32:
                        Console.WriteLine("Тридцать два учебных задания");
                        break;
                    case 33:
                        Console.WriteLine("Тридцать три учебных задания");
                        break;
                    case 34:
                        Console.WriteLine("Тридцать четыре учебных задания");
                        break;
                    case 35:
                        Console.WriteLine("Тридцать пять учебных заданий");
                        break;
                    case 36:
                        Console.WriteLine("Тридцать шесть учебных заданий");
                        break;
                    case 37:
                        Console.WriteLine("Тридцать семь учебных заданий");
                        break;
                    case 38:
                        Console.WriteLine("Тридцать восемь учебных заданий");
                        break;
                    case 39:
                        Console.WriteLine("Тридцать девять учебных заданий");
                        break;
                    case 40:
                        Console.WriteLine("Сорок учебных заданий");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
