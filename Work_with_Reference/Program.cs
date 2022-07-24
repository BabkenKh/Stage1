using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_with_Reference
{
    // key workd "ref"

    class MyClass
    {
        public int a;
        public double b;
        public float c;
    }

    class Program
    {
        static void Foo(MyClass myClass)
        {
            myClass.a = -5;
        }

        static void AddElArr(ref int[] myArr, int newSize, int index, int value)
        {
            int[] otherArr = new int[newSize];

            otherArr[index] = value;

            for (int i = 0; i < index; ++i)
            {
                otherArr[i] = myArr[i];
            }
            for (int i = index; i < newSize-1; ++i)
            {
                otherArr[i+1] = myArr[i];
            }

            myArr = otherArr;
        }

        static void Main(string[] args)
        {
            int size = 5;
            int index = Convert.ToInt32(Console.ReadLine());
            int value = Convert.ToInt32(Console.ReadLine());

            int[] myArr = { 1, 2, 3, 5, 6 };

            if (index >= 0 && index <= myArr.Length)
            {
                AddElArr(ref myArr, size + 1,index, value);
            }
            else
            {
                Console.WriteLine("Index: Out of Range Arr");
            }

            for(int i =0; i < myArr.Length;++i)
            {
                Console.WriteLine(myArr[i]);
            }

            Console.ReadKey();
        }
    }
}
