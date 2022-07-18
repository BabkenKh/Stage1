using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public class Class1
    {

        public struct Human
        {
            public class Child
            {
                public int age;

                public int Sum(int a, int b)
                {
                    
                    return a+b;
                }
            }

            public int age;
            public string name;

            public static void Movemant()
            {
                Console.WriteLine("Step");
            }

            public void Jumb()
            {
                Console.WriteLine("Jumb");
            }
        }


    }
}
