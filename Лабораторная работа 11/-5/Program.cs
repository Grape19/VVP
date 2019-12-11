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
            int A, B;
            Console.WriteLine("Введите значения: ");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            while ((A!=0)&&(B!=0))
            {
                if(A>B)
                {
                    A = A % B;
                }
                else
                {
                    B = B % A;
                }
            }
            Console.WriteLine("НОД: " + (A + B));
            Console.ReadKey();
        }
    }
}
