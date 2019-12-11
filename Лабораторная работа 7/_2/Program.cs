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
            int A, B, C;
            Console.WriteLine("Введите значения A,B,C : ");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            if ((A < B) && (B < C))
            {
                Console.WriteLine("Неравенство справедливо для A,B,C :{0}{1}{2} ", A, B, C);
            }
            else
                Console.WriteLine("Неравенство не справедливо");
            Console.ReadKey();
        }
    }
}
