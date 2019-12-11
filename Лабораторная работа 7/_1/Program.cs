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
            int A, B;
            Console.WriteLine("Введите значения A,B : ");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            if ((A > 2) && (B <= 3))
            {
                Console.WriteLine("Неравенство справедливо для A,B : {0}{1}", A, B);
            }
            else
                Console.WriteLine("Неравенство не справедливо");
            Console.ReadKey();
        }
    }
}
