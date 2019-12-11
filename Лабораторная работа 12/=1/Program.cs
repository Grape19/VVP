using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void PowerA3()
        {
            double  A, B;
            Console.WriteLine("Введите значения: ");
            A = double .Parse(Console.ReadLine());
            B = Math.Pow(A, 3);
            Console.WriteLine("Ответ: " + B);

        }
        static void Main(string[] args)
        {
            int n;
            for (n=1;n<=5;n++)
            {
                PowerA3();
            }
            Console.ReadKey();
        }
    }
}
