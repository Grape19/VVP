using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Номер_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N,x;
            Console.WriteLine("Введите значение N:");
            N = int.Parse(Console.ReadLine());
            int[] Mas = new int[N] ;
          Mas[0] = 1;
            if(N>0)
            {
                for(x=0;x<=N;x++)
                {
                    
                    Mas[x+1]=Mas[x]+2;
                    Console.WriteLine("Вывод: " + Mas[x]);
                }
            }
            Console.ReadKey();
        }
    }
}
