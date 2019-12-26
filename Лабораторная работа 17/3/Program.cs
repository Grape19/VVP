using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int K, N, C, B = 0, x, y = 0, a, k, l = 0, b = 0, c = 0, m = 0, n = 0, r, S, M, R, f;
            Console.WriteLine("Введите размер массива");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер последовательности");
            K = int.Parse(Console.ReadLine());
            int[] Mas = new int[N + 2];
            int[] Mass = new int[N];
            int[] Masss = new int[N];
            Mas[N] = 0;
            Console.WriteLine("Введите элементы массива");
            for (x = 0; x < N; x++)
            {
                Mas[x] = int.Parse(Console.ReadLine());
            }
            for (x = 0; x < N; x++)
            {
                y = x + 1;
                a = 0;
                k = 1;
                while (Mas[x] == Mas[y])
                {
                    y++;
                    a++;
                }
                if (a != 0)
                    l++;
                if (l == K)
                {
                    b = x;
                    c = y - 1;
                    break;
                }
            }
            for (x = 0; x < N && y < N; x++)
            {
                y = x + 1;
                while (Mas[x] == Mas[y])
                {
                    m = x;
                    n = y;
                    y++;
                }
            }
            B = b;
            C = c;
            f = n - m;
            {
                if ((n - m) == (c - b) && (c - b) != 0)
                {
                    for (; b <= c && m <= n; m++, b++)
                    {
                        k = Mas[b];
                        Mas[b] = Mas[m];
                        Mas[m] = k;
                    }
                }
                else if ((n - m) > (c - b) && (c - b) != 0)
                {
                    r = (n - m) - (c - b);
                    M = m;
                    R = r;
                    for (S = 0; S <= (n - m); S++)
                    {
                        Mass[S] = Mas[M];
                        Masss[S] = Mas[b];
                        b++;
                        M++;
                    }
                    while (r != 0)
                    {
                        for (C = (m + R) + 1; C > c; C--)
                        {
                            Mas[C] = Mas[C - 1];
                        }
                        r--;
                    }
                    for (S = 0; S <= (C - B); S++)
                    {
                        Mas[m + R] = Masss[S];
                        m++;
                    }
                    for (S = 0; S <= C + 1; B++, S++)
                    {
                        Mas[B] = Mass[S];
                    }
                }
                else if ((n - m) < (c - b) && (c - b) != 0)
                {
                    r = (c - b) - (n - m);
                    M = m;
                    R = r;
                    for (S = 0; S <= (c - b); S++)
                    {
                        Mass[S] = Mas[M];
                        Masss[S] = Mas[B];
                        B++;
                        M++;
                    }
                    while (r != 0)
                    {
                        for (C = (b + R); C < m; C++)
                        {
                            Mas[C] = Mas[C + 1];
                            Console.WriteLine("Mas C" + Mas[C]);
                        }
                        r--;
                    }
                    for (S = 0; S <= (c - b); S++)
                    {
                        Mas[m - R] = Masss[S];
                        m++;
                    }
                    for (S = 0, B = b; S <= f; B++, S++)
                    {

                        Mas[B] = Mass[S];
                    }
                }
                Console.WriteLine("Новый массив");
                for (x = 0; x < N; x++)
                {
                    Console.WriteLine("" + Mas[x]);
                }
                Console.ReadKey();
            }
        }
    }
}
