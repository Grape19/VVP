using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, x, y;
            Console.WriteLine("Введите двузначное число : ");
            A = int.Parse(Console.ReadLine());
            x = A % 10;
            y = A / 10;
            Console.WriteLine("Полученное число :{0}{1} ",x,y) ;
            Console.ReadKey();
        }
    }
}
