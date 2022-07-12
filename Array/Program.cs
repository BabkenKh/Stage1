using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {

        public static void CountingSort(int[] arr)
        {
            int maxValue = arr[0];
            int minValue = arr[0];

            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                }
                if (arr[i] < minValue)
                {
                    minValue = arr[i];
                }

            }
            int[] bucket = new int[maxValue - minValue + 1];
            for (int i = 0; i < bucket.Length; ++i)
            {
                bucket[arr[i] - minValue]++;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 0;
            }

            for (int i = 0; i < bucket.Length; ++i)
            {
                int count = bucket[i];
                for (int j = 0; j < count; ++j)
                {
                    arr[j] = i + minValue;
                }
            }
        }
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            Random number = new Random();
            int[] arr = new int[size];

            for (int i = 0; i < size; ++i)
            {
                arr[i] = number.Next(10);
            }
            CountingSort(arr);

            int[] arr_copy = arr;
            System.Array.Sort(arr_copy);

            bool result = arr == arr_copy ? true : false;

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
