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
            int C, N;
            Console.WriteLine("Введите направление и команду (1-Север,2-Юг,3-Запад,4-Восток; 0-по направлению,1-поворот налево,-1-поворот направо : ");
            C = int.Parse(Console.ReadLine());
            N = int.Parse(Console.ReadLine());
            if (C == 1)
            {
                switch (N)
                {
                    case 0 : Console.WriteLine("Север");
                        break;
                    case 1:
                        Console.WriteLine("Запад");
                        break;
                    case -1:
                        Console.WriteLine("Восток");
                        break;

                }
            }
            if(C==2)
            {
                switch (N)
                {
                    case 0:
                        Console.WriteLine("Юг");
                        break;
                    case 1:
                        Console.WriteLine("Восток");
                        break;
                    case -1:
                        Console.WriteLine("Запад");
                        break;

                }
            }
            if(C==3)
            {
                switch (N)
                {
                    case 0:
                        Console.WriteLine("Запад");
                        break;
                    case 1:
                        Console.WriteLine("Юг");
                        break;
                    case -1:
                        Console.WriteLine("Север");
                        break;

                }
            }
            if(C==4)
            {
                switch (N)
                {
                    case 0:
                        Console.WriteLine("Восток");
                        break;
                    case 1:
                        Console.WriteLine("Север");
                        break;
                    case -1:
                        Console.WriteLine("Юг");
                        break;

                }
            }
            Console.ReadKey();
        }
    }
}
