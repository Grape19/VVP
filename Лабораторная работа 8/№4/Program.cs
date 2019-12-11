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
            int x, y;
            Console.WriteLine("Введите координаты точки x и y: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            if ((x > 0) && (y > 0))
            {
                Console.WriteLine("Точка находится в 1 четверти ");
            }
            else if ((x < 0) && (y > 0))
            {
                Console.WriteLine("Точка находится во 2 четверти");
            }
            else if ((x < 0) && (y < 0))
            {
                Console.WriteLine("Точка находится во 3 четверти");
            }
            else if ((x > 0) && (y < 0))
            {
                Console.WriteLine("Точка находится во 4 четверти");
            }
            Console.ReadKey();
        }
    }
}
        
