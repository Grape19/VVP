using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = ("C:/Users/Надя/source/repos/Лабораторная.txt");

            Console.WriteLine("Вывод:");
            using (StreamReader sr = new StreamReader(filename))
            {
                string file = sr.ReadToEnd();

                int whiteSpaceIndex = file.IndexOf(' ');
                file = file.Remove(0, whiteSpaceIndex + 1);

                Console.WriteLine(file);
            }
            Console.ReadKey();
        }
    }
}
