using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace П1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                string q = Console.ReadLine();
                int w = Convert.ToInt32(Console.ReadLine());
                lib1.Stpow(q, w);
            }
            if (a == 2)
            {
                string e = Console.ReadLine();
                lib1.Rev(e);
            }
            if (a == 3)
            {
                string s = Console.ReadLine();
                string h = Console.ReadLine();
                lib1.Remove(s, h);
            }
            if (a == 4)
            {
                string t = Console.ReadLine();
                lib1.Lenght(t);
            }
        }
    }
    static class lib1
    {
        public static void Stpow(string a, int b)
        {
            string c = "";
            for (int i = 0; i < b; i++)
            {
                c += a;
            }
            Console.WriteLine(c);
            Console.ReadLine();
        }
        public static void Rev(string a)
        {
            string c = "";
            for (int i = a.Length - 1; i > -1; i--)
            {
                c += a[i];
            }
            Console.WriteLine(c);
            Console.ReadLine();
        }
        public static void Remove(string s, string h)
        {
            string c = "";
            c = s.Replace(h, "");
            Console.WriteLine(c);
            Console.ReadLine();
        }
        public static void Lenght(string str)
        {
            int t = str.Length;
            Console.WriteLine(t);
            Console.ReadLine();
        }
    }

}