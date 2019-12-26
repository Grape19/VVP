using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[,] a = new double[n, 2];
            Console.WriteLine("Введите координаты точек: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"x{i}: ");
                a[i, 0] = Convert.ToInt32(Console.ReadLine());
                Console.Write($"y{i}: ");
                a[i, 1] = Convert.ToInt32(Console.ReadLine());
            }
            int p1 = 0, p2 = 0, p3 = 0;
            double p, pmax = 0;
            for (int i = 0; i < n; i++)
                for (int i2 = i + 1; i2 < n; i2++)
                    for (int i3 = i2 + 1; i3 < n; i3++)
                    {
                        p = 0;
                        p += Math.Sqrt(Math.Pow(a[i, 0] - a[i2, 0], 2) + Math.Pow(a[i, 1] - a[i2, 1], 2));
                        p += Math.Sqrt(Math.Pow(a[i, 0] - a[i3, 0], 2) + Math.Pow(a[i, 1] - a[i3, 1], 2));
                        p += Math.Sqrt(Math.Pow(a[i2, 0] - a[i3, 0], 2) + Math.Pow(a[i2, 1] - a[i3, 1], 2));
                        if (p > pmax)
                        {
                            p1 = i;
                            p2 = i2;
                            p3 = i3;
                            pmax = p;
                        }
                    }
            Console.WriteLine("Наибольший периметр треугольника: " + pmax);
            Console.WriteLine("Координаты вершин:");
            Console.WriteLine(a[p1, 0] + ", " + a[p1, 1]);
            Console.WriteLine(a[p2, 0] + ", " + a[p2, 1]);
            Console.WriteLine(a[p3, 0] + ", " + a[p3, 1]);
            Console.ReadLine();

        }
    }
}
