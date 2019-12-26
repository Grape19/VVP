using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Надя\source\repos\Лабораторная.txt";
            string way = @"C:\Users\Надя\source\repos\ЛЯЛЯЛЯ.txt";
            string s = File.ReadAllText(path);
            string s0 = File.ReadAllText(way);
            File.WriteAllText(path, s0+s);
            Console.ReadKey();
        }
    }
}
