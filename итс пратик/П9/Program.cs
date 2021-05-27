using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace П9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = new int[8, 8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if ((i + j) % 2 == 0)
                        mas[i, j] = 1;
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
            int[,] mass = new int[10, 10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    mass[i, j] = rnd.Next(0, 10);
                    Console.Write(mass[i, j] + " ");
                }
                Console.WriteLine();
            }
            int h = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    h += mass[i, j];
                }
                Console.WriteLine("Сумма элементов строки" + h);
                h = 0;
            }
            int n = 0;
            foreach (int L in mass)
            {
                if (L > 1)
                {
                    n = L;
                    bool flag = true;
                    for (int i = 2; i < n; i++)
                    {
                        if (n % i == 0)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        Console.WriteLine("простoе числo:{0}", n);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
