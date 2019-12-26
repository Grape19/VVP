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
            string C = "C";
            int x = C[0];
            string D = "";
            D += (char)(x + 1);
            string B = "";
            B += (char)(x - 1);
            Console.WriteLine("Символы: {0} {1} {2}", B, C, D);
            Console.ReadKey();
        }
    }
}
