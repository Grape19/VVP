﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа__4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, x, PI = Math.PI;
            Console.WriteLine("Введите a: ");
            a = int.Parse(Console.ReadLine());
            x = 180;
            if ((a > 0) && (a < 360))
            {
                x = PI;
                a = (PI * a) / 180;
                Console.WriteLine("a = " + a);
            }
            else
                Console.WriteLine("Ошибка");
            Console.ReadKey();
        }
    }
}
