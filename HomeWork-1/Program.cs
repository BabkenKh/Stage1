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
            //int num1 = 5;
            //string num2 = Console.ReadLine();
            //int num3 = 12;

            //Console.Write(num1 + num2); // Concatenation operation
            //Console.WriteLine(num1 + num3); // Simple Sum and endline
            //Console.WriteLine(num1*num3); // mul operetion

            //char simbol1 = 'a';
            //Console.WriteLine(simbol1+num2);//Concatenation opr

            //byte num4 = 4;
            //Console.WriteLine(num3 / num4); // Return result after operetion devided

            //Console.ReadLine(); // Input: Wats your name?
            //String name = "Ilon ";
            //String lastName = "Mask";
            //Console.WriteLine(name + lastName);

            //I could write something like these, but nothing else came to mind)
            //double doub = 27.21312443244444444444;
            //Console.WriteLine(doub);

            //float floa = 23.22123333333333333f;
            //Console.WriteLine(floa);

            //decimal fla = 22123333333333335788444444477.8888888333333333333388876887687678683m;
            //Console.WriteLine(fla);

            ////decimal sum = (decimal)((double)floa + doub);
            ////Console.WriteLine(sum);

            Console.WriteLine("Enter your number1");

            decimal number1 = Convert.ToDecimal(Console.ReadLine());
            

            Console.WriteLine("Enter your number2");
            decimal number2 = Convert.ToDecimal(Console.ReadLine());
            
            

            decimal result = number1 + number2;

            Console.WriteLine(result);
           

            






            Console.ReadKey();
        }
    }
}
