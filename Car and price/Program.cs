using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_and_price
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Count Cars");
            Cars cars = new Cars();

            cars.ListCars();

            Console.ReadKey();
        }
    }
}
