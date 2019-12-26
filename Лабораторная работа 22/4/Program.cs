using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace _22._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Надя\source\repos\Лабораторная.txt";
            string s = File.ReadAllText(path);
            string Str = new Regex(@"\s+").Replace(s, " ");
            Console.WriteLine(Str);
            File.WriteAllText(path, Str);
            Console.ReadKey();
        }
    }
}