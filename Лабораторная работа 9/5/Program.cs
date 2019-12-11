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
            int N, x, y, z,c;
            string s;
            string[] Animals = new string[] { "ой крысы", "ой коровы", "ого тигра", "ого зайца", "ого дракона", "ой змеи", "ой лошади", "ой овцы", "ой обезьяны", "ой курицы", "ой собаки", "ой свиньи" };
            string[] Colors1 = new string[] { "зелен", "красн", "желт", "бел", "черн" };
            Console.WriteLine("Введите год : ");
            N = int.Parse(Console.ReadLine());
            if (N > 1984)
            {
                x = N - 1984;
                y = x % 60;
                c = y / 12;
                z = y % 12;
               Console.WriteLine(Colors1[c] + Animals[z]);
            }
            if (N < 1984)
            {
                x = Math.Abs(N - 1984);
                y = x % 60;
                c = y / 12;
                z = y % 12;
                Console.WriteLine(Colors1[4 - c] + Animals[11 - z]);
            }
            Console.ReadKey();
        }
    }
}
