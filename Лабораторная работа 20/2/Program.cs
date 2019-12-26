using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string S,S1;
            Console.WriteLine("Введите строку: ");
            S = Console.ReadLine();
            S1 = S[0].ToString();
            for(i=1;i<S.Length;i++)
            {
                S1=S1+ ' ' + S[i].ToString();
            }
            Console.WriteLine("Строка: " + S1);
            Console.ReadKey();
        }
    }
}
