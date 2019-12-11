using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static double RingS(double R1,double R2)
        {
            double  S;
            if(R1>R2)
            {
                S = (Math.PI * Math.Pow(R1, 2)) - (Math.PI * Math.Pow(R2, 2));
                return S;
            }
            return 0;
        }
        static void Main(string[] args)
        {
            int n;
            double R1, R2;
            for (n=1;n<=3;n++)
            {
                Console.WriteLine("Введите значения R1,R2: ");
                R1 = double.Parse(Console.ReadLine());
                R2 = double.Parse(Console.ReadLine());
                RingS(R1,R2);
                Console.WriteLine("Ответ : "+RingS (R1,R2));
            }
            Console.ReadKey();
        }
    }
}
