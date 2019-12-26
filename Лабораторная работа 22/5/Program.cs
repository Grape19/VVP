using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _22._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            foreach (string path in File.ReadLines(@"C:\Users\Надя\source\repos\Лабораторная.txt"))
            {
                if (path.Contains("     "))
                {
                    x++;
                }
            }
            Console.WriteLine("Количество абзацов в тексте: " + x);
            Console.ReadKey();
        }
    }
}
