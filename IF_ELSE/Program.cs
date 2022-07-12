using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_ELSE
{
    class Program
    {
        static void Main(string[] args)
        {
            // 21 Output Greater betwenn a,b,c;

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine(a);
            }
            else if (b > c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("==========================");

            //23
            if (a == 1 || b == 1 || c == 1)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.WriteLine("=============================");
            //24

            if (a == 2 && b == 2 || a == 2 && c == 2 || b == 2 && c == 2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.WriteLine("============================");
            //25
            if (a + b > c || a + c > b || b + c > a)
            {
                Console.WriteLine("y=1");
            }
            else
            {
                Console.WriteLine("y=2");
            }
            Console.WriteLine("======================");
            //26

            if (a % 2 == 0 || b % 2 == 0 || c % 2 == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("2");
            }
            Console.WriteLine("=========================");
            //27

            int d = a - b;

            if((c-b) == d)
            {
                Console.WriteLine("True");
            }else
            {
                Console.WriteLine("False");
            }
            Console.WriteLine("====================="); 
            //28
            int q = b/a;

            if ((c /b) == q)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            Console.ReadLine();
        }
    }
}
