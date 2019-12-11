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
            int A, B, C, AB, AC;
            Console.WriteLine("Введите значения A,B,C: ");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            AB =Math.Abs ( B-A );
            AC =Math.Abs ( C-A );
            if(AB>AC)
            {
                Console.WriteLine("Точка C ближе к A : " + C);
                Console.WriteLine("Расстояние равно : " + AC);
            }
            else
            {
                Console.WriteLine("Точка B ближе к A : " + B);
                Console.WriteLine("Расстояние равно : " + AB);
            }
            Console.ReadKey();
        }
    }
}
