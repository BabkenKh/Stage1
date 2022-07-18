using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_and_price
{
    class Cars
    {
        int size = Convert.ToInt32(Console.ReadLine());

        public void ListCars()
        {

            string[] DataCars = new string[size];
            int[] DataPrice = new int[size];

            for (int i = 0; i < size; ++i)
            {
                DataCars[i] = Console.ReadLine();
            }

            Random value = new Random();

            for (int i = 0; i < size; ++i)
            {
                DataPrice[i] = value.Next() % 1000000;
                Console.WriteLine(DataPrice[i]);
            }
            FindeCar(DataCars, DataPrice);
        }

        void FindeCar(string[] CarList, int[] PriceList)
        {
            Console.WriteLine("If you want find car with price input 0 or not input 1: ");
            byte check = Convert.ToByte(Console.ReadLine());

            if (check != 0)
            {
                Console.Write("Input name car: ");
                bool temp = true;
                string key = Console.ReadLine();

                for (int i = 0; i < size; ++i)
                {
                    if (CarList[i] == key)
                    {
                        Console.WriteLine("Price car: " + PriceList[i] + "$");
                        temp = false;
                    }
                }
                if (temp)
                {
                    Console.WriteLine("This car not exist");
                }

            }
            else
            {
                Console.Write("Input Price: ");
                bool temp = true;
                int key = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < size; ++i)
                {
                    if (PriceList[i] == key)
                    {
                        Console.WriteLine("Your car: " + CarList[i]);
                        temp = false;
                    }
                }
                if (temp)
                {
                    Console.WriteLine("Don't found this car");
                }

            }

        }
    }
}
