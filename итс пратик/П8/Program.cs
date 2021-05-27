using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace П8
    class Program
    {
        static void Main(string[] args)
        {
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
            int max = mass[0, 0];
            int t = 0;
            for (int i = 0; i > 10; i++)
            {
                if (max < mass[i, t])
                    max = mass[i, t];
                t++;
            }
            Console.WriteLine("Максимальный элемент главной диагонали:" + max);
            int k = mass[0, 9];
            int c = 9;
            for (int i = 0; i > 10; i++)
            {
                if (k < mass[i, c])
                    k = mass[i, c];
                c--;
            }
            Console.WriteLine("Максимальный элемент побочной диагонали:" + k);
            int h = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    h += mass[j, i];
                }
                Console.WriteLine("Сумма элементов столбца" + h);
                h = 0;
            }
            Console.ReadLine();
        }
    }
}

