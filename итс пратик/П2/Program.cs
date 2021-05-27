using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace П2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string c = "";
            //int f = 0;
            //int index = 0;
            //c = Console.ReadLine();
            //for(int i = 0; i<c.Length; i++)
            //{
            //    if (c[i] == 'f')
            //    {
            //        f++;
            //        if (f == 2)
            //        {
            //            index += i;
            //        }
            //    }
            //}
            //if (f > 2)
            //{
            //    Console.WriteLine("Второе вхождение F:"+index);
            //    Console.WriteLine("Колличество F:"+f);
            //}
            //if (f== 1)
            //    {
            //    Console.WriteLine(-1);
            //}
            //if (f == 2)
            //{
            //    Console.WriteLine("Второе вхождение F:" + index);
            //    Console.WriteLine("Колличество F:" + f);
            //}
            //if (f == 0)
            //{
            //    Console.WriteLine(-2);
            //}
            //Console.ReadLine();

            string translit = "";
            string Word = Console.ReadLine();
            char[] rus = { 'а', 'б', 'в', 'г', 'д', 'е', 'ж', 'з', 'и', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ы', 'э', 'ю', 'я' };
            string[] eng = { "a", "b", "v", "g", "d", "e", "j", "z", "i", "k", "l", "m", "n", "o", "p", "r", "s", "t", "y", "f", "h", "c", "ch", "sh", "sh", "ie", "e", "ye", "ya" };
            for (int i = 0; i < Word.Length; i++)
            {
                for (int c = 0; c < rus.Length; c++)
                {
                    if (Word[i] == rus[c])
                    {
                        translit += eng[c];
                    }
                }
            }
            Console.WriteLine(translit);
            Console.ReadLine();

            string str = Console.ReadLine(), otv = "";
            int n = 0, m = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'h')
                    n++;
            }
            for (int j = 0; j < str.Length; j++)
            {
                if (str[j] == 'h')
                {
                    if (m != 0 && m != n - 1)
                        otv += "H";
                    else otv += "h"; m++;
                }
                else otv += str[j];
            }
            Console.WriteLine(otv);
            Console.ReadLine();
        }

    }
}