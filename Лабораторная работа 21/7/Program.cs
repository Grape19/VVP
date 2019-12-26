using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, k=0;
            char[] s;
            string s1 = "";
            string s2 = "";
            string s3 = "";
            char[] s0 = s1.ToCharArray();
            Console.WriteLine("Введите строку: ");
            s = Console.ReadLine().ToCharArray();
            for (i = 1; i < s.Length; i += 2)
            {
                    s1 += s[i];
            }
                for(i=s.Length-1;i>=0;i-=2)
                {
                    s2 += s[i];
                }
                s3 = s1 + s2;
            Console.WriteLine(s3);
            Console.ReadKey();
        }
    }
}
