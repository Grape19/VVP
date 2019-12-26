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
            char[] s;
            int i;

            Console.WriteLine("Введите полное имя файла: ");
            s = Console.ReadLine().ToCharArray();
            i = s.Length;
            i--;
                while (s[i] != '\\')
            {
                i--;
            }
            i++;
              while(s[i]!='.')
                {
                    Console.WriteLine("Новая строка - " + s[i]);
                i++;
                }
            Console.ReadKey();
        }
    }
}
