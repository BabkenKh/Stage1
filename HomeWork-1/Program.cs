using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            string num2 = Console.ReadLine();
            int num3 = 12;

            Console.Write(num1 + num2); // Concatenation operation
            Console.WriteLine(num1 + num3); // Simple Sum and endline
            Console.WriteLine(num1*num3); // mul operetion

            char simbol1 = 'a';

            Console.Write(simbol1+num2);//Concatenation opr

            byte num4 = 4;

            Console.WriteLine(num3/num4); // Return result after operetion devided
            //I could write something like these, but nothing else came to mind)
            Console.ReadKey();
        }
    }
}
