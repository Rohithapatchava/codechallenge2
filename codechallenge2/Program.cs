using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codechallenge2
{
    class Program
    {
        public delegate string del(int x, int y);
        static void Main(string[] args)
        {
            del delg = new del(AreaofTriangle);
            Console.WriteLine(delg(19, 9));
            delg += new del(AreaofRectangle);
            Console.WriteLine(delg(19, 9));

        }
        public static string AreaofTriangle(int a, int b)
        {
            int c = a * b/2 ;
            return Convert.ToString(c);
        }
        public static string AreaofRectangle(int a, int b)
        {
            int c = a * b;

            return Convert.ToString(c);
        }

    }
}

