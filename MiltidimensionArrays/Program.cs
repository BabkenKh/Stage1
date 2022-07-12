using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltidimensionArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int size_1 = Convert.ToInt32(Console.ReadLine());
            int size_2 = Convert.ToInt32(Console.ReadLine());

            Random value = new Random();
            int[,] matrix = new int[size_1, size_2];

            // Input value in matrix
            for (int i = 0; i < size_1; ++i)
            {
                for (int j = 0; j < size_2; ++j)
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Prtint matrix
            for (int i = 0; i < size_1; ++i)
            {
                for (int j = 0; j < size_2; ++j)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            int count = 0;
            for (int k = 0; k < size_2; ++k)
            {
                for (int i = 1; i < size_1; ++i)
                {
                    for (int j = 0; j < size_2; ++j)
                    {

                        if (matrix[0, k] == matrix[i, j])
                        {
                            ++count;
                            break;
                        }

                    }

                }
                if (count == size_1 - 1)
                {
                    Console.WriteLine("Reaped value:" + matrix[0, k]);
                }
                else
                {
                    Console.WriteLine("Number is absence");
                }
                count ^= count;
            }

            Console.ReadKey();

        }
    }
}
