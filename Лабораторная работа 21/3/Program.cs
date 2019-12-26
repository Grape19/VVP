using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n = 0;
            char[] s;
            char c;
            Console.WriteLine("Введите строку: ");
            s = Console.ReadLine().ToCharArray();
            c = s[0];
            for (i = 1; i < s.Length; i++)
            {
                if ((s[i-1] == ' ')&&(s[i]!=' '))
                {
                    c = s[i];
                }
                else if (s[i] == c) 
                {
                    s[i] = '.';
                }
            }
            string result = new string(s);
            Console.WriteLine("Новая строка - " + result);
            Console.ReadKey();
        }
    }
}
