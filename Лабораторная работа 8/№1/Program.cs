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
            Console.WriteLine("Введите значения A и B : ");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            if (A == B)
            {
                A = 0;
                B = 0;
                Console.WriteLine("A,B: {0}{1}", A, B);
            }
            else if(A>B)
            {
                B = A;
                Console.WriteLine("A,B: {0}{1}", A, B);
            }
            else
            {
                A = B;
                Console.WriteLine("A,B: {0}{1}", A, B);
            }
            Console.ReadKey();
        }
    }
}
