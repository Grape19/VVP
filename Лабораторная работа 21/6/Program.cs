using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int  i, k=0;
            char[] s;
            string buf="";
            Console.WriteLine("Введите полное имя файла: ");
            s = Console.ReadLine().ToCharArray();
            i = s.Length-1;
            while ((i > 0) && (s[i] != '\\'))
            {
                i--;
                if ((s[i] == '\\') && (s[i - 1] == ':'))
                {
                    buf="\\";
                    Console.WriteLine(buf);
                }
                else
                i--;
            }
            if (buf != "\\")
            {
                i = s.Length - 1;
                while ((i > 0) && (s[i] != '\\'))
                {
                    i--;
                    k = i;
                }
                for (k = k + 1; k < s.Length; k++)
                {
                    buf += s[k];
                }
                Console.WriteLine(buf);
            }
            Console.ReadKey();
        }
    }
}