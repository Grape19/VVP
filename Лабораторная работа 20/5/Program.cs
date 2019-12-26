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
            int x=0;
            char[] s;
            Console.WriteLine("Введите строку");
            s = Console.ReadLine().ToCharArray();
            char[] s0;
            Console.WriteLine("Введите строку");
            s0 = Console.ReadLine().ToCharArray();
            Console.WriteLine();

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s0.Length; j++)
                {
                    if (s[i] == s0[j])
                    {
                        x++;
                    }
                }
            }
            Console.WriteLine("Количество вхождений:  " + (x/s0.Length) );
            Console.ReadKey();

        }
    }
}