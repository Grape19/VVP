using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, k=0;
            char[] s;
            Console.WriteLine("Введите строку: ");
            s = Console.ReadLine().ToCharArray();
            for(i=0;i<s.Length;i++)
            {
                if((s[i]==' ')&&(s[i-1]!=' '))
                {
                    k++;
                }
            }
            k++;
            Console.WriteLine("Количество слов: " + k);
            Console.ReadKey();
        }
    }
}
