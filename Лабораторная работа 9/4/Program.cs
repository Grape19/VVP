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
            int x;
            Console.WriteLine("Введите число : ");
            x = int.Parse(Console.ReadLine());
            if ((x / 100) > 0)
            {
                switch (x / 100)
                {
                    case 1:
                        Console.WriteLine("Сто");
                        break;
                    case 2:
                        Console.WriteLine("Двести");
                        break;
                    case 3:
                        Console.WriteLine("Триста");
                        break;
                    case 4:
                        Console.WriteLine("Четыреста");
                        break;
                    case 5:
                        Console.WriteLine("Пятьсот");
                        break;
                    case 6:
                        Console.WriteLine("Шестьсот");
                        break;
                    case 7:
                        Console.WriteLine("Семьсот");
                        break;
                    case 8:
                        Console.WriteLine("Восемсот");
                        break;
                    case 9:
                        Console.WriteLine("Девятьсот");
                        break;
                }
            }
            if((x/10)%10>1)
            {
                switch ((x / 10)%10)
                {
                    case 2:
                        Console.WriteLine("Двадцать");
                        break;
                    case 3:
                        Console.WriteLine("Тридцать");
                        break;
                    case 4:
                        Console.WriteLine("Сорок");
                        break;
                    case 5:
                        Console.WriteLine("Пятьдесят");
                        break;
                    case 6:
                        Console.WriteLine("Шестьдесят");
                        break;
                    case 7:
                        Console.WriteLine("Семьдесят");
                        break;
                    case 8:
                        Console.WriteLine("Восемьдесят");
                        break;
                    case 9:
                        Console.WriteLine("Девяносто");
                        break;
                }
            }
            else if (((x / 10) < 20) && ((x / 10) > 9))
            {
                switch ((x / 10))
                {
                    case 10:
                        Console.WriteLine("Десять");
                        break;
                    case 11:
                        Console.WriteLine("Одиннадцать");
                        break;
                    case 12:
                        Console.WriteLine("Двенадцать");
                        break;
                    case 13:
                        Console.WriteLine("Тринадцать");
                        break;
                    case 14:
                        Console.WriteLine("Четырнадцать");
                        break;
                    case 15:
                        Console.WriteLine("Пятнадцать");
                        break;
                    case 16:
                        Console.WriteLine("Шестнадцать");
                        break;
                    case 17:
                        Console.WriteLine("Семнадцать");
                        break;
                    case 18:
                        Console.WriteLine("Восемнадцать");
                        break;
                    case 19:
                        Console.WriteLine("Девятнадцать");
                        break;
                }
            }
            if(x%10>0)
            {
                switch ((x % 10))
                {
                    case 1:
                        Console.WriteLine("Один");
                        break;
                    case 2:
                        Console.WriteLine("Два");
                        break;
                    case 3:
                        Console.WriteLine("Три");
                        break;
                    case 4:
                        Console.WriteLine("Четыре");
                        break;
                    case 5:
                        Console.WriteLine("Пять");
                        break;
                    case 6:
                        Console.WriteLine("Шесть");
                        break;
                    case 7:
                        Console.WriteLine("Семь");
                        break;
                    case 8:
                        Console.WriteLine("Восемь");
                        break;
                    case 9:
                        Console.WriteLine("Девять");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
