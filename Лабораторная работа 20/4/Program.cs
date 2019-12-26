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
            char c;
            Console.WriteLine("Введите символ");
            c = Convert.ToChar(Console.ReadLine());
            char[] s;
            Console.WriteLine("Введите строку");
            s = Console.ReadLine().ToCharArray();
            Console.WriteLine();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    int size = s.Length + 1;
                    Array.Resize(ref s, size);
                    for (int j = s.Length - 2; j >= i; j--)
                    {
                        s[j + 1] = s[j];
                    }
                    i++;
                }

            }
            string result = new string(s);
            Console.WriteLine("Новая строка - " + result);
            Console.ReadKey();

        }
    }
}