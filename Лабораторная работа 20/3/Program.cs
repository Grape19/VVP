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
            string s;
            int i, k=0;
            Console.WriteLine("Введите строку: ");
            s = Console.ReadLine();
            for(i=0;i<s.Length;i++)
            {
                if((s[i]>='A')&&(s[i]<='Z'))
                {
                    k++;
                }
            }
            if (k != 0)
            {
                Console.WriteLine("Количество прописных латинских букв: " + k);
            }
            else
                Console.WriteLine("Нет прописных латинских букв ");
            Console.ReadKey();
        }
    }
}
