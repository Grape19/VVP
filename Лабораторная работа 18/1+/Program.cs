using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность матрицы:");
            int n = int.Parse(Console.ReadLine());
            int[,] mas = new int[n, n];
            Console.WriteLine("Введите элементы матрицы : ");
            int i, j;
            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                {
                    Console.Write($"[{i}][{j}] = ");
                    mas[i, j] = int.Parse(Console.ReadLine());
                }
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write($"{mas[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.Write("Матрица выведенная по спирали:\n");
            for (i = 0; i < n; i++)
                Console.WriteLine(mas[i, 0]);
            for (i = n - 1; i < n; i++)
                for (j = 1; j < n; j++)
                    Console.WriteLine(mas[i, j]);
            for (i = n - 2; i > 0; i--)
                Console.WriteLine(mas[i, n - 1]);
            for (j = n - 1; j > 0; j--)
                Console.WriteLine(mas[0, j]);
            for (i = 1; i < n - 1; i++)
                Console.WriteLine(mas[i, 1]);
            for (j = 2; j < n - 1; j++)
                Console.WriteLine(mas[n - 2, j]);
            for (i = n - 3; i > 0; i--)
                Console.WriteLine(mas[i, n - 2]);
            for (j = n - 3; j > 1; j--)
                Console.WriteLine(mas[1, j]);
            for (i = n / 2; i < n / 2; i++)
                Console.WriteLine(mas[i, i]);
            Console.ReadKey();

        }
    }
}
