using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N,x,y;
            y = 0;
            Console.WriteLine("Введите целое число : ");
            N = int.Parse(Console.ReadLine());
            for(x=1;x<=((2*N)-1);x+=2)
            {
                y+= x;
                Console.WriteLine("y=" + y);
            }
            Console.ReadKey();
        }
    }
}
