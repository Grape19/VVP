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
            char[] a = new char[18] { 'а', 'у', 'е', 'ы', 'о', 'э', 'я', 'и', 'ю', 'У', 'Е', 'Ы', 'А', 'Э', 'Я', 'И', 'Ю', '\0' };
            int j, i, kol=0;
            char[] s;
            Console.WriteLine("Введите строку: " );
            s = Console.ReadLine().ToCharArray();
            for (i = 0; i < s.Length; i++)
            {
                for (j = 0; j < 18; j++)
                {
                    if (s[i] == a[j])
                        kol++;
                }
            }
            Console.WriteLine("Количество гласных: " + kol);
            Console.ReadKey();
        }
    }
}
