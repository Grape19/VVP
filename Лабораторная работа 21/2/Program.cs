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
            int i,n=0,min;
            char[] s;
            Console.WriteLine("Введите строку: ");
            s = Console.ReadLine().ToCharArray();
            min = s.Length;
            for (i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    n++;
                }
                if ((s[i]==' ')||(i==s.Length))
                {
                    if((n!=0)&&(n<min))
                        min = n;
                    n = 0;
                }
            }
            Console.WriteLine("MIN: " + min);
            Console.ReadKey();
        }
    }
}
