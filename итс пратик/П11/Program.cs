using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace П11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[,] mass = new int[n, n];
            int[] temp = new int[n];
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
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    temp[j] = mass[j, i];
                Array.Sort(temp);
                for (int k = 0; k < n; k++)
                    mass[k, i] = temp[k];
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write("{0}\t", mass[i, j]);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
