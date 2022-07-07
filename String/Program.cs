using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        // Finde most often symbol and count in string. Algrorithm asimptot analyze O(n).
        static void Main(string[] args)
        {
            string Data = Console.ReadLine();

            int[] asciiArr = new int[256];
            int max_counter = 0;
            char value = ' ';

            for (int i = 0; i < Data.Length; ++i)
            {
                ++asciiArr[Data[i]];   // O(n)
            }

            for (int i = 0; i < Data.Length; ++i)
            {
                if (asciiArr[Data[i]] > max_counter)
                {
                    max_counter = asciiArr[Data[i]];  //O(n)  in general we get O(2n) => O(n)
                    value = Data[i];
                }
            }
            Console.WriteLine("Symbol: " + value + " Count: " + max_counter);

            Console.ReadKey();
        }






    }
}
