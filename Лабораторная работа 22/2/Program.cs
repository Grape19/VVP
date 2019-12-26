using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите адрес файла: ");
            string path = Console.ReadLine();
            Console.WriteLine("Введите N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите K=1: ");
            int k = Convert.ToInt32(Console.ReadLine());
            IEnumerable<string> s = Enumerable.Range(1, k).Select(v => "*");
            for (int i = 0; i < n; i++)
            {
                File.AppendAllText(path, String.Join("", s));
                File.AppendAllText(path, Environment.NewLine);
            }
            string s0 = File.ReadAllText(path);
            Console.WriteLine("Вывод: \n" + s0);
            Console.ReadKey();
        }
    }
}
