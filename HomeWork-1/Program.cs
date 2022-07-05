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

            //Console.WriteLine("Enter your number1");

            //decimal number1 = Convert.ToDecimal(Console.ReadLine());

            //Console.WriteLine("Enter your numbers: ");
            //int a = Convert.ToInt32(Console.ReadLine());

            //int sum = 0;

            //for (; a != 0; a /= 10)
            //{
            //    sum += a % 10;
            //}

            //Console.WriteLine(sum);


            // Buble sort O(n^2)


            const int size = 5;

            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; ++i)
            {
                Console.Write(arr[i] + " ");
            }

            for (int j = 0; j < arr.Length; ++j)
            {
                for (int i = 1; i < arr.Length - j; ++i)
                {
                    if (arr[i-1] > arr[i])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = temp;
                    }
                }
            }
            
            Console.WriteLine();
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.Write(arr[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
