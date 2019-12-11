using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int K;
            double P,S=1000;
            Console.WriteLine("Введите значения процента");
            P = double.Parse(Console.ReadLine());
            if ((P > 0) && (P < 25))
            {
                for (K = 0; S <= 1100; K++)
                {
                    S +=(S * (P/100));
                }
                Console.WriteLine("Количество месяцев и итоговый размер вклада: {0} {1}", K, S);
            }
            else
                Console.WriteLine("Ошибка");
            Console.ReadKey();
        }
    }
}
