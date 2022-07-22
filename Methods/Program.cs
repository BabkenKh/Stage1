using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{

    class Program
    {
       
        public static decimal Sum(decimal a, decimal b)
        {
            return a + b;
        }
        public static decimal Sub(decimal a, decimal b)
        {
            return a - b;
        }
        public static decimal Div(decimal a, decimal b)
        {
            if (b == 0)
            {
                Console.WriteLine("Imposible opeation: Warning");
                return 0;
            }
            return a / b;
        }
        public static decimal Mul(decimal a, decimal b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            decimal value_1 = Convert.ToDecimal(Console.ReadLine());
            decimal value_2 = Convert.ToDecimal(Console.ReadLine());

            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":;
                    
                    Console.WriteLine(Sum(value_1, value_2));
                    break;
                case "-":
                    Console.WriteLine(Sub(value_1, value_2));
                    break;
                case "/":
                    Console.WriteLine(Div(value_1, value_2));
                    break;
                case "*":
                    Console.WriteLine(Mul(value_1, value_2));
                    break;
                default:

                    break;
            }
           


            Console.ReadKey();
        }
    }
}
