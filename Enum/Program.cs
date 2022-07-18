using Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Enum.Class1;

namespace Enumss
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            Human human1 = new Human();

            Human.Child child = new Human.Child();


            child.Sum(5,7);

            human1.Jumb();

            human.name = "John";

            Human.Movemant();
            human.Jumb();

            Console.ReadKey();
        }
    }
}
