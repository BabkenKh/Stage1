using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string Data = Console.ReadLine();
            int count = 1;
            int max = -1;
            char symbol = ' ';


            for (int i = 0; i < Data.Length; ++i)
            {
                count ^= count;  // xor 
                for (int j = i; j < Data.Length - 1; ++j)
                {
                   
                    if (Data[i] == Data[j + 1])
                    {
                        count++;
                    }

                }
                if (count > max)
                {
                    
                    symbol = Data[i];
                }

            }

            Console.WriteLine("Symbol: " + symbol);



            Console.ReadKey();
        }
    }
}
